using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using NEXCORE.Common.Data;
using Skcc.Data;
using NEXCORE.Utility;

namespace NEXCORE.Components.ComponentManager
{
    public class ComponentManager : MarshalByRefObject
    {
        private static ComponentManager _cm;
        private string _assemblyPath;
        const string COMPONENT_POOL_PATH = "COMPONENT_POOL_PATH";

        ComponentList _componentList = new ComponentList();

        #region Definition For Base Type Full Name
        const string BIZTYPE = "NEXCORE.Common.SKBizBase";
        const string DACTYPE = "NEXCORE.Common.SKDacBase";
        #endregion

        private Dictionary<string, Type> _assemblyList = new Dictionary<string, Type>();

        public static ComponentManager This()
        {
            if (_cm == null)
            {
                _cm = new ComponentManager();
                _cm.Initilize();
                _cm.Setup();
            }

            return _cm;
        }

        public void Initilize()
        {
            string path = Skcc.Configuration.SkccFxConfigManager.GetString(COMPONENT_POOL_PATH);
            if (string.IsNullOrEmpty(path))
            {
                path = ".";
            }

            _assemblyPath = path;

            Skcc.Diagnostics.LogWrapper.Write("Component Pool Path : " + _assemblyPath, "Framework");
        }

        public void Setup()
        {
            DirectoryInfo dInfo = new DirectoryInfo(_assemblyPath);

            CreateComponentInstance(dInfo);
        }

        protected void CreateComponentInstance(DirectoryInfo dInfo)
        {
            DirectoryInfo[] dInfoList = dInfo.GetDirectories();

            if (dInfoList != null && dInfoList.Length > 0)
            {
                foreach (DirectoryInfo d in dInfoList)
                {
                    CreateComponentInstance(d);
                }
            }

            // Biz file
            FileInfo[] bizFileInfoList = dInfo.GetFiles("SK.*Biz.dll");
            foreach (FileInfo fInfo in bizFileInfoList)
            {
                Skcc.Diagnostics.LogWrapper.Write("Loading Business Assembly : " + fInfo.FullName, "Framework");
                LoadAssembly(fInfo);
            }

            // Interface file
            FileInfo[] ifFileInfoList = dInfo.GetFiles("SK.*Interface.dll");
            foreach (FileInfo fInfo in ifFileInfoList)
            {
                Skcc.Diagnostics.LogWrapper.Write("Loading Interface Assembly : " + fInfo.FullName, "Framework");
                LoadAssembly(fInfo);
            }
        }

        protected void LoadAssembly(FileInfo fInfo)
        {
            try
            {
                Component cmp = new Component(fInfo.FullName);
                if (cmp.MethodList.Count > 0)
                    _componentList.Add(cmp);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private byte[] ReadFile(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open, System.IO.FileAccess.Read);
            byte[] buffer = new byte[(int)fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();

            return buffer;
        }

        public Method GetMethod(string methodName)
        {
            foreach (Component cmp in this._componentList.Components.Values)
            {
                if (!cmp.MethodList.Contain(methodName))
                    continue;

                Method m = cmp.MethodList[methodName];

                if (m != null)
                    return m;
            }

            return null;
        }

        public Method GetMethod(string typeString, string methodName)
        {
            foreach (Component cmp in this._componentList.Components.Values)
            {
                if (!cmp.MethodList.Contain(typeString + "_" + methodName))
                    continue;

                Method m = cmp.MethodList[typeString + "_" + methodName];
                if (m.TypeString.ToLower() == typeString.ToLower())
                    return m;
            }

            return null;
        }



        public NEXCOREData InvokeFunction(string fullName, string methodName, NEXCOREData paras)
        {
            NEXCOREData RetVal = null;

            Method m = GetMethod(fullName, methodName);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            try
            {
                string msg = string.Format("ComponentManager.InvokeFunction : {0} / {1}", fullName, methodName);
                UtilityHelper.WriteLog(UtilityHelper.WriteNEXCOREDataLog(string.Format("Start - {0}", msg), paras),
                    UtilityHelper.eLogCategory.Component, TraceEventType.Information);

                RetVal = m.Invoke(paras);

                sw.Stop();

                UtilityHelper.WriteLog(string.Format("End - {0} : {1}", msg, sw.Elapsed.ToString()), UtilityHelper.eLogCategory.Component, TraceEventType.Information);
            }
            catch (Exception e)
            {
                sw.Stop();
                UtilityHelper.WriteLog(e.ToString(), UtilityHelper.eLogCategory.Component, TraceEventType.Error);

                Debug.Print(e.InnerException != null ? e.InnerException.Message : e.Message);
            }
            return RetVal;
        }

        public NEXCOREData InvokeTransactionFunction(string fullName, string methodName, NEXCOREData paras)
        {
            NEXCOREData RetVal = null;

            Method m = GetMethod(fullName, methodName);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            try
            {
                using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
                {
                    string msg = string.Format("ComponentManager.InvokeTransactionFunction : {0} / {1}", fullName, methodName);
                    UtilityHelper.WriteLog(UtilityHelper.WriteNEXCOREDataLog(string.Format("Start - {0}", msg), paras),
                        UtilityHelper.eLogCategory.Component, TraceEventType.Information);

                    RetVal = m.Invoke(paras);
                    if (RetVal.intCnt != -1)
                        scope.Complete();
                    else
                    {
                        if (RetVal.Object != null)
                            UtilityHelper.WriteLog((string)RetVal.Object, UtilityHelper.eLogCategory.Framework, TraceEventType.Error);
                    }

                    sw.Stop();

                    UtilityHelper.WriteLog(string.Format("End - {0} : {1}", msg, sw.Elapsed.ToString()), UtilityHelper.eLogCategory.Component, TraceEventType.Information);
                }
            }
            catch (Exception e)
            {
                sw.Stop();
                UtilityHelper.WriteLog(e.ToString(), UtilityHelper.eLogCategory.Component, TraceEventType.Error);

                Debug.Print(e.InnerException != null ? e.InnerException.Message : e.Message);
            }
            return RetVal;
        }

        /// <summary>
        /// Set Lifetime when ComponentManager is loading
        /// </summary>
        /// <returns></returns>
        public override Object InitializeLifetimeService()
        {
            // Reference MSDN
            // Problem: Losing the connection when ComponentManager is in idle status
            // If InitializeLifetimeService returns null,
            // the object's lifetime is infinite and is not garbage collected until the hosting application domain is unloaded.
            return null;
        }

    }
}

using System;
using System.Collections;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

namespace NEXCORE.Components.ComponentManager
{
	/// <summary>
	/// Component Class
	/// </summary>
	public class Component: MarshalByRefObject, IComponent
	{
        private string m_Name = "";
        private string m_FileName = "";
        private string m_Version = "";
        private DateTime m_CreationTime;
        private DateTime m_LastWriteTime;

        private Loader m_Loader;
        private MethodList m_MethodList;
   
        private ComponentType m_Type = 0;

        private bool m_IsLoaded = false;
        private bool m_IsUnloadable = false;

        private MethodInfo m_InitMethod;
        private MethodInfo m_SetupMethod;
        private MethodInfo m_TerminateMethod;
        //private ICore m_IFace;
        private string m_ConfigFile;

        public Component(string fileName)
        {
            Initialize(fileName);
        }

        private void Initialize(string fileName)
        {
            FileInfo fInfo = new FileInfo(fileName);

            if (fInfo == null)
                return;

            m_Name = fInfo.Name;
            m_FileName = fileName;
            m_Loader = new Loader();
            
            m_MethodList = m_Loader.Load(fileName);
            m_IsUnloadable = true;
            
            m_InitMethod = m_Loader.GetMethod("Initialize");
            m_SetupMethod = m_Loader.GetMethod("Setup");
            m_TerminateMethod = m_Loader.GetMethod("Terminate");

            if (m_InitMethod != null)
            {
                // To enable SK.*.Entity.dll on the memory - SK.WMS.Common.Biz.CommonBiz.cs
                m_InitMethod.Invoke(null, null);
            }
            
            m_IsLoaded = true;
        }

        #region Properties Get/Set Code



        public string Name
        {
            get { return m_Name; }
        }

        public string FileName
        {
            get { return m_FileName; }
        }

        public ComponentType Type
        {
            get { return m_Type; }
        }

        public Loader Loader
        {
            get { return m_Loader; }
        }

        public MethodList MethodList
        {
            get { return m_MethodList; }
        }

        public bool IsLoaded
        {
            get { return m_IsLoaded; }
        }

        public bool IsUnloadable
        {
            get { return m_IsUnloadable; }
        }

        public MethodInfo InitMethod
        {
            get { return m_InitMethod; }
        }

        public MethodInfo SetupMethod
        {
            get { return m_SetupMethod; }
        }

        public MethodInfo TerminateMethod
        {
            get { return m_TerminateMethod; }
        }

        //public ICore Interface
        //{
        //    get { return m_IFace; }
        //    set { m_IFace = value; }
        //}

        public string Version
        {
            get { return m_Version; }
        }

        public DateTime CreationTime
        {
            get { return m_CreationTime; }
        }

        public DateTime LastWriteTime
        {
            get { return m_LastWriteTime; }
        }

        public ComponentType TPComponentType
        {
            get { return m_Type; }
        }

        public string ConfigFile
        {
            get { return m_ConfigFile; }
            set { m_ConfigFile = value; }
        }

        #endregion

        public void Initilize(object o)
        {

        }

        public void Setup(object o)
        {
            m_SetupMethod.Invoke(null, new object[]{o});
        }

        public void Terminate(object o)
        {

        }

        public void ReadAssebmlyInfo()
        {
            try
            {
                if (File.Exists(this.m_FileName))
                {
                    System.Diagnostics.FileVersionInfo fVerInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(m_FileName);

                    m_CreationTime = File.GetCreationTime(m_FileName);
                    m_LastWriteTime = File.GetLastWriteTime(m_FileName);

                    if (fVerInfo != null)
                    {
                        m_Version = fVerInfo.FileVersion;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        public void Load()
        {
            if (m_IsLoaded == false)
            {
                m_MethodList = m_Loader.Load(m_FileName);
                m_IsLoaded = true;
            }
        }

        public void Unload()
        {
            if (m_IsLoaded == true && m_IsUnloadable == true)
            {
                m_MethodList.Clear();
                m_IsLoaded = false;
            }
        }

        #region IComponent
        public ComponentType ThisComponentType
        {
            get { throw new NotImplementedException(); }
        }
        #endregion
    }
}

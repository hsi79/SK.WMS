using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace NEXCORE.Components.ComponentManager
{
	public class ComponentManagerImpl : IComponentManager
	{
//        private ComponentManager ComponentMgr;

//        public ComponentManagerImpl(ComponentManager cm)
//        {
//            ComponentMgr=cm;
//        }

//        public void TerminateComponent(string Name)
//        {
//            ComponentMgr.TerminateComponent(Name);
//        }

//        public void TerminateComponent()
//        {
//            ComponentMgr.TerminateComponent();
//        }

//        public void InitializeComponent(string Name)
//        {
//            ComponentMgr.InitializeComponent(Name);
//        }

//        public void InitializeComponent(string Name, ICore iface)
//        {
//            ComponentMgr.InitializeComponent(Name, iface);
//        }

//        public void SetupComponent(string Name, string ConfigFile)
//        {
//            ComponentMgr.SetupComponent(Name, ConfigFile);
//        }

//        public void SetupComponent(string Name, string ProxyName, string ConfigFile)
//        {
//            ComponentMgr.SetupComponent(Name, ProxyName, ConfigFile);
//        }
		
//        public void AddComponent(string FileName)
//        {
//            ComponentMgr.AddComponent(FileName);
//        }

//        public void AddComponent(string FileName, ComponentType e)
//        {
//            ComponentMgr.AddComponent(FileName, e);
//        }

//        public void RemoveComponent(string FileName)
//        {
//            ComponentMgr.RemoveComponent(FileName);
//        }

//        public void LoadComponent(string FileName)
//        {
//            ComponentMgr.LoadComponent(FileName);
//        }

//        public void UnloadComponent(string FileName)
//        {
//            ComponentMgr.UnloadComponent(FileName);
//        }

//        public object Invoke(string MethodName, ref PLCData data)
//        {
//            return ComponentMgr.Invoke(MethodName, ref data);
//        }

//        public object Invoke(string MethodName, ref SECSData data)
//        {
//            return ComponentMgr.Invoke(MethodName, ref data);
//        }

//        public object Invoke(string MethodName, ParameterArgs parms)
//        {
//            return ComponentMgr.Invoke(MethodName, parms);
//        }

//        public object Invoke(string ComponentName, string MethodName, ref PLCData data)
//        {
//            return ComponentMgr.Invoke(ComponentName, MethodName, ref data);
//        }

//        public object Invoke(string ComponentName, string MethodName, ref SECSData data)
//        {
//            return ComponentMgr.Invoke(ComponentName, MethodName, ref data);
//        }

//        public object Invoke(string ComponentName, string MethodName, ParameterArgs parms)
//        {
//            return ComponentMgr.Invoke(ComponentName, MethodName, parms);
//        }
		
//        public IAsyncResult BeginInvoke(string fnc, ParameterArgs parms, AsyncCallback callback, object asyncState)
//        {
//            return ComponentMgr.BeginInvoke(fnc, parms, callback, asyncState);
//        }

//        public IAsyncResult BeginInvoke(string fnc, ParameterArgs parms, object fnInfo, AsyncCallback callback, object asyncState)
//        {
//            return ComponentMgr.BeginInvoke(fnc, parms, fnInfo, callback, asyncState);
//        }


//        public ICore GetInterface(string Name)
//        {
//            return ComponentMgr.GetInterface(Name);
//        }

//        public IComponentList GetComponentList()
//        {
//            return ComponentMgr.GetComponentList();
//        }

//        public SortedList RemoteServerList
//        {
//            get
//            {
//                return ComponentMgr.RemoteServerList;
//            }
//        }

//        public SortedList ItemConfigList
//        {
//            get
//            {
//                return ComponentMgr.ItemConfigList;
//            }
//        }

////		public IMethodList GetMethodList()
////		{
////			return ComponentMgr.GetMethodList();
////		}	
        #region IComponentManager ¸â¹ö

        public void TerminateComponent(string Name)
        {
            throw new NotImplementedException();
        }

        public void TerminateComponent()
        {
            throw new NotImplementedException();
        }

        public void InitializeComponent(string Name)
        {
            throw new NotImplementedException();
        }

        public void SetupComponent(string Name, string ConfigFile)
        {
            throw new NotImplementedException();
        }

        public void SetupComponent(string Name, string ProxyName, string ConfigFile)
        {
            throw new NotImplementedException();
        }

        public void AddComponent(string FileName)
        {
            throw new NotImplementedException();
        }

        public void AddComponent(string FileName, ComponentType e)
        {
            throw new NotImplementedException();
        }

        public void RemoveComponent(string FileName)
        {
            throw new NotImplementedException();
        }

        public void LoadComponent(string FileName)
        {
            throw new NotImplementedException();
        }

        public void UnloadComponent(string FileName)
        {
            throw new NotImplementedException();
        }

        public NEXCORE.Common.Data.NEXCOREData Invoke(string function, ref System.Collections.Generic.Dictionary<string, object> data)
        {
            throw new NotImplementedException();
        }

        public object Invoke(string function, object data)
        {
            throw new NotImplementedException();
        }

        public NEXCORE.Common.Data.NEXCOREData Invoke(string component, string function, ref System.Collections.Generic.Dictionary<string, object> data)
        {
            throw new NotImplementedException();
        }

        public object Invoke(string component, string function, object data)
        {
            throw new NotImplementedException();
        }

        public IComponentList GetComponentList()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
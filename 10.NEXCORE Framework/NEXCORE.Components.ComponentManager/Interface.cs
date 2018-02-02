using System;
using System.Collections;
using System.Collections.Generic;
using NEXCORE.Common.Data;

namespace NEXCORE.Components.ComponentManager
{
    public enum ComponentType
    {
        BusinessComponent = 1,
        DataComponent,
        CommonComponent,
        UserComponent
    }

	public interface IComponent
	{
		// Public Attributes
		string Name {get;}
		string FileName {get;}

		// Public Methods
		void Load();
		void Unload();

		DateTime CreationTime{ get; }
		DateTime LastWriteTime{ get; }
		string Version{ get; }
		ComponentType ThisComponentType { get; }
		string ConfigFile { get; }
		void ReadAssebmlyInfo();

	}

	public interface IComponentList : IEnumerator
	{
	}

	public interface IComponentManager
	{
		void TerminateComponent(string Name);
		void TerminateComponent();

		void InitializeComponent(string Name);				        // used only by bootstrap loader
		//void InitializeComponent(string Name, ICore iface);	
		void SetupComponent(string Name, string ConfigFile);		// used only by bootstrap loader
		void SetupComponent(string Name, string ProxyName, string ConfigFile);		// used only by bootstrap loader
		
		void AddComponent(string FileName);
		void AddComponent(string FileName, ComponentType e);
		void RemoveComponent(string FileName);

		void LoadComponent(string FileName);
		void UnloadComponent(string FileName);

        NEXCOREData Invoke(string function, ref Dictionary<string, object> data);
		object Invoke(string function, object data);
		NEXCOREData Invoke(string component, string function, ref Dictionary<string,object> data);
		object Invoke(string component, string function, object data);
		
		//IAsyncResult BeginInvoke(string function, ParameterArgs parms, AsyncCallback callback, object asyncState);
		//IAsyncResult BeginInvoke(string function, ParameterArgs parms, object fnInfo, AsyncCallback callback, object asyncState);

		IComponentList GetComponentList();
		
	}

}

using System;
using System.Reflection;
using System.Runtime.Remoting;
using System.Diagnostics;
using NEXCORE.Common.Data;
using System.Collections.Generic;
using System.Data;

namespace NEXCORE.Components.ComponentManager
{
    /// <summary>
    /// Method Class
    /// </summary>
    public class Method: MarshalByRefObject		
	{
        //TODO: 메소드 파라미터를 지정하여, Delegate Type을 설정 해야 한다
        public delegate NEXCOREData FuncSytleBizDac(NEXCOREData data);
		public delegate object FuncStyleCommon(object data);

		private string   m_Name="";
		private string   m_Description="";
		private string   m_Location="";
		private Type     m_ReturnType;
        private string m_TypeString;
        private Type m_Type;

		private Delegate m_FuncToCall = null;

        public Method(string name, FuncSytleBizDac functionToCall, Type type)
        {
            m_Name = name;
            m_FuncToCall = functionToCall;
            m_Type = type;
            m_TypeString = type.FullName;
        }

        public Method(string name, FuncStyleCommon functionToCall, Type type)
		{
			m_Name = name;
			m_FuncToCall = functionToCall;
            m_Type = type;
            m_TypeString = type.FullName;
		}
		
		public Method(MethodInfo mi)
		{
			m_Name = mi.Name;
			m_Location = mi.GetType().Assembly.Location ;
            m_Type = mi.ReflectedType;
            m_TypeString = mi.ReflectedType.FullName;

			SetMethodStyle(mi);
		}

		public Method(MethodInfo mi, string codeBase)
		{
			m_Name = mi.Name;
			m_Location = codeBase;
            m_Type = mi.ReflectedType;
            m_TypeString = mi.ReflectedType.FullName;

			SetMethodStyle(mi);
		}

		private void SetMethodStyle(MethodInfo mi)
		{
            try
            {
                Type typeToCreate = null;
                m_ReturnType = mi.ReturnType;
                ParameterInfo[] parms = mi.GetParameters();

                if ((parms[0].ParameterType.FullName == "NEXCORE.Common.Data.NEXCOREData") && m_ReturnType.FullName == "NEXCORE.Common.Data.NEXCOREData")
                {
                    typeToCreate = typeof(FuncSytleBizDac);
                    m_Description = mi.GetType() + "." + mi.Name + "(Business Type Data)";
                }

                if (typeToCreate != null)
                    m_FuncToCall = Delegate.CreateDelegate(typeToCreate, mi);

                //Skcc.Diagnostics.LogWrapper.Write("Loaded : " + mi.Name, "Framework");
            }
            catch (Exception ex)
            {
                Skcc.Diagnostics.LogWrapper.Write("Delegate Exception : " + ex.ToString(), "Framework");
                Debug.WriteLine(ex.ToString());
            }
		}

		#region Properties Get/Set Code

        public string TypeString
        {
            get { return m_TypeString; }
        }

        public Type ThisType
        {
            get { return m_Type; }
        }

		public string Name
		{
			get {return m_Name;	}
		}

		public string Description
		{
			get {return m_Description; }
		}

		public string Location
		{
			get {return m_Location; }
		}
		
		public Type ReturnType
		{
			get {return m_ReturnType; }
		}

        public NEXCOREData Invoke(NEXCOREData data)
        {
            return Run(data);
        }

        public object Invoke(Object parms)
        {
            object tmp=null;
            return Run(parms, ref tmp);
        }

		#endregion 

        private NEXCOREData Run(NEXCOREData data)
        {
            return ((FuncSytleBizDac)m_FuncToCall)(data);
        }

		private object Run(Object obj, ref object fnInfo)
		{
            return ((FuncStyleCommon)m_FuncToCall)(obj);
		}
	}

    public delegate object RunAsync(NEXCOREData data);
}

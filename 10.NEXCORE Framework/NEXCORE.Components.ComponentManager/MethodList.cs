using System;
using System.Collections;
using System.Reflection;
using System.Diagnostics;
using NEXCORE.Common.Data;
using System.Collections.Generic;

namespace NEXCORE.Components.ComponentManager
{
	/// <summary>
	/// MethodList Class
	/// </summary>
	public class MethodList: MarshalByRefObject		//, IMethodList
	{
		int        m_Position = -1;
		SortedList m_MethodList;

		public MethodList()
		{
			m_MethodList = new SortedList(1);
		}

		public Method this[string key]
		{
			get { return (Method)m_MethodList[key]; }
			set
			{
				m_MethodList[key] = value;
			}		
		}

		public Method this[int index]
		{
			get { return (Method)m_MethodList.GetByIndex(index); }
			set { m_MethodList.SetByIndex(index, value); }		
		}

		public int Count
		{
			get { return m_MethodList.Count; }
		}

		public void Add(Method function)
		{
			m_MethodList.Add(function.Name, function);
		}

		public void Add(string key, Method function)
		{
			m_MethodList.Add(key, function);
		}

        public bool Contain(string key)
        {
            return m_MethodList.ContainsKey(key);
        }

		public void Clear()
		{
			m_MethodList.Clear();
		}

		/// <summary>
		/// Merge a function list into the current one
		/// </summary>
		/// <param name="functionList"></param>
		public void Merge(MethodList functionList)
		{
			for (int i = 0 ; i < functionList.Count ; i++)
			{
				try
				{
					Method func = functionList[i] as Method;
					m_MethodList.Add(func.Name, func);
				}
				catch( Exception ex )
				{
					Debug.WriteLine(ex.Message + this.GetType());
				}
			}
		}

		public void Separate(MethodList functionList)
		{
			for (int i = 0 ; i < functionList.Count ; i++)
			{
				Method func = functionList[i] as Method;
				m_MethodList.Remove(func.Name);
			}		
		}

		// walk through all the m_MethodList in a type,
		// and add them to the list...
		public void AddFromType(Type type)
		{
			AddFromType(type, type.Assembly.Location);
		}

		public void AddFromType(Type type, string location)
		{
			try
			{
                if (!type.BaseType.FullName.Equals("NEXCORE.Common.SKBizBase") && !type.BaseType.FullName.Equals("NEXCORE.Common.SKInterfaceBase"))
                    return;

                MethodInfo[] methods = type.GetMethods();

				foreach (MethodInfo mi in methods)
				{
					if ( mi.ReturnType.FullName != "NEXCORE.Common.Data.NEXCOREData")
						continue;

                    try
                    {
                        ParameterInfo[] parms = mi.GetParameters();
                        if (parms[0].ParameterType.FullName == "NEXCORE.Common.Data.NEXCOREData")
                        {
                            m_MethodList.Add(mi.DeclaringType.FullName + "_" + mi.Name, new Method(mi, location));
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.Write(ex.Message + ex.StackTrace);
                        continue;
                    }
				}
			}
			catch( Exception e)
			{
				Debug.WriteLine(e.Message);
			}
		}

		// IEnumerator
		public bool MoveNext()
		{
			m_Position++;

			if (m_Position < m_MethodList.Count)
			{
				return true;
			}
			else
			{
				m_Position = -1;
				return false;
			}
		}

		public void Reset()
		{
			m_Position = 0;
		}

		public object Current
		{
			get {return m_MethodList.GetByIndex(m_Position);}
		}
	}
}

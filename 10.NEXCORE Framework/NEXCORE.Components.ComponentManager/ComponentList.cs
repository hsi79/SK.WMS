using System;
using System.Collections;
using System.Collections.Generic;

namespace NEXCORE.Components.ComponentManager
{
	public class ComponentList: MarshalByRefObject, IComponentList
	{
        int m_Position = -1;
        Dictionary<string, Component> m_ComponentList;

        public ComponentList()
        {
            m_ComponentList = new Dictionary<string, Component>();
        }

        internal Dictionary<string, Component> Components
        {
            get
            {
                return m_ComponentList;
            }
        }

        public void Add(Component component)
        {
            Add(component.Name, component);
        }

        public void Add(string key, Component component)
        {
            m_ComponentList.Add(key, component);
        }


        public void Clear()
        {
            m_ComponentList.Clear();
        }

        // IEnumerator
        public bool MoveNext()
        {
            m_Position++;

            if (m_Position < m_ComponentList.Count)
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
            get { throw new NotImplementedException(); }
        }

    }
}

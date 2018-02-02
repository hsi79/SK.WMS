using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Collections;
using System.Runtime.Serialization;

namespace NEXCORE.Common.Data
{
   [KnownType(typeof(Code))]
   [DataContract]
   public  class Code
    {
        #region Member variables & Properties

        private string pkid;
        [DataMember]
        public string pkId { get { return pkid; } set { pkid = value; } }

       private string id;
       [DataMember]
       public string Id { get { return id; } set { id = value; } }

       private string name;

       [DataMember]
       public string Name { get { return name; } set { name = value; } }

       private string _value;
       [DataMember]
       public string CategoryValue { get { return _value; } set { _value = value; } }

       private string description;
       [DataMember]
       public string Description { get { return description; } set { description = value; } }

       private string parentId;
       [DataMember]
       public string ParentId { get { return parentId; } set { parentId = value; } }

      
        private string status; // 상태

        [DataMember]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private Code parent; // 상위 코드

        [DataMember]
        public Code Parent
        {
            get { return parent; }
            set
            {
                parent = value;
                //if (parent != null)
                //{
                //    ((Code)parent).AddChild(this);
                //}
            }
        }

        private List<Code> children;

        [DataMember]
        public List<Code> Children
        {
            get { return children; }
            set { children = value; }
        }

        #endregion

       // #region indexer
       //[DataMember]
       // public object this[object key]
       // {
       //     get
       //     {
       //         return Proeprties[key];
       //     }
       //     set
       //     {
       //         Proeprties[key] = value;
       //     }

       // }
       // #endregion

       // #region Util Methods


       // public object GetProperty(string name)
       // {
       //     return Proeprties[name];
       // }
   
       // public void SetProperty(string name, object value)
       // {
       //     Proeprties[name] = value;
       // }

        //public void SetParent(Code parent)
        //{
        //    this.parent = parent;
        //    if (parent != null)
        //    {
        //        ((Code)parent).AddChild(this);
        //    }
        //}

        //public void AddChild(Code code)
        //{
        //    if (this.children == null)
        //    {
        //        children = new List<Code>();
        //    }
        //    children.Add(code);
        //}
       // #endregion


       // #region ICode Members

        //public string GetValue()
        //{
        //    string key = "CODE_VALUE";

        //    if (Proeprties.ContainsKey(key))
        //    {
        //        return (string)GetProperty(key);
        //    }

        //    return string.Empty;
        //}

 
       // public string GetId()
       // {
       //     return Id;
       // }
   
       // public string GetName()
       // {
       //     return this.Name;
       // }
   
       // public string GetName(string locale)
       // {
       //     if (locale != null)
       //     {
       //         string key = "NAME_" + locale.ToUpper();
       //         if (Proeprties.ContainsKey(key))
       //         {
       //             return (string)GetProperty(key);
       //         }
       //     }

       //     return GetName();
       // }

       // public string GetDescription()
       // {
       //     return this.Description;
       // }

       // public string GetStatus()
       // {
       //     return status;
       // }55

       //// public Code GetParent()
       // {
       //     return parent;
       // }

        //public bool HasChildren()
        //{
        //    if (children == null)
        //        return false;
        //    else
        //        return true;
        //}

        //public List<Code> GetChildren()
        //{
        //    return this.Children;
        //}

       // public bool IsActive()
       // {
       //     return status.Equals("Y");
       // }

       // #endregion
    }
}

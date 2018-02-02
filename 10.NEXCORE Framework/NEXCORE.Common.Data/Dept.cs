using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using System.Runtime.Serialization;

namespace NEXCORE.Common.Data
{
    [KnownType(typeof(Menu))]
    [KnownType(typeof(DBNull))]
    [Serializable]
    [DataContract]
    public class Dept 
    {
        private string _chk;
        private string _deptId;
        private string _parentDeptId;
        private string _parentDeptName;
        private string _deptName;
        private string _use;
        private int _sort;
        /// <summary>
        /// 
        /// </summary>
        private List<Dept> _childDeptList;
        private int _depth;

        #region IDept 멤버
        [DataMember]
        public int Depth
        {
            get { return _depth; }
            set { _depth = value; }
        }
        [DataMember]
        public string DeptId
        {
            get { return _deptId; }
            set { _deptId = value; }
        }        
        [DataMember]
        public List<Dept> ChildDeptList
        {
            get { return _childDeptList; }
            set { _childDeptList = value; }
        }
        [DataMember]
        public string Use
        {
            get { return _use; }
            set { _use = value; }
        }
         [DataMember]
        public int SORT
        {
            get { return _sort; }
            set { _sort = value; }
        }
        [DataMember]
        public string ParentDeptId
        {
            get { return _parentDeptId; }
            set { _parentDeptId = value; }
        }
        [DataMember]
        public string ParentDeptName
        {
            get { return _parentDeptName; }
            set { _parentDeptName = value; }
        }
        [DataMember]
        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }
        [DataMember]
        public string Chk
        {
            get { return _chk; }
            set { _chk = value; }
        }
        #endregion
    }
}

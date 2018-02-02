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
    public class Menu 
    {
        private string _chk;
        private string _sysId;
        private string _menuId;
        private string _pgmId;
        private string _parentMenuId;
        private string _parentMenuName;
        private string _menuKorea;
        private string _menuEnglish;
        private string _menuChina;
        private string _openType;
        private string _use;
        private bool _visible;
        private string _menuDescription;
        private int _sort;
        private int _searchorder;
        private string _topmenu;
        private string _searchmenu;
        private string _topmenuname;
        private string _searchmenuname;
        /// <summary>
        /// 
        /// </summary>
        private Image _icon;
        private string _authId;
        private string _menuType;
        private string _geometry;
        private List<Menu> _childMenuList;
        private int _columnCount;
        private string _userId;
        private int _depth;

        #region IMenu 멤버
        [DataMember]
        public int Depth
        {
            get { return _depth; }
            set { _depth = value; }
        }
        
        [DataMember]
        public string IconGeometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        [DataMember]
        public List<Menu> ChildMenuList
        {
            get { return _childMenuList; }
            set { _childMenuList = value; }
        }
        [DataMember]
        public string OpenType
        {
            get { return _openType; }
            set { _openType = value; }
        }
        [DataMember]
        public string Use
        {
            get { return _use; }
            set { _use = value; }
        }
        [DataMember]
        public bool Visible
        {
            get { return _visible; }
            set { _visible = value; }
        }
        [DataMember]
        public string MenuDescription
        {
            get { return _menuDescription; }
            set { _menuDescription = value; }
        }
        [DataMember]
        public int SORT
        {
            get { return _sort; }
            set { _sort = value; }
        }
        [DataMember]
        public int SearchOrder
        {
            get { return _searchorder; }
            set { _searchorder = value; }
        }
        [DataMember]
        public System.Drawing.Image ICON
        {
            get { return _icon; }
            set { _icon = value; }
        }
        [DataMember]
        public string SysId
        {
            get { return _sysId; }
            set { _sysId = value; }
        }
        [DataMember]
        public string MenuId
        {
            get { return _menuId; }
            set { _menuId = value; }
        }
        [DataMember]
        public string PgmId
        {
            get { return _pgmId; }
            set { _pgmId = value; }
        }
        [DataMember]
        public string ParentMenuId
        {
            get { return _parentMenuId; }
            set { _parentMenuId = value; }
        }
        [DataMember]
        public string ParentMenuName
        {
            get { return _parentMenuName; }
            set { _parentMenuName = value; }
        }
        [DataMember]
        public string MenuKorea
        {
            get { return _menuKorea; }
            set { _menuKorea = value; }
        }
        [DataMember]
        public string MenuEnglish
        {
            get { return _menuEnglish; }
            set { _menuEnglish = value; }
        }
        [DataMember]
        public string MenuChina
        {
            get { return _menuChina; }
            set { _menuChina = value; }
        }
        [DataMember]
        public string AuthId
        {
            get { return _authId; }
            set { _authId = value; }
        }
        [DataMember]
        public string MenuType
        {
            get { return _menuType; }
            set { _menuType = value; }
        }
        [DataMember]
        public int ColumnCount
        {
            get { return _columnCount; }
            set { _columnCount = value; }
        }
        [DataMember]
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        [DataMember]
        public string TopMenu
        {
            get { return _topmenu; }
            set { _topmenu = value; }
        }
        [DataMember]
        public string TopMenuName
        {
            get { return _topmenuname; }
            set { _topmenuname = value; }
        }
        [DataMember]
        public string SearchMenu
        {
            get { return _searchmenu; }
            set { _searchmenu = value; }
        }
        [DataMember]
        public string SearchMenuName
        {
            get { return _searchmenuname; }
            set { _searchmenuname = value; }
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

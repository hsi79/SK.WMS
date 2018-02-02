using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using Skcc.Data;
using System.Data;
using System.Drawing;
using NEXCORE.Common.Data;
using System.Collections;
using System.Data.Common;


namespace NEXCORE.Components.MenuManager
{
    public class MenuRepository 
    {
        private DataAccessWrapper _daw ;

        private const string SPLoadAuth = "PK_NEXCORE.SP_MENU_SELECTAUTH";
        private const string SPLoadAll = "PK_NEXCORE.SP_MENU_SELECTALL";
        private const string SPLoadAllDept = "PK_NEXCORE.SP_DEPT_SELECTALL";
        private const string SPMyMenuList = "PK_NEXCORE.SP_MYMENU_SELECT";
        private const string SPAddMyMenu = "PK_NEXCORE.SP_MYMENU_INSERT";
        private const string SPDeleteMyMenu = "PK_NEXCORE.SP_MYMENU_DELETE";
        private const string SPUpdateMyMenu = "PK_NEXCORE.SP_MYMENU_UPDATE";
        private const string SPAddMenu = "PK_NEXCORE.SP_MENU_INSERT";
        private const string SPDeleteMenu = "PK_NEXCORE.SP_MENU_DELETE";
        private const string SPUpdateMenu = "PK_NEXCORE.SP_MENU_UPDATE";
        private const string SPCommonLoadMenu = "PK_NEXCORE.SP_COMMON_MENU_SELECT";
        private Dictionary<string, Menu> _dicMenuList;
        private Dictionary<string, Dept> _dicDeptList;
        DataSet allMenuDs = null;
        DataSet allDeptDs = null;
        public void LoadWMSMenu()
        {
            try
            {
                _dicMenuList = new Dictionary<string, Menu>();

                MenuRepository menuRepo = new MenuRepository();
                DataSet ds = null;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Menu menu = new Menu();

                    menu.MenuId = row["MENU_ID"].ToString();
                    //menu.PgmId = row["PGM_ID"].ToString();
                    menu.ParentMenuId = row["PARENT_MENU_ID"].ToString();
                    menu.ParentMenuName = row["PARENT_MENU_NAME"].ToString();
                    menu.MenuKorea = row["MENU_NM_KO"].ToString();
                    menu.MenuEnglish = row["MENU_NM_EN"].ToString();
                    menu.PgmId = row["PGM_ID"].ToString();
                    menu.Use = row["USE_YN"].ToString();
                    menu.SearchMenu = row["SEARCH_YN"].ToString();
                    menu.SearchMenuName = row["SEARCH_NAME"].ToString();
                    //menu.OpenType = row["OPEN_TYPE"].ToString();
                    //menu.Use = row["USE_YN"].ToString().ToUpper().Equals("Y") ? true : false;
                    //menu.Visible = row["VISIBLE_YN"].ToString().ToUpper().Equals("Y") ? true : false;
                    //menu.MenuDescription = row["MENU_DESC"].ToString();
                    //menu.AuthId = row["AUTH_ID"].ToString();
                    menu.SORT =  int.Parse(row["MENU_ORDER"].ToString());
                    menu.MenuType = row["MENU_TYPE"].ToString();


                    if (menu.ParentMenuId == "ROOT")
                        menu.Depth = 1;

                    if (menu.Use == "Y" && menu.Visible)
                        _dicMenuList.Add(menu.MenuId, menu);
                }

                //Child Menu설정
                foreach (Menu menu in _dicMenuList.Values)
                {
                    var childMenuList = from m in _dicMenuList.Values
                                        orderby m.SORT ascending
                                        where m.ParentMenuId == menu.MenuId
                                        select m;

                    menu.ChildMenuList = childMenuList.ToList<Menu>();
                }

                var rootMenuList = from m in _dicMenuList.Values
                                   orderby m.SORT ascending
                                   where m.ParentMenuId == "ROOT"
                                   select m;

                foreach (var menu in rootMenuList)
                {
                    SetDepth(menu);
                }
            }
            catch { }
        }

        public void LoadWMSDept()
        {
            try
            {
                _dicDeptList = new Dictionary<string, Dept>();

                MenuRepository menuRepo = new MenuRepository();
                _daw = new DataAccessWrapper();

                DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAllDept);

                DataSet ds = _daw.ExecuteDataSet(selectCmd);

                allDeptDs = ds;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Dept dept = new Dept();

                    dept.DeptId = row["DEPT_ID"].ToString();
                    dept.ParentDeptId = row["PARENT_DEPT_ID"].ToString();
                    dept.ParentDeptName = row["PARENT_DEPT_NAME"].ToString();
                    dept.DeptName = row["DEPT_NM"].ToString();
                    dept.Use = row["USE_YN"].ToString();

                    dept.SORT = int.Parse(row["DEPT_ORDER"].ToString());


                    if (dept.ParentDeptId == "ROOT")
                        dept.Depth = 1;

                    if (dept.Use == "Y" )
                        _dicDeptList.Add(dept.DeptId, dept);
                }

                //Child Menu설정
                foreach (Dept dept in _dicDeptList.Values)
                {
                    var childDeptList = from m in _dicDeptList.Values
                                        orderby m.SORT ascending
                                        where m.ParentDeptId == dept.DeptId
                                        select m;

                    dept.ChildDeptList = childDeptList.ToList<Dept>();
                }

                var rootDeptList = from m in _dicDeptList.Values
                                   orderby m.SORT ascending
                                   where m.ParentDeptId == "ROOT"
                                   select m;

                foreach (var dept in rootDeptList)
                {
                    SetDepth(dept);
                }
            }
            catch { }
        }
        private void AddParentMenuUntilMeetRoot(Menu currMenu)
        {
            string query = string.Format("MENU_ID = '{0}'", currMenu.ParentMenuId);
            DataRow[] drChildMenu = allMenuDs.Tables[0].Select(query, "MENU_ID");

            foreach (DataRow row in drChildMenu)
            {
                Menu menu = new Menu();
                #region Menu Data
                menu.MenuId = row["MENU_ID"].ToString();
                //menu.PgmId = row["PGM_ID"].ToString();
                menu.ParentMenuId = row["PARENT_MENU_ID"].ToString();
                menu.ParentMenuName = row["PARENT_MENU_NAME"].ToString();
                menu.MenuKorea = row["MENU_NM_KO"].ToString();
                menu.MenuEnglish = row["MENU_NM_EN"].ToString();
                menu.Use = row["USE_YN"].ToString();
                menu.SearchMenu = row["SEARCH_YN"].ToString();
                menu.SearchMenuName = row["SEARCH_NAME"].ToString();
                //menu.OpenType = row["OPEN_TYPE"].ToString();
                //menu.Use = row["USE_YN"].ToString().ToUpper().Equals("Y") ? true : false;
                //menu.Visible = row["VISIBLE_YN"].ToString().ToUpper().Equals("Y") ? true : false;
                //menu.MenuDescription = row["MENU_DESC"].ToString();
                //menu.AuthId = row["AUTH_ID"].ToString();
                //menu.SORT = row["SORT"].ToString();
                //menu.MenuType = row["MENU_TYPE"].ToString();
                #endregion

                if (!_dicMenuList.ContainsKey(menu.MenuId))
                    _dicMenuList.Add(menu.MenuId, menu);

                if (menu.MenuId.ToUpper().Equals("ROOT"))
                    break;
                
                AddParentMenuUntilMeetRoot(menu);
            }
        }

        #region IMenuRepository 멤버
        public void LoadMenu(string userId, string sysid)
        {
            // All Menus
            

            _daw = new DataAccessWrapper();
            _dicMenuList = new Dictionary<string, Menu>();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAuth);
            _daw.AddInParameter(selectCmd, "p_USER_ID", DbType.String, userId);
            DataSet ds = _daw.ExecuteDataSet(selectCmd);

            allMenuDs = ds;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Menu menu = new Menu();
                #region Menu Data

                menu.MenuId = row["MENU_ID"].ToString();
                //menu.PgmId = row["PGM_ID"].ToString();
                menu.ParentMenuId = row["PARENT_MENU_ID"].ToString();
                menu.ParentMenuName = row["PARENT_MENU_NAME"].ToString();
                menu.MenuKorea = row["MENU_NM_KO"].ToString();
                menu.MenuEnglish = row["MENU_NM_EN"].ToString();
                menu.PgmId = row["PGM_ID"].ToString();
                menu.Use = row["USE_YN"].ToString();
                //menu.SearchMenu = row["SEARCH_YN"].ToString();
                //menu.SearchMenuName = row["SEARCH_NAME"].ToString();
                //menu.IconGeometry = row["SEARCH_COLOR"].ToString();
                //menu.OpenType = row["OPEN_TYPE"].ToString();
                //menu.Use = row["USE_YN"].ToString().ToUpper().Equals("Y") ? true : false;
                //menu.Visible = row["VISIBLE_YN"].ToString().ToUpper().Equals("Y") ? true : false;
                //menu.MenuDescription = row["MENU_DESC"].ToString();
                //menu.AuthId = row["AUTH_ID"].ToString();
                menu.SORT = int.Parse(row["MENU_ORDER"].ToString());
                //menu.SearchOrder = int.Parse(row["SEARCH_ORDER"].ToString());
                menu.MenuType = row["MENU_TYPE"].ToString();
                #endregion

                if (menu.ParentMenuId == "ROOT")
                    menu.Depth =1;

                if (_dicMenuList.ContainsKey(menu.MenuId))
                    _dicMenuList[menu.MenuId] = menu;
                else
                _dicMenuList.Add(menu.MenuId, menu);

                //AddParentMenuUntilMeetRoot(menu);
            }

            //Child Menu설정
            foreach (Menu menu in _dicMenuList.Values)
            {
                var childMenuList = from m in _dicMenuList.Values
                                    orderby m.SORT ascending
                                    where m.ParentMenuId == menu.MenuId
                                    select m;

                menu.ChildMenuList = childMenuList.ToList<Menu>();
            }

            var rootMenuList = from m in _dicMenuList.Values
                                orderby m.SORT ascending
                                where m.ParentMenuId == "ROOT"
                                select m;

            foreach (var menu in rootMenuList)
            {
                SetDepth(menu);
            }
        }
        public void LoadMenu(string sysid)
        {
            // All Menus


            _daw = new DataAccessWrapper();
            _dicMenuList = new Dictionary<string, Menu>();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAll);
            DataSet ds = _daw.ExecuteDataSet(selectCmd);

            allMenuDs = ds;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Menu menu = new Menu();
                #region Menu Data

                menu.MenuId = row["MENU_ID"].ToString();
                //menu.PgmId = row["PGM_ID"].ToString();
                menu.ParentMenuId = row["PARENT_MENU_ID"].ToString();
                menu.ParentMenuName = row["PARENT_MENU_NAME"].ToString();
                menu.MenuKorea = row["MENU_NM_KO"].ToString();
                menu.MenuEnglish = row["MENU_NM_EN"].ToString();
                menu.PgmId = row["PGM_ID"].ToString();
                menu.Use = row["USE_YN"].ToString();
                //menu.SearchMenu = row["SEARCH_YN"].ToString();
                //menu.SearchMenuName = row["SEARCH_NAME"].ToString();
                //menu.OpenType = row["OPEN_TYPE"].ToString();
                //menu.Use = row["USE_YN"].ToString().ToUpper().Equals("Y") ? true : false;
                //menu.Visible = row["VISIBLE_YN"].ToString().ToUpper().Equals("Y") ? true : false;
                //menu.MenuDescription = row["MENU_DESC"].ToString();
                //menu.AuthId = row["AUTH_ID"].ToString();
                //menu.IconGeometry = row["SEARCH_COLOR"].ToString();
                menu.SORT = int.Parse(row["MENU_ORDER"].ToString());
                //menu.SearchOrder = int.Parse(row["SEARCH_ORDER"].ToString());
                menu.MenuType = row["MENU_TYPE"].ToString();
                #endregion

                if (menu.ParentMenuId == "ROOT")
                    menu.Depth = 1;

                _dicMenuList.Add(menu.MenuId, menu);
                //AddParentMenuUntilMeetRoot(menu);
            }

            //Child Menu설정
            foreach (Menu menu in _dicMenuList.Values)
            {
                var childMenuList = from m in _dicMenuList.Values
                                    orderby m.SORT ascending
                                    where m.ParentMenuId == menu.MenuId
                                    select m;

                menu.ChildMenuList = childMenuList.ToList<Menu>();
            }

            var rootMenuList = from m in _dicMenuList.Values
                               orderby m.SORT ascending
                               where m.ParentMenuId == "ROOT"
                               select m;

            foreach (var menu in rootMenuList)
            {
                SetDepth(menu);
            }
        }
        public void CommonLoadMenu(string userId,string sysid)
        {
            // All Menus


            _daw = new DataAccessWrapper();
            _dicMenuList = new Dictionary<string, Menu>();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPCommonLoadMenu);
            _daw.AddInParameter(selectCmd, "p_USER_ID", DbType.String, userId);
            DataSet ds = _daw.ExecuteDataSet(selectCmd);


            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Menu menu = new Menu();
                #region Menu Data

                menu.MenuId = row["MENU_ID"].ToString();
                //menu.PgmId = row["PGM_ID"].ToString();
                menu.ParentMenuId = row["PARENT_MENU_ID"].ToString();
                menu.MenuKorea = row["MENU_NM_KO"].ToString();
                menu.MenuEnglish = row["MENU_NM_EN"].ToString();
                menu.PgmId = row["PGM_ID"].ToString();
                menu.SearchMenu = row["SEARCH_YN"].ToString();
                menu.SearchMenuName = row["SEARCH_NAME"].ToString();
                //menu.OpenType = row["OPEN_TYPE"].ToString();
                menu.Use = row["USE_YN"].ToString();
                //menu.Visible = row["VISIBLE_YN"].ToString().ToUpper().Equals("Y") ? true : false;
                //menu.MenuDescription = row["MENU_DESC"].ToString();
                //menu.AuthId = row["AUTH_ID"].ToString();
                menu.IconGeometry = row["SEARCH_COLOR"].ToString();
                menu.SORT = int.Parse(row["MENU_ORDER"].ToString());
                menu.SearchOrder = int.Parse(row["SEARCH_ORDER"].ToString());
                menu.MenuType = row["MENU_TYPE"].ToString();
                #endregion

                if (menu.ParentMenuId == "ROOT")
                    menu.Depth = 1;

                _dicMenuList.Add(menu.MenuId, menu);
            }

        }
        private void SetDepth(Menu menu)
        {
            int thisType = menu.Depth;
            thisType++;          

            foreach (Menu childMenu in menu.ChildMenuList)
            {
                childMenu.Depth = thisType;
                SetDepth(childMenu);
            }
        }
        private void SetDepth(Dept dept)
        {
            int thisType = dept.Depth;
            thisType++;

            foreach (Dept childDept in dept.ChildDeptList)
            {
                childDept.Depth = thisType;
                SetDepth(childDept);
            }
        }

        public IList<Menu> GetMenus()
        {
            return _dicMenuList.Values.ToList<Menu>();
        }
        public IList<Dept> GetDepts()
        {
            return _dicDeptList.Values.ToList<Dept>();
        }

        public IList<Menu> GetMyMenuList(string userId)
        {
            List<Menu> lstMenu = new List<Menu>();

            _daw = new DataAccessWrapper();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPMyMenuList);
            _daw.AddInParameter(selectCmd, "p_USER_ID", DbType.String, userId);

            DataSet ds = _daw.ExecuteDataSet(selectCmd);

            List<Menu> lstTemp = new List<Menu>();
          
            if (ds != null && ds.Tables.Count != 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Menu m = new Menu();
                    m.Chk = "False";
                    m.MenuId = row["PGM_ID"].ToString();
                    m.PgmId = row["PGM_ID"].ToString();
                    m.MenuKorea = row["PGM_NM"].ToString();
                    m.UserId = row["USER_ID"].ToString();
                    m.SORT = int.Parse(row["PGM_ORDER"].ToString());                    

                    lstTemp.Add(m);
                }
            }


            return lstTemp;
        }
        public void AddMenu(Menu menu)
        {
            _daw = new DataAccessWrapper();

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPAddMenu);

            // sql parameter 생성
            this._daw.AddInParameter(insertCmd, "p_MENU_ID", DbType.String, menu.MenuId);
            this._daw.AddInParameter(insertCmd, "p_PGM_ID", DbType.String, menu.PgmId);
            this._daw.AddInParameter(insertCmd, "p_MENU_TYPE", DbType.String, menu.MenuType);
            this._daw.AddInParameter(insertCmd, "p_MENU_NM_KO", DbType.String, menu.MenuKorea);
            this._daw.AddInParameter(insertCmd, "p_MENU_NM_EN", DbType.String, menu.MenuEnglish);
            this._daw.AddInParameter(insertCmd, "p_PARENT_MENU_ID", DbType.String, menu.ParentMenuId);
            this._daw.AddInParameter(insertCmd, "p_MENU_LEVEL", DbType.String, menu.ParentMenuId == "ROOT" ? "1" : null);
            this._daw.AddInParameter(insertCmd, "p_MENU_ORDER", DbType.String, menu.SORT);
            this._daw.AddInParameter(insertCmd, "p_USE_YN", DbType.String, menu.Use);
            this._daw.AddInParameter(insertCmd, "p_REG_ID", DbType.String, menu.UserId);

            _daw.ExecuteNonQuery(insertCmd);
        }


        public void UpdateMenu(Menu menu)
        {
            _daw = new DataAccessWrapper();

            DbCommand updateCmd = _daw.GetStoredProcCommand(SPUpdateMenu);

            // sql parameter 생성
            this._daw.AddInParameter(updateCmd, "p_MENU_ID", DbType.String, menu.MenuId);
            this._daw.AddInParameter(updateCmd, "p_PGM_ID", DbType.String, menu.PgmId);
            this._daw.AddInParameter(updateCmd, "p_MENU_TYPE", DbType.String, menu.MenuType);
            this._daw.AddInParameter(updateCmd, "p_MENU_NM_KO", DbType.String, menu.MenuKorea);
            this._daw.AddInParameter(updateCmd, "p_MENU_NM_EN", DbType.String, menu.MenuEnglish);
            this._daw.AddInParameter(updateCmd, "p_PARENT_MENU_ID", DbType.String, menu.ParentMenuId);
            this._daw.AddInParameter(updateCmd, "p_MENU_LEVEL", DbType.String, menu.ParentMenuId == "ROOT" ? "1" : null);
            this._daw.AddInParameter(updateCmd, "p_MENU_ORDER", DbType.String, menu.SORT);
            this._daw.AddInParameter(updateCmd, "p_USE_YN", DbType.String, menu.Use);
            this._daw.AddInParameter(updateCmd, "p_MOD_ID", DbType.String, menu.UserId);

            _daw.ExecuteNonQuery(updateCmd);
        }

        public void DeleteMenu(Menu menu)
        {
            _daw = new DataAccessWrapper();

            DbCommand deleteCmd = _daw.GetStoredProcCommand(SPDeleteMenu);

            // sql parameter 생성
            this._daw.AddInParameter(deleteCmd, "p_MENU_ID", DbType.String, menu.MenuId);
            

            _daw.ExecuteNonQuery(deleteCmd);

        }
        public bool AddMyMenu(Menu menu)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPAddMyMenu);

            // sql parameter 생성
            this._daw.AddInParameter(insertCmd, "p_USER_ID", DbType.String, menu.UserId);
            this._daw.AddInParameter(insertCmd, "p_PGM_ID", DbType.String, menu.PgmId);
            this._daw.AddInParameter(insertCmd, "p_PGM_NM", DbType.String, menu.MenuKorea);
            this._daw.AddInParameter(insertCmd, "p_PGM_ORDER", DbType.String, menu.SORT);
            
            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;
            return ret;
        }

        public void ModifyMyMenu(Menu menu)
        {

        }

        public bool UpdateMyMenu(Menu menu)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();

            DbCommand updateCmd = _daw.GetStoredProcCommand(SPUpdateMyMenu);
            // sql parameter 생성
            this._daw.AddInParameter(updateCmd, "p_USER_ID", DbType.String, menu.UserId);
            this._daw.AddInParameter(updateCmd, "p_PGM_ID", DbType.String, menu.PgmId);
            this._daw.AddInParameter(updateCmd, "p_PGM_NM", DbType.String, menu.MenuKorea);
            this._daw.AddInParameter(updateCmd, "p_PGM_ORDER", DbType.String, menu.SORT);

            
            int i = _daw.ExecuteNonQuery(updateCmd);
            if (i > 0) ret = true;
            return ret;
        }

        public bool DeleteMyMenu(Menu menu)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();

            DbCommand deleteCmd = _daw.GetStoredProcCommand(SPDeleteMyMenu);

            // sql parameter 생성
            this._daw.AddInParameter(deleteCmd, "p_PGM_ID", DbType.String, menu.PgmId);
            this._daw.AddInParameter(deleteCmd, "p_USER_ID", DbType.String, menu.UserId);

           int i =  _daw.ExecuteNonQuery(deleteCmd);
            if (i > 0) ret = true;
            return ret;

        }
        #endregion
    }
}
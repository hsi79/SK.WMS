using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Interfaces;
using NEXCORE.Utility;
using NEXCORE.Common;
using NEXCORE.Utility.GlobalVariable;
using C1.Win.C1Command;
using System.Diagnostics;
using NEXCORE.Common.Data;
using System.Reflection;
using C1.Win.C1FlexGrid;

namespace SK.WMS.Launcher
{
    public partial class MainForm : C1.Win.C1Ribbon.C1RibbonForm
    {
        private DataSet menuDataSet = null;


        private static string baseDir = Skcc.Configuration.SkccFxConfigManager.TryGetString("PROGRAMS_PATH");
        public string strSys = string.Empty;
        private Microsoft.Win32.RegistryKey key;

        #region Member Property
        private IUserInterface _UIInterface;
        #endregion
        public IUserInterface FormInterface
        {
            get
            {
                return this._UIInterface;
            }
            set
            {
                this._UIInterface = value;
            }
        }
        public MainForm(IUserInterface userInterface)
        {
            try
            {
//#if DEBUG
//                baseDir = @"C:\SK.WMS\Programs";
//#endif
                
                NEXCORE.Common.UIInterface.SetUIInterface(userInterface);

                InitializeComponent();

                this.FormInterface = userInterface;




                
                
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                CommonManager.ErrorLog("Main", FormInterface.GetCurrentUser().UserId, msg);
                UtilityHelper.WriteLog(msg, UtilityHelper.eLogCategory.UI, System.Diagnostics.TraceEventType.Error);
                CommonHelper.CallMsgPopUp("알림", "화면 로드중 오류가 발생하였습니다!!!", "", "1", msg);
            }
           
        }

        #region 폰트 설정
        private void SetFont()
        {
            //TODO:권한 관련 로직을 WindowsForm에 맞도록 수정

            if (this.FormInterface == null)
            {
                return;
            }




            foreach (Control control in this.Controls)
            {
                SetFontControl(control);
            }


        }

        private void SetFontControl(Control control)
        {
            try
            {
                //#region  Code

                if (!string.IsNullOrEmpty(control.Name))
                {
                    Font ft = control.Font;
                    float s = ft.Size;
                    string font = WMSVar.FT;
                    if (!(control is UserControl))
                    {
                        if (ft.Bold)
                        {
                            control.Font = new Font(font, s, FontStyle.Bold);
                        }
                        else
                        {
                            control.Font = new Font(font, s);
                        }
                    }
                    foreach (Control ctrlChild in control.Controls)
                    {
                        SetFontControl(ctrlChild);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        #endregion
        private void ShowServerInfo()
        {
            #region 개발 환경 구분을 위한 작업
            string conInfo = string.Empty;
            string strUrl = CommonHelper.GetNEXCOREConfig("FRONT_SERVICE_URL");


                //상황에 따라서 어디 서버에 연결 되는지 화면에 적어 준다.
            switch (strUrl)
            {
                case "http://127.0.0.1:25000/FrontService.svc":
                    //로컬
                    conInfo = "-로컬서버";
                    break;
                case "http://168.154.137.167/FrontService.svc":
                    //asmigw
                    conInfo = "-개발서버";
                    break;
                case "http://168.154.150.190/FrontService.svc":
                    conInfo += "";

                    break;

            }



            this.Text += conInfo;

            #endregion

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetFont();
                InitLoad();

                

                this.Text = Skcc.Configuration.SkccFxConfigManager.TryGetString("SK_TITLE");

                ShowServerInfo();
            }
            catch (Exception ex)
            {
                string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                CommonManager.ErrorLog("Main", FormInterface.GetCurrentUser().UserId, msg);
                CommonHelper.CallMsgPopUp("알림", "화면 로드중 오류가 발생하였습니다!!!", "", "1", ex.Message);
                
            }

        }

        private void InitLoad()
        {

            // 사용자 정보

            // 사용자 정보
            string statusMsg = string.Empty;

            statusMsg = FormInterface.GetCurrentUser().UserName + "(" + FormInterface.GetCurrentUser().UserId + ")" ;


            lblUser.Text = statusMsg;


            tabMain.Controls.Clear();
            

            // 전체 메뉴
            CreateMenu();

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;


            // 즐겨찾기 메뉴
            //CreateFavorites();



        }




        /// <summary>
        /// 로그인 후 스플래쉬 윈도우 
        /// </summary>
        private void ShowLoading()
        {
            Process[] process = Process.GetProcessesByName("SK.WMS.Loading");

            try
            {
                if (process.Length < 1)
                {
                    Process.Start("SK.WMS.Loading.exe");
                }
            }
            catch
            {
                //추후 처리..
            }
        }

        /// <summary>
        /// 스플래쉬 윈도우 Close
        /// </summary>
        private void KillLoading()
        {
            Process[] process = Process.GetProcessesByName("SK.WMS.Loading");

            try
            {
                foreach (Process proc in process)
                {
                    proc.Kill();
                }
            }
            catch
            {
                //추후 처리..
            }
        }


        /// <summary>
        /// Create menu-strip dynamically
        /// </summary>
        /// <param name="parentMenuStrip"></param>
        public void CreateMenu()
        {

            //먼저 메뉴 삭제

            c1MainMenu1.CommandLinks.Clear();

            NEXCORE.Common.Data.User user = FormInterface.GetCurrentUser();
            List<NEXCORE.Common.Data.Menu> menuList = NEXCORE.Common.CommonManager.GetWMSMenuList(user.UserId, "");

            menuDataSet = NEXCORE.Utility.UtilityHelper.ToDataSet<NEXCORE.Common.Data.Menu>(menuList);

            if (menuDataSet != null)
            {
                string query = string.Concat("ParentMenuId = 'ROOT'");
                DataRow[] drTopMenu = menuDataSet.Tables[0].Select(query, "SORT");

                //초기 시스템 모듈을 메뉴에 포함
                //InitMenu();


                //메뉴 명령

                for (int rowIdx = 0; rowIdx < drTopMenu.Length; rowIdx++)
                {
                    C1CommandMenu mFile = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));
                    if (drTopMenu[rowIdx]["PgmId"] != null)
                    {
                        NEXCORE.Common.Data.Menu menu = null;
                        // Create menu data
                        menu = new NEXCORE.Common.Data.Menu();

                        menu.MenuId = drTopMenu[rowIdx]["MenuId"].ToString().Trim();
                        menu.ParentMenuId = drTopMenu[rowIdx]["ParentMenuId"].ToString().Trim();
                        menu.MenuKorea = drTopMenu[rowIdx]["MenuKorea"].ToString().Trim();

                        menu.PgmId = drTopMenu[rowIdx]["PgmId"].ToString().Trim();

                        mFile.Click += new ClickEventHandler(menuItem_Click);
                        mFile.UserData = menu;
                    }
                    mFile.Text = drTopMenu[rowIdx]["MenuKorea"].ToString();

                    // Composite new menu

                    c1MainMenu1.CommandLinks.Add(new C1CommandLink(mFile));



                    CreateMenuRecursively(mFile, drTopMenu[rowIdx]["MenuId"].ToString());



                }



            }






        }

        private void CreateFavorites()
        {
            // 즐겨찾기 메뉴 설정

            try
            {


            C1CommandMenu mFileFavorites = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));
            mFileFavorites.CommandLinks.Clear();
            mFileFavorites.Text = "즐겨찾기";
            mFileFavorites.Image = Properties.Resources.favorite;

            c1MainMenu1.CommandLinks.Add(new C1CommandLink(mFileFavorites));


            C1CommandMenu mFileF = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));
            // Create menu data
            NEXCORE.Common.Data.Menu menuF = new NEXCORE.Common.Data.Menu();

            menuF.PgmId = "ZZ005";
            menuF.MenuId = "myAdd";
            menuF.MenuKorea = "즐겨찾기에 추가";

            mFileFavorites.CommandLinks.Add(new C1CommandLink(mFileF));

            mFileF.Name = menuF.PgmId;
            mFileF.Click += new ClickEventHandler(myAdd_Click);
            mFileF.UserData = menuF;
            mFileF.Text = menuF.MenuKorea;

            NEXCORE.Common.Data.Menu menuM = new NEXCORE.Common.Data.Menu();
            menuM.PgmId = "ZZ006";
            menuM.MenuId = "myAddMgmt";
            menuM.MenuKorea = "즐겨찾기 관리..";

            C1CommandMenu mFileM = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));
            // Create menu data


            mFileFavorites.CommandLinks.Add(new C1CommandLink(mFileM));

            mFileM.Name = menuM.PgmId;
            mFileM.Click += new ClickEventHandler(myAdd_Click);
            mFileM.UserData = menuM;
            mFileM.Text = menuM.MenuKorea;

            List<NEXCORE.Common.Data.Menu> mymenu = CommonManager.GetMyMenuList(FormInterface.GetCurrentUser().UserId);


            if (mymenu.Count > 0) //라인추가
            {
                C1CommandMenu mFileLine = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));
                // Create menu data


                mFileFavorites.CommandLinks.Add(new C1CommandLink(mFileLine));

                mFileLine.Name = "line";
                mFileLine.Text = "-";

            }
            for (int i = 0; i < mymenu.Count; i++)
            {
                C1CommandMenu mFile = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));
                // Create menu data

                // Composite new menu
                mFile.Click += new ClickEventHandler(myAdd_Click);

                mFileFavorites.CommandLinks.Add(new C1CommandLink(mFile));

                mFile.Name = mymenu[i].PgmId;

                mFile.UserData = mymenu[i];
                mFile.Text = mymenu[i].MenuKorea;
                mFile.LargeMenuDisplay = LargeMenuDisplayEnum.Wrap;

            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void CreateFont()
        {


            C1CommandMenu mFileFont = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));
            mFileFont.CommandLinks.Clear();
            mFileFont.Text = WMSVar.FTNAME;
            mFileFont.Image = Properties.Resources.favorite;

            c1MainMenu1.CommandLinks.Add(new C1CommandLink(mFileFont));

            C1CommandMenu mFileM = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));

            mFileFont.CommandLinks.Add(new C1CommandLink(mFileM));

            mFileM.Name = "Malgun Gothic";
            mFileM.Click += new ClickEventHandler(SetFont);
            mFileM.Text = "맑은고딕";


            C1CommandMenu mFileD = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));

            mFileFont.CommandLinks.Add(new C1CommandLink(mFileD));

            mFileD.Name = "DotumChe";
            mFileD.Click += new ClickEventHandler(SetFont);
            mFileD.Text = "돋움체";

            //C1CommandMenu mFileS = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));

            //mFileFont.CommandLinks.Add(new C1CommandLink(mFileS));

            //mFileS.Name = "GungsuhChe";
            //mFileS.Click += new ClickEventHandler(SetFont);
            //mFileS.Text = "궁서체";

            //C1CommandMenu mFileG = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));

            //mFileFont.CommandLinks.Add(new C1CommandLink(mFileG));

            //mFileG.Name = "Gulim";
            //mFileG.Click += new ClickEventHandler(SetFont);
            //mFileG.Text = "굴림체";


        }

        private void SetFont(object sender, EventArgs e)
        {
            C1Command menu = (C1Command)sender;

            string regKeyPath = @"Software\SK.WMS\"; //레지스트리 키 경로
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(regKeyPath); //레지스트리 키 등록
            key.SetValue("FONT", menu.Name.Replace("_", " ")); //값등록 : 서버
            key.SetValue("FONTNAME", menu.Text); //값등록 : 서버
            //MTMSVar.FT = menu.Name.Replace("_"," ");
            //MTMSVar.FTNAME = menu.Text.Replace("_", " ");
            MessageBox.Show("다음 로그인부터 변경된 폰트가 적용이 됩니다.");
        }

        /// <summary>
        /// Create menu recursively, save menu data into the Tag
        /// </summary>
        /// <param name="pmenuItem"></param>
        /// <param name="topMenuCode"></param>
        private void CreateMenuRecursively(C1CommandMenu pmenuItem, string topMenuCode)
        {
            string query = string.Format("ParentMenuId = '{0}'", topMenuCode);
            DataRow[] drMenuItem = menuDataSet.Tables[0].Select(query, "SORT");

            if (drMenuItem.Length > 0)
            {
                NEXCORE.Common.Data.Menu menu = null;



                for (int rowIdx = 0; rowIdx < drMenuItem.Length; rowIdx++)
                {
                    C1CommandMenu mFile = (C1CommandMenu)MainHolder.CreateCommand(typeof(C1CommandMenu));
                    // Create menu data
                    menu = new NEXCORE.Common.Data.Menu();

                    menu.MenuId = drMenuItem[rowIdx]["MenuId"].ToString().Trim();
                    menu.ParentMenuId = drMenuItem[rowIdx]["ParentMenuId"].ToString().Trim();
                    menu.MenuKorea = drMenuItem[rowIdx]["MenuKorea"].ToString().Trim();
                    if (drMenuItem[rowIdx]["PgmId"] != null)
                        menu.PgmId = drMenuItem[rowIdx]["PgmId"].ToString().Trim();

                    // Composite new menu
                    mFile.Click += new ClickEventHandler(menuItem_Click);

                    pmenuItem.CommandLinks.Add(new C1CommandLink(mFile));

                    mFile.Name = drMenuItem[rowIdx]["MenuId"].ToString();


                    mFile.Text = drMenuItem[rowIdx]["MenuKorea"].ToString();




                    mFile.UserData = menu;
                    // Invoke recursively
                    CreateMenuRecursively(mFile, drMenuItem[rowIdx]["MenuId"].ToString());
                }


            }
        }


        /// <summary>
        /// Menu item is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void menuItem_Click(object sender, EventArgs e)
        {
            C1CommandMenu menu = (C1CommandMenu)sender;
            NEXCORE.Common.Data.Menu menuData = menu.UserData as NEXCORE.Common.Data.Menu;

            if (!string.IsNullOrEmpty(menuData.PgmId))
            {
                NEXCORE.Common.Data.Program pgm = CommonManager.GetProgram(menuData.PgmId);
                if (!string.IsNullOrEmpty(pgm.PgmType))
                {
                    NEXCORE.Common.Data.User user = FormInterface.GetCurrentUser();
                    FormInterface.SetCurrentProgram(pgm);

                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    try
                    {
                        // Use Program-Access Logging - THISPGM
                        switch (pgm.PgmType)
                        {
                            case "POPUP":
                                {
                                    CreatePopup(pgm);
                                }
                                break;
                            case "CONTENT":
                                {
                                    
                                    CreateTabPage(menuData, pgm );


                                }
                                break;
                            default:
                                break;
                        }
                        sw.Stop();
                        CommonManager.HistoryProgram(user.UserId, pgm.PgmId, DateTime.Now, Convert.ToInt32(sw.ElapsedMilliseconds), CommonManager.InvokeState.Success.ToString(), "");

                    }
                    catch (Exception ex)
                    {
                        sw.Stop();

                        string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                        CommonManager.ErrorLog(pgm.PgmId, user.UserId, msg);
                        UtilityHelper.WriteLog(msg, UtilityHelper.eLogCategory.Framework, System.Diagnostics.TraceEventType.Error);
                        CommonHelper.CallMsgPopUp("알림", "화면 로드중 오류가 발생하였습니다!!!", "", "1", msg);
                    }
                }
                else
                {
                    CommonHelper.CallMsgPopUp("알림", "프로그램 Type이 등록되지 않았습니다.", "프로그램관리에서 프로그램 Type을 등록하십시요.", "1", "");
                }
            }
            else
            {

                CommonHelper.CallMsgPopUp("알림", "프로그램이 등록되지 않았습니다.", "메뉴관리에서 프로그램을 등록하십시요.", "1", "");
            }
        }
        void toolbarItem_Click(object sender, EventArgs e)
        {

            C1Command menu = (C1Command)sender;


            NEXCORE.Common.Data.Menu menuData = menu.UserData as NEXCORE.Common.Data.Menu;



            if (!string.IsNullOrEmpty(menuData.PgmId))
            {
                NEXCORE.Common.Data.Program pgm = CommonManager.GetProgram(menuData.PgmId);
                NEXCORE.Common.Data.User user = FormInterface.GetCurrentUser();
                FormInterface.SetCurrentProgram(pgm);

                Stopwatch sw = new Stopwatch();
                sw.Start();
                try
                {
                    // Use Program-Access Logging - THISPGM
                    switch (pgm.PgmType)
                    {
                        case "POPUP":
                            {
                                CreatePopup(pgm);
                            }
                            break;
                        case "CONTENT":
                            {

                                CreateTabPage(menuData, pgm );


                            }
                            break;
                        default:
                            break;
                    }
                    sw.Stop();
                    CommonManager.HistoryProgram(user.UserId, pgm.PgmId, DateTime.Now, Convert.ToInt32(sw.ElapsedMilliseconds), CommonManager.InvokeState.Success.ToString(), "");
                }
                catch (Exception ex)
                {
                    sw.Stop();

                    string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                    CommonManager.ErrorLog(pgm.PgmId, user.UserId, msg);
                    UtilityHelper.WriteLog(msg, UtilityHelper.eLogCategory.Framework, System.Diagnostics.TraceEventType.Error);
                    CommonHelper.CallMsgPopUp("알림", "화면 로드중 오류가 발생하였습니다!!!", "", "1", msg);
                }
            }
        }

        void myAdd_Click(object sender, EventArgs e)
        {



            C1CommandMenu menu = (C1CommandMenu)sender;
            NEXCORE.Common.Data.Menu menuData = menu.UserData as NEXCORE.Common.Data.Menu;



            if (!string.IsNullOrEmpty(menuData.PgmId))
            {
                NEXCORE.Common.Data.Program pgm = CommonManager.GetProgram(menuData.PgmId);
                if (!string.IsNullOrEmpty(pgm.PgmType))
                {
                    NEXCORE.Common.Data.User user = FormInterface.GetCurrentUser();
                    FormInterface.SetCurrentProgram(pgm);

                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    try
                    {
                        // Use Program-Access Logging - THISPGM
                        switch (pgm.PgmType)
                        {
                            case "POPUP":
                                {
                                    CreatePopupMyMenu(pgm);
                                }
                                break;
                            case "CONTENT":
                                {

                                    CreateTabPage(menuData, pgm );


                                }
                                break;
                            default:
                                break;
                        }
                        sw.Stop();
                        CommonManager.HistoryProgram(user.UserId, pgm.PgmId, DateTime.Now, Convert.ToInt32(sw.ElapsedMilliseconds), CommonManager.InvokeState.Success.ToString(), "");

                    }
                    catch (Exception ex)
                    {
                        sw.Stop();

                        string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                        CommonManager.ErrorLog(pgm.PgmId, user.UserId, msg);
                        UtilityHelper.WriteLog(msg, UtilityHelper.eLogCategory.Framework, System.Diagnostics.TraceEventType.Error);
                        CommonHelper.CallMsgPopUp("알림", "화면 로드중 오류가 발생하였습니다!!!", "", "1", msg);
                    }
                }
                else
                {
                    CommonHelper.CallMsgPopUp("알림", "프로그램 Type이 등록되지 않았습니다.", "프로그램관리에서 프로그램 Type을 등록하십시요.", "1", "");
                }
            }
            else
            {

                CommonHelper.CallMsgPopUp("알림", "프로그램이 등록되지 않았습니다.", "메뉴관리에서 프로그램을 등록하십시요.", "1", "");
            }

        }



        private bool GetChildGridName(string control, Control controls)
        {
            try
            {


            bool haveChanged = false;

            foreach (Control ctrlChild in controls.Controls)
            {
                if (controls.GetType().Name == "C1FlexGrid")
                {
                   C1.Win.C1FlexGrid.C1FlexGrid t =   controls as C1.Win.C1FlexGrid.C1FlexGrid;
                   
     


                      DataTable dt = t.DataSource as DataTable;

                      foreach (DataRow row in dt.Rows)
                      {
                          if (row.RowState != DataRowState.Unchanged)
                          {
                              haveChanged = true;
                              break;
                          }
                      }
 
                }

                if (haveChanged) return haveChanged;
                haveChanged = GetChildGridName(control, ctrlChild);

            }
            return haveChanged;
            }
            catch 
            {

                return false;
            }
        }
            
        /// <summary>
        /// Create new tab-page (DevExpress specifically)
        /// </summary>
        /// <param name="menuData"></param>
        /// <param name="overlap"></param>
        /// <returns></returns>
        public void CreateTabPage(NEXCORE.Common.Data.Menu menuData, NEXCORE.Common.Data.Program pgm)
        {
            bool ret = false;
            string pgmId = menuData.PgmId;
            string menuName = menuData.MenuKorea;
            string pageName = string.Empty;


            //if (ret)
            //{
            //    if (CommonHelper.CallMsgPopUp("정보", "변경된 내용이 있습니다 ." , "저장하지 않고 종료하시겠습니까 ?", "2", "") == "NO")
            //    //if (DialogResult.No == MessageBox.Show("변경된 내용이 있습니다 ." + Environment.NewLine + "저장하지 않고 종료하시겠습니까 ?", pageName, MessageBoxButtons.YesNo))
                
            //    return;
            //}


            WriteStatusBar("");

            try
            {


                // System 일 경우 서버에서 찾는다..
                //if (pgmId.Contains("SM")) baseDir = Skcc.Configuration.SkccFxConfigManager.TryGetString("PROGRAMS_PATH"); 

                // Create new instance of the control
                string assemblyFileName = System.IO.Path.Combine(baseDir, pgm.PgmAssembly + ".dll");
                string typeName = pgm.PgmPath;

                Assembly assembly = Assembly.LoadFrom(assemblyFileName);
                Type type = assembly.GetType(typeName, true, true);
                SKUserControlBase form = (SKUserControlBase)type.Assembly.CreateInstance(type.ToString());

                form.ThisProgram = pgm;


                foreach (C1DockingTabPage item in tabMain.Controls)
                {
                    if (item.CaptionText == menuName)
                    {

                        tabMain.SelectedTab = item;

                        ret = true;
                    }
                }
                if (form != null && !ret)
                {

                    C1DockingTabPage MainTabPage = new C1DockingTabPage();
                    MainTabPage.Text = "[ (" + pgmId + ") - " + menuName + " ]";
                    tabMain.TabPages.Add(MainTabPage);
                    MainTabPage.AllowDrop = true;
                    MainTabPage.CaptionText = menuName;

                    
                    //MainTabPage.Controls.Clear();

                    form.Dock = DockStyle.Fill;

                    form.AutoScroll = false;


                    MainTabPage.Name = menuName;


                    MainTabPage.Size = new System.Drawing.Size(Skcc.Configuration.SkccFxConfigManager.GetInt32("ucWidth1"), Skcc.Configuration.SkccFxConfigManager.GetInt32("ucHeight1"));
                    MainTabPage.Tag = pgm;
                    MainTabPage.Controls.Add((Control)form);

                    this.Text = Skcc.Configuration.SkccFxConfigManager.TryGetString("SK_TITLE") ;

                    tabMain.SelectedTab = MainTabPage;

                    ShowServerInfo();

                }



            }
            catch (Exception ex)
            {
                string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                CommonManager.ErrorLog(pgm.PgmId, FormInterface.GetCurrentUser().UserId, msg);
                UtilityHelper.WriteLog(msg, UtilityHelper.eLogCategory.Framework, System.Diagnostics.TraceEventType.Error);
                CommonHelper.CallMsgPopUp("알림", CommonManager.GetMessage("M10011"), "", "1", msg);
            }


        }
        private void DefaultTabPage()
        {



        }
        /// <summary>
        /// Create new tab-page (DevExpress specifically)
        /// </summary>
        /// <param name="menuData"></param>
        private void CreatePopup(NEXCORE.Common.Data.Program pgm)
        {
            try
            {
                NEXCORE.Common.Data.Program program = new NEXCORE.Common.Data.Program();
                //foreach (SKUserControlBase item in MainTabPage.Controls)
                //{

                //    program = item.ThisProgram;
                //}

                // Create new instance of the control
                string assemblyFileName = System.IO.Path.Combine(baseDir, pgm.PgmAssembly + ".dll");
                string typeName = pgm.PgmPath;

                Assembly assembly = Assembly.LoadFrom(assemblyFileName);
                Type type = assembly.GetType(typeName, true, true);
                SKDialogBase form = (SKDialogBase)type.Assembly.CreateInstance(type.ToString());
                //form.FormInterface = this.FormInterface;
                form.Tag = program;
                if (form != null)
                {
                    DialogResult dr = form.ShowDialog();

                    if (dr == DialogResult.Retry)  // 사용자 변경으로 예외처리시 초기화 - 타 팝업창시 Retry 사용금지
                    {
                        InitLoad();

                    }
                }
            }
            catch (Exception ex)
            {
                string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                CommonManager.ErrorLog(pgm.PgmId, FormInterface.GetCurrentUser().UserId, msg);
                UtilityHelper.WriteLog(msg, UtilityHelper.eLogCategory.Framework, System.Diagnostics.TraceEventType.Error);
                CommonHelper.CallMsgPopUp("알림", CommonManager.GetMessage("M10011"), "", "1", msg);

            }
        }

        private void CreatePopupMyMenu(NEXCORE.Common.Data.Program pgm)
        {
            try
            {

                NEXCORE.Common.Data.Program program = new NEXCORE.Common.Data.Program();

                foreach (SKUserControlBase item in tabMain.Controls)
                {

                    program = item.ThisProgram;
                }

                // Create new instance of the control
                string assemblyFileName = System.IO.Path.Combine(baseDir, pgm.PgmAssembly + ".dll");
                string typeName = pgm.PgmPath;

                Assembly assembly = Assembly.LoadFrom(assemblyFileName);
                Type type = assembly.GetType(typeName, true, true);
                SKDialogBase form = (SKDialogBase)type.Assembly.CreateInstance(type.ToString());
                //form.FormInterface = this.FormInterface;
                form.Tag = program;
                if (form != null)
                {
                    DialogResult dr = form.ShowDialog();

                    if (dr == DialogResult.Retry)  // 사용자 변경으로 예외처리시 초기화 - 타 팝업창시 Retry 사용금지
                    {
                        c1MainMenu1.CommandLinks.RemoveAt(c1MainMenu1.CommandLinks.Count - 1);

                        CreateFavorites();
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                CommonManager.ErrorLog(pgm.PgmId, FormInterface.GetCurrentUser().UserId, msg);
                UtilityHelper.WriteLog(msg, UtilityHelper.eLogCategory.Framework, System.Diagnostics.TraceEventType.Error);
                CommonHelper.CallMsgPopUp("알림", CommonManager.GetMessage("M10011"), "", "1", msg);

            }
        }


        public void WriteStatusBar(string msg)
        {
            lblWrite.Text = msg;
        }

        private void MainVisualStyle(C1.Win.C1Ribbon.VisualStyle formstyle, C1.Win.C1Command.VisualStyle commandstyle, Color color)
        {
            //this.VisualStyle = formstyle;
            //this.c1MainMenu1.VisualStyle = commandstyle;
            //this.tabSidebar.VisualStyle = commandstyle;
            //this.MainTabPage.TabBackColorSelected = color;
            //this.tabMain.TabAreaBackColor = color;
        }




        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //KillLoading();
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //bool ret = false;
            //foreach (SKUserControlBase item in tabMain.Controls)
            //{
            //    if (!item.ThisProgram.PgmId.Contains("SM"))
            //    {

            //        foreach (Control controls in item.Controls)
            //        {
            //            ret = GetChildGridName("", controls);

            //        }
            //    }
            //}
            
            //if (ret)
            //{
            //    if (CommonHelper.CallMsgPopUp("정보", "변경된 내용이 있습니다 .", "저장하지 않고 종료하시겠습니까 ?", "2", "") == "NO")
            //        //if (DialogResult.No == MessageBox.Show("변경된 내용이 있습니다 ." + Environment.NewLine + "저장하지 않고 종료하시겠습니까 ?", pageName, MessageBoxButtons.YesNo))

            //        e.Cancel = true;
            //}
        }
    }

}




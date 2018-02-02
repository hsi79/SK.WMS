using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using NEXCORE.Common.Helper;
using C1.Win.C1FlexGrid;
using System.Windows.Forms;
using C1.Win.C1FlexGrid.Util.Styles;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using NEXCORE.Utility.GlobalVariable;
using System.Collections.Specialized;



namespace NEXCORE.Common
{
    public static class GridHelper
    {

        public static CellStyle cschk = null;
        public static CellStyle csunchk = null;

        #region 그리드 초기 설정
        /// <summary>
        /// 그리드초기 설정
        /// </summary>
        /// <param name="_fx"></param>
        /// <param name="ColCnt"></param>
        private static void DefaultGrid(C1FlexGrid _fx, int ColCnt, int RowSize, bool AEditing, bool RowHeader)
        {
            cschk = _fx.Styles.Add("chkcolor");
            cschk.BackColor = Color.FromArgb(230, 240, 250);
            csunchk = _fx.Styles.Add("unchkcolor");
            csunchk.BackColor = Color.White;

            _fx.AutoClipboard = true;
            _fx.AutoGenerateColumns = false;
            _fx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            _fx.KeyActionEnter = KeyActionEnum.MoveAcross;
            _fx.KeyActionTab = KeyActionEnum.MoveDown;
            _fx.Rows.Count = 1;
            _fx.Cols.Fixed = 1;
            _fx.Cols.Count = ColCnt;
            _fx.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            _fx.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            _fx.ExtendLastCol = true;
            _fx.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Always;
            //_fx.ShowButtons = ShowButtonsEnum.Always;
            _fx.ForeColor = Color.Black;
            if (RowHeader) _fx.Rows.Fixed = 1;
            _fx.Rows.DefaultSize = RowSize;
            _fx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            _fx.ShowCellLabels = true;
            _fx.ShowCursor = true;
            _fx.AllowEditing = AEditing;
            _fx.ClipboardCopyMode = ClipboardCopyModeEnum.DataOnly;
            _fx.AllowResizing = AllowResizingEnum.Both;
            _fx.SelectionMode = SelectionModeEnum.Default;
            _fx.CellButtonImage = NEXCORE.Common.Properties.Resources.glasses20;
            _fx.Styles.EmptyArea.BackColor = Color.White;
            _fx.Styles.Highlight.BackColor = Color.WhiteSmoke;
            _fx.Styles.Highlight.ForeColor = Color.Black;
            _fx.Styles.Focus.BackColor = Color.WhiteSmoke;
            string font = WMSVar.FT;
            Font ft = _fx.Font;
            float s = ft.Size;
            _fx.Font = new Font(font, s);
            //_fx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            //| System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));
            //_fx.AllowAddNew = true;
        }
        /// <summary>
        /// 그리드초기 설정
        /// </summary>
        /// <param name="_fx"></param>
        public static void DefaultGrid(C1FlexGrid _fx)
        {

            DefaultGrid(_fx, 1, 20, true, true);

        }

        /// <summary>
        /// 그리드 초기 설정
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="RowHeader">Row Header 보이기 여부</param>
        public static void DefaultGrid(C1FlexGrid _fx, bool RowHeader, bool AllowEditing)
        {

            DefaultGrid(_fx, 1, 20, RowHeader, AllowEditing);

        }
        public static void DefaultGrid(C1FlexGrid _fx, bool AllowEditing)
        {

            DefaultGrid(_fx, 1, 20, AllowEditing, true);

        }
        public static void DefaultGrid(C1FlexGrid _fx, int RowSize)
        {

            DefaultGrid(_fx, 1, RowSize, true, true);

        }
        #endregion
        #region FlexGrid Column Setup
        /// <summary>
        /// 그리드 기본 컬럼 설정
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="columnName">컬럼내용</param>
        /// <param name="displayName">컬럼 타이틀</param>
        /// <param name="width">넓이</param>
        public static void InitColumn(C1FlexGrid _fx, string columnName, string displayName, int width)
        {
            InitColumn(_fx, columnName, displayName, width, false, true, true, TextAlignEnum.LeftCenter, 32367, false);
        }
        /// <summary>
        /// 그리드 기본 컬럼 설정
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="columnName">컬럼내용</param>
        /// <param name="displayName">컬럼 타이틀</param>
        /// <param name="width">넓이</param>
        /// <param name="maxLength">최대 길이</param>
        public static void InitColumn(C1FlexGrid _fx, string columnName, string displayName, int width, int maxLength)
        {
            InitColumn(_fx, columnName, displayName, width, false, true, true, TextAlignEnum.LeftCenter, maxLength, false);
        }
        /// <summary>
        /// 그리드 기본 컬럼 설정
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="columnName">컬럼내용</param>
        /// <param name="displayName">컬럼 타이틀</param>
        /// <param name="width">넓이</param>
        /// <param name="visible">감추기 여부</param>
        public static void InitColumn(C1FlexGrid _fx, string columnName, string displayName, int width, bool required, bool visible)
        {
            InitColumn(_fx, columnName, displayName, width, required, visible, true, TextAlignEnum.LeftCenter, 32367, false);
        }

        /// <summary>
        /// 그리드 기본 컬럼 설정
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="columnName">컬럼내용</param>
        /// <param name="displayName">컬럼 타이틀</param>
        /// <param name="width">넓이</param>
        /// <param name="visible">감추기 여부</param>
        /// <param name="AllowEditing">에디트 여부</param>
        /// <param name="Align">컬럼 정렬</param>
        public static void InitColumn(C1FlexGrid _fx, string columnName, string displayName, int width, bool required, bool visible, bool AllowEditing, TextAlignEnum Align)
        {
            InitColumn(_fx, columnName, displayName, width, required, visible, AllowEditing, Align, 32367, false);
        }

        /// <summary>
        /// 그리드 기본 컬럼 설정
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="columnName">컬럼내용</param>
        /// <param name="displayName">컬럼 타이틀</param>
        /// <param name="width">넓이</param>
        /// <param name="visible">감추기 여부</param>
        /// <param name="AllowEditing">에디트 여부</param>
        /// <param name="Align">컬럼 정렬</param>
        public static void InitColumn(C1FlexGrid _fx, string columnName, string displayName, int width, bool required, bool visible, bool AllowEditing, TextAlignEnum Align, int max)
        {
            InitColumn(_fx, columnName, displayName, width, required, visible, AllowEditing, Align, max, false);
        }

        /// <summary>
        /// 그리드 기본 컬럼 설정
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="columnName">컬럼내용</param>
        /// <param name="displayName">컬럼 타이틀</param>
        /// <param name="width">넓이</param>
        /// <param name="visible">감추기 여부</param>
        /// <param name="AllowEditing">에디트 여부</param>
        /// <param name="Align">컬럼 정렬</param>
        /// <param name="allowMerging">셀 머지 여부</param>
        public static void InitColumn(C1FlexGrid _fx, string columnName, string displayName, int width, bool required, bool visible, bool AllowEditing, TextAlignEnum Align, bool allowMerging)
        {
            InitColumn(_fx, columnName, displayName, width, required, visible, AllowEditing, Align, 32367, false);
        }

        /// <summary>
        /// 그리드 기본 컬럼 설정
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="columnName">컬럼내용</param>
        /// <param name="displayName">컬럼 타이틀</param>
        /// <param name="width">넓이</param>
        /// <param name="visible">감추기 여부</param>
        /// <param name="AllowEditing">에디트 여부</param>
        /// <param name="Align">컬럼 정렬</param>
        /// <param name="max">최대 크기</param>
        /// <param name="allowMerging">셀 머지 여부</param>
        public static void InitColumn(C1FlexGrid _fx, string columnName, string displayName, int width, bool required, bool visible, bool AllowEditing, TextAlignEnum Align, int max, bool allowMerging)
        {
            TextBox txt = new TextBox();
            txt.MaxLength = max;
            txt.TextAlign = HorizontalAlignment.Left;
            txt.BorderStyle = BorderStyle.None;
            txt.Height = 20;
            txt.Multiline = true;
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            c.Name = columnName;
            c.Caption = displayName;
            c.TextAlign = TextAlignEnum.LeftCenter;
            c.Width = width;
            c.AllowEditing = AllowEditing;
            c.Editor = txt;
            c.Visible = visible;
            c.TextAlign = Align;
            c.AllowMerging = allowMerging;


            if (required)
            {
                CellStyle cs = _fx.Styles.Add("backcolor");
                cs.BackColor = Color.LightCyan;
                c.Style = cs;
            }
            // Header 정렬
            InitColumnHeader(_fx);
        }

        /// <summary>
        /// 그리드 기본 컬럼 설정
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="columnName">컬럼내용</param>
        /// <param name="displayName">컬럼 타이틀</param>
        /// <param name="width">넓이</param>
        /// <param name="visible">감추기 여부</param>
        /// <param name="AllowEditing">에디트 여부</param>
        /// <param name="Align">컬럼 정렬</param>
        /// <param name="max">최대 크기</param>
        /// <param name="allowMerging">셀 머지 여부</param>
        public static void InitColumnFILE_EXTImage(C1FlexGrid _fx, string columnName, string displayName, int width, bool required, bool visible, bool allowMerging)
        {
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            c.Name = "FILE_EXT";
            c.Caption = "파일 타입";
            //c.TextAlign = TextAlignEnum.CenterCenter;
            c.AllowEditing = false;
            c.DataType = typeof(Image);
            c.Width = width;
            c.ImageAlign = ImageAlignEnum.CenterCenter;
            c.ImageAndText = false;

            c.Visible = visible;
            c.AllowMerging = allowMerging;
            //

            ListDictionary ld = new ListDictionary();
            ld.Add("AVI", NEXCORE.Common.Properties.Resources.avi);
            ld.Add("DISK", NEXCORE.Common.Properties.Resources.disk);
            ld.Add("DOC", NEXCORE.Common.Properties.Resources.doc);
            ld.Add("DOCX", NEXCORE.Common.Properties.Resources.doc);
            ld.Add("DWG", NEXCORE.Common.Properties.Resources.dwg);
            ld.Add("EXE", NEXCORE.Common.Properties.Resources.exe);
            ld.Add("GIF", NEXCORE.Common.Properties.Resources.image);
            ld.Add("JPG", NEXCORE.Common.Properties.Resources.image);
            ld.Add("BMP", NEXCORE.Common.Properties.Resources.image);
            ld.Add("MPEG", NEXCORE.Common.Properties.Resources.avi);
            ld.Add("HTM", NEXCORE.Common.Properties.Resources.htm);
            ld.Add("HTML", NEXCORE.Common.Properties.Resources.htm);
            ld.Add("HWP", NEXCORE.Common.Properties.Resources.hwp);
            ld.Add("MDB", NEXCORE.Common.Properties.Resources.mdb);
            ld.Add("PDF", NEXCORE.Common.Properties.Resources.pdf);
            ld.Add("PPT", NEXCORE.Common.Properties.Resources.ppt);
            ld.Add("PPTX", NEXCORE.Common.Properties.Resources.ppt);
            ld.Add("MP3", NEXCORE.Common.Properties.Resources.sound);
            ld.Add("MP4", NEXCORE.Common.Properties.Resources.sound);
            ld.Add("TXT", NEXCORE.Common.Properties.Resources.txt);
            ld.Add("XLS", NEXCORE.Common.Properties.Resources.xls);
            ld.Add("XLSX", NEXCORE.Common.Properties.Resources.xls);
            ld.Add("ZIP", NEXCORE.Common.Properties.Resources.zip);
            c.ImageMap = ld;

            if (required)
            {
                CellStyle cs = _fx.Styles.Add("backcolor");
                cs.BackColor = Color.LightCyan;
                c.Style = cs;
            }
            // Header 정렬
            InitColumnHeader(_fx);
        }

        public static void InitColumnCombo(C1FlexGrid _fx, string columnName, string displayName,
           int width, List<NEXCORE.Common.Data.Code> ds)
        {
            InitColumnCombo(_fx, columnName, displayName, width, true, true, ds);
        }
        public static void InitColumnCombo(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool visible, bool AllowEditing, List<NEXCORE.Common.Data.Code> ds)
        {



            //Combo column
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            //Multi-column combo
            ComboBox c1Combo1 = new ComboBox();
            c1Combo1.DisplayMember = "Name";
            c1Combo1.ValueMember = "Id";
            c1Combo1.DataSource = ds;
            c1Combo1.DropDownWidth = width;
            c1Combo1.Width = width;

            c.Caption = displayName;
            c.Name = columnName;
            c.Editor = c1Combo1;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = AllowEditing;
            c.TextAlign = TextAlignEnum.LeftCenter;
            // Header 정렬
            InitColumnHeader(_fx);

        }

        public static void InitColumnCombo(C1FlexGrid _fx, string columnName, string displayName, int width)
        {



            //Combo column
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            //Multi-column combo
            ComboBox c1Combo1 = new ComboBox();
            c1Combo1.DropDownWidth = width;
            c1Combo1.Width = width;

            c.Caption = displayName;
            c.Name = columnName;
            c.Editor = c1Combo1;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = false;
            c.TextAlign = TextAlignEnum.LeftCenter;
            // Header 정렬
            InitColumnHeader(_fx);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="columnName">컬럼영</param>
        /// <param name="displayName">컬럼헤더명</param>
        /// <param name="width">넓이</param>
        /// <param name="dt">DataTable</param>
        /// <param name="displaymember">Display Member</param>
        /// <param name="valuemember">Value Member</param>
        public static void InitColumnCombo(C1FlexGrid _fx, string columnName, string displayName,
           int width, DataTable dt, string displaymember, string valuemember)
        {
            InitColumnCombo(_fx, columnName, displayName, width, true, true, dt, displaymember, valuemember);
        }
        public static void InitColumnCombo(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool visible, bool AllowEditing, DataTable dt, string displaymember, string valuemember)
        {
            InitColumnCombo(_fx, columnName, displayName, width, true, true, dt, displaymember, valuemember, TextAlignEnum.CenterCenter);
        }
        public static void InitColumnCombo(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool visible, bool AllowEditing, DataTable dt, string displaymember, string valuemember, TextAlignEnum tae)
        {
            //Combo column
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            ////Multi-column combo
            //ComboBox c1Combo1 = new ComboBox();
            //c1Combo1.DisplayMember = displaymember;
            //c1Combo1.ValueMember = valuemember;
            //c1Combo1.DataSource = dt;
            //c1Combo1.DropDownWidth = width;
            //c1Combo1.Width = width;

            c.Caption = displayName;
            c.Name = columnName;
            c.DataMap = BuildDataMap(dt, valuemember, displaymember);
            //c.Editor = c1Combo1;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = AllowEditing;
            c.TextAlign = tae;
            // Header 정렬
            InitColumnHeader(_fx);
        }

        public static void InitColumnCombo(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool visible, bool AllowEditing, DataView dt, string displaymember, string valuemember)
        {
            //Combo column
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            ////Multi-column combo
            //ComboBox c1Combo1 = new ComboBox();
            //c1Combo1.DisplayMember = displaymember;
            //c1Combo1.ValueMember = valuemember;
            //c1Combo1.DataSource = dt;
            //c1Combo1.DropDownWidth = width;
            //c1Combo1.Width = width;

            c.Caption = displayName;
            c.Name = columnName;
            c.DataMap = BuildDataMap(dt, valuemember, displaymember);
            //c.Editor = c1Combo1;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = AllowEditing;
            c.TextAlign = TextAlignEnum.CenterCenter;
            // Header 정렬
            InitColumnHeader(_fx);
        }

        private static IDictionary BuildDataMap(DataTable table, string key, string value)
        {
            ListDictionary ld = new ListDictionary();
            foreach (DataRow dr in table.Rows)
                ld.Add(dr[key], dr[value]);
            return ld;
        }

        private static IDictionary BuildDataMap(DataView table, string key, string value)
        {
            if (table.Count < 1)
                return null;

            ListDictionary ld = new ListDictionary();

            for (int i = 0; i < table.Count; i++)
                ld.Add(table[i][key], table[i][value]);
            return ld;
        }

        public static void InitColumnCheckBox(C1FlexGrid _fx, string columnName, string displayName,
           int width)
        {
            InitColumnCheckBox(_fx, columnName, displayName, width, false, true, true);
        }
        public static void InitColumnCheckBox(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool header, bool visible, bool AllowEditing)
        {
            //Checkbox column
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            c.DataType = typeof(Boolean);
            c.Caption = displayName;
            c.Name = columnName;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = AllowEditing;
            c.TextAlign = TextAlignEnum.CenterCenter;

            if (header)
                c.AllowSorting = false;

            // Header 정렬
            InitColumnHeader(_fx, header, _fx.Cols.Count, width);

        }
        public static void InitColumnCheckBoxList(C1FlexGrid _fx, string columnName, string displayName,
   int width, bool visible, bool AllowEditing, string[] Items)
        {
            //Checkbox List column
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];

            CheckListEditor checkListEditor = new CheckListEditor(Items);
            c.Editor = new UITypeEditorControl(checkListEditor, false);


            c.Caption = displayName;
            c.Name = columnName;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = AllowEditing;
            c.TextAlign = TextAlignEnum.LeftCenter;
            // Header 정렬
            InitColumnHeader(_fx);

        }


        public static void InitColumnNumberYear(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool visible, bool AllowEditing)
        {
            //Numeric column
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            c.DataType = typeof(int);
            c.Format = "###0";

            NumericTextBox ntb = new NumericTextBox();
            ntb.Format = c.Format;
            ntb.MaxLength = 4;

            c.Editor = ntb;
            //c.Editor = new NumericTextBox(c.Format, false);
            c.Caption = displayName;
            c.Name = columnName;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = AllowEditing;
            c.TextAlign = TextAlignEnum.RightCenter;
            // Header 정렬
            InitColumnHeader(_fx);
        }

        public static void InitColumnDate(C1FlexGrid _fx, string columnName, string displayName,
           int width)
        {
            InitColumnDate(_fx, columnName, displayName, width, true, true);
        }
        public static void InitColumnDate(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool visible, bool AllowEditing)
        {
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            c.DataType = typeof(DateTime);
            c.Caption = displayName;
            c.Name = columnName;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = AllowEditing;
            c.TextAlign = TextAlignEnum.CenterCenter;
            // Header 정렬
            InitColumnHeader(_fx);
        }
        public static void InitColumnNumber(C1FlexGrid _fx, string columnName, string displayName,
          int width)
        {
            InitColumnNumber(_fx, columnName, displayName, width, true, true);
        }
        public static void InitColumnNumber(C1FlexGrid _fx, string columnName, string displayName,
          int width, int Precision)
        {
            InitColumnNumber(_fx, columnName, displayName, width, true, true, Precision);
        }
        public static void InitColumnNumber(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool visible, bool AllowEditing)
        {
            InitColumnNumber(_fx, columnName, displayName, width, visible, AllowEditing, 0);
        }
        public static void InitColumnNumber(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool visible, bool AllowEditing, int Precision)
        {
            InitColumnNumber(_fx, columnName, displayName, width, visible, AllowEditing, Precision, 5);
        }
        public static void InitColumnNumber(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool visible, bool AllowEditing, int Precision, int integerLength)
        {
            string digit = string.Empty;
            //Numeric column
            if (Precision > 0) digit = "." + digit.PadLeft(Precision, '0');
            //Numeric column
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            c.DataType = typeof(int);
            c.Format = "#,##0" + digit;

            NumericTextBox ntb = new NumericTextBox();
            ntb.Format = c.Format;
            if (Precision > 0)
                ntb.MaxLength = integerLength + 1;
            else
                ntb.MaxLength = integerLength;

            c.Editor = ntb;
            //c.Editor = new NumericTextBox(c.Format, false);
            c.Caption = displayName;
            c.Name = columnName;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = AllowEditing;
            c.TextAlign = TextAlignEnum.RightCenter;
            // Header 정렬
            InitColumnHeader(_fx);
        }
        public static void InitColumnCurrency(C1FlexGrid _fx, string columnName, string displayName,
   int width)
        {
            InitColumnCurrency(_fx, columnName, displayName, width, true, true);
        }
        public static void InitColumnCurrency(C1FlexGrid _fx, string columnName, string displayName,
   int width, bool visible, bool AllowEditing)
        {
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            c.DataType = typeof(double);
            c.Format = "c";

            c.Caption = displayName;
            c.Name = columnName;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = AllowEditing;
            c.TextAlign = TextAlignEnum.RightCenter;
            InitColumnHeader(_fx);
        }

        private static void InitColumnHeader(C1FlexGrid _fx)
        {
            // Header 정렬
            InitColumnHeader(_fx, false, 0, 30);


        }

        private static void InitColumnHeader(C1FlexGrid _fx, bool header, int col, int width)
        {
            // Header 정렬

            Margins margin = new Margins((width - 14) / 2, 0, 0, 0);
            if (header)
            {

                CellStyle cscheck = _fx.Styles.Add("headercheck");
                cscheck.DataType = typeof(Boolean);
                cscheck.ImageAlign = ImageAlignEnum.CenterCenter;
                CellRange rg = _fx.GetCellRange(0, col - 1);
                rg.Style = _fx.Styles["headercheck"];
            }
            else
            {
                CellStyle cs = _fx.Styles.Add("headeralign");
                cs.TextAlign = TextAlignEnum.CenterCenter;

                CellRange rg = _fx.GetCellRange(0, _fx.Cols.Count - 1);
                rg.Style = _fx.Styles["headeralign"];
            }

        }
        /// <summary>
        /// 그리드 헤더 멀티 
        /// </summary>
        /// <param name="_fx">그리드 명</param>
        /// <param name="fixrow">헤더 멀티 수</param>
        /// <param name="row">현재 헤더 로(0부터 시작)</param>
        /// <param name="ColStart">시작 컬럼</param>
        /// <param name="ColEnd">병합 컬럼 수</param>
        /// <param name="headerName">헤더 명</param>
        public static void SetMultiHeader(C1FlexGrid _fx, int fixrow, int row, int rowspan, int col, int colspan, string headerName)
        {
            // set up to merge headers
            _fx.AllowMerging = AllowMergingEnum.FixedOnly;
            _fx.Rows.Count = fixrow;
            // row merge
            for (int i = 0; i < fixrow; i++)
            {
                _fx.Rows[i].AllowMerging = true;
            }

            _fx.Rows.Fixed = fixrow;
            for (int i = col; i < col + colspan; i++)
            {
                _fx.Cols[i].AllowMerging = true;
                for (int j = row; j < row + rowspan; j++)
                {
                    _fx[j, i] = headerName;
                }
                CellStyle cs = _fx.Styles.Add("headeralign");
                cs.TextAlign = TextAlignEnum.CenterCenter;
                if (row > 0)
                {
                    CellRange rg = _fx.GetCellRange(row, i);
                    rg.Style = _fx.Styles["headeralign"];
                }
            }



        }
        public static void InitColumnEditMask(C1FlexGrid _fx, string columnName, string displayName,
           int width, string EditMask)
        {
            InitColumnEditMask(_fx, columnName, displayName, width, true, true, EditMask);
        }
        public static void InitColumnEditMask(C1FlexGrid _fx, string columnName, string displayName,
           int width, bool visible, bool AllowEditing, string EditMask)
        {
            //Numeric column
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            c.DataType = typeof(double);
            c.EditMask = EditMask;// "GMT#0:00";
            c.Caption = displayName;
            c.Name = columnName;
            c.Width = width;
            c.Visible = true;
            c.AllowEditing = AllowEditing;
            c.TextAlign = TextAlignEnum.LeftCenter;
            // Header 정렬
            CellStyle cs = _fx.Styles.Add("headeralign");
            cs.TextAlign = TextAlignEnum.CenterCenter;
            CellRange rg = _fx.GetCellRange(0, _fx.Cols.Count - 1);
            rg.Style = _fx.Styles["headeralign"];
        }

        public enum ButtonImage
        {
            glasses
          , delete
        };

        public static void InitColumnButton(C1FlexGrid _fx, string columnName, string displayName,
          int width, EventHandler clickEvent)
        {

            InitColumnButton(_fx, columnName, displayName, width, clickEvent, ButtonImage.glasses);
        }

        public static void InitColumnButton(C1FlexGrid _fx, string columnName, string displayName,
          int width, EventHandler clickEvent, ButtonImage bi)
        {

            C1.Win.C1Input.C1Button btn = new C1.Win.C1Input.C1Button();
            btn.Text = "";

            if (bi == ButtonImage.glasses)
                btn.Image = NEXCORE.Common.Properties.Resources.glasses20;
            else if (bi == ButtonImage.delete)
                btn.Image = NEXCORE.Common.Properties.Resources.X20;

            btn.BackColor = Color.Transparent;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.FlatStyle = FlatStyle.Flat;
            btn.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            btn.ForeColor = Color.Black;
            btn.Click += clickEvent;
            btn.AutoSize = false;
            btn.Width = 20;
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];

            c.Editor = btn;
            c.Caption = displayName;
            c.Name = columnName;
            c.Width = width;
            c.AllowEditing = true;
            c.Visible = true;
            c.AllowResizing = false;
            c.TextAlign = TextAlignEnum.CenterCenter;
            CellStyle cs = _fx.Styles.Add("headeralign");
            cs.TextAlign = TextAlignEnum.CenterCenter;
            CellRange rg = _fx.GetCellRange(0, _fx.Cols.Count - 1);
            rg.Style = _fx.Styles["headeralign"];

        }

        public static void InitColumnButton(C1FlexGrid _fx, string columnName, string displayName,
          int width, ContentAlignment btnTextAlign, TextAlignEnum textAlign, EventHandler clickEvent)
        {

            C1.Win.C1Input.C1Button btn = new C1.Win.C1Input.C1Button();
            btn.Text = "btn";
            btn.BackColor = Color.Transparent;
            btn.TextAlign = btnTextAlign;
            btn.FlatStyle = FlatStyle.Flat;
            btn.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            btn.ForeColor = Color.Black;
            btn.Click += clickEvent;
            _fx.Cols.Count = _fx.Cols.Count + 1;
            Column c = _fx.Cols[_fx.Cols.Count - 1];
            c.Editor = btn;
            c.Caption = displayName;
            c.Name = columnName;
            c.Width = width;
            c.AllowEditing = true;
            c.Visible = true;
            c.TextAlign = textAlign;
            CellStyle cs = _fx.Styles.Add("headeralign");
            cs.TextAlign = TextAlignEnum.CenterCenter;
            CellRange rg = _fx.GetCellRange(0, _fx.Cols.Count - 1);
            rg.Style = _fx.Styles["headeralign"];

        }
        #endregion
        /// <summary>
        /// 그리드 내용 프린트
        /// </summary>
        /// <param name="_fx">그리드명</param>
        /// <param name="header">페이지 타이틀</param>
        /// <param name="footer">바닥글</param>
        public static void PrintGrid(C1FlexGrid _fx, string header, string footer)
        {
            if (_fx.Rows.Count == 1)
            {
                MessageBox.Show("자료가 없습니다.");
                return;
            }
            _fx.PrintGrid("Grid", C1.Win.C1FlexGrid.PrintGridFlags.ShowPreviewDialog, header, footer);
        }
        /// <summary>
        /// 그리드 내용 프린트
        /// </summary>
        /// <param name="_fx">그리드명</param>
        public static void PrintGrid(C1FlexGrid _fx)
        {
            if (_fx.Rows.Count == 1)
            {
                MessageBox.Show("자료가 없습니다.");
                return;
            }
            _fx.PrintGrid("Grid", C1.Win.C1FlexGrid.PrintGridFlags.ShowPreviewDialog);
        }
        /// <summary>
        /// 그리드 내용 프린트
        /// </summary>
        /// <param name="_fx">그리드명</param>
        /// <param name="header">페이지 타이틀</param>
        public static void PrintGrid(C1FlexGrid _fx, string header)
        {
            if (_fx.Rows.Count == 1)
            {
                MessageBox.Show("자료가 없습니다.");
                return;
            }
            _fx.PrintGrid("Grid", C1.Win.C1FlexGrid.PrintGridFlags.ShowPreviewDialog, header, "");
        }
        /// <summary>
        /// 엑셀로 그리드 내용 저장
        /// </summary>
        /// <param name="_fx">그리드 명</param>
        public static void ExportExcel(C1FlexGrid _fx)
        {
            if (_fx.Rows.Count == 1)
            {
                MessageBox.Show("자료가 없습니다.");
                return;
            }


            C1.Win.C1FlexGrid.FileFlags _flags;
            _flags = new FileFlags();

            //_flags = _flags | FileFlags.AsDisplayed;
            _flags = _flags | FileFlags.IncludeFixedCells;
            _flags = _flags | FileFlags.NoFreezing;
            _flags = _flags | FileFlags.SaveMergedRanges;
            //_flags = _flags | FileFlags.VisibleOnly;

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Excel (*.xls)|*.xls";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _fx.SaveExcel(sfd.FileName, _flags);

                System.Diagnostics.Process.Start(sfd.FileName);
            }

            //fxexcel.Dispose();
        }

        /// <summary>
        /// 엑셀 파일 로드
        /// </summary>
        /// <param name="_fx">그리드 명</param>
        public static void ImportExcel(C1FlexGrid _fx)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel (*.xls, *.xlsx)|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Load selected Excel File
                    _fx.DataSource = null;
                    _fx.LoadExcel(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open Excel file: " + ex.Message);
                }
            }
        }

        public static void AddRow(C1FlexGrid _fx)
        {
            _fx.Rows.Add();
            //SetCellBackColor(_fx, _fx.Rows.Count - 1, _fx.Cols.Count - 1, Color.LightYellow);
        }
        public static void AddRow(C1FlexGrid _fx, int row)
        {
            _fx.Rows.Add(row);
            //SetCellBackColor(_fx, row, _fx.Cols.Count, Color.LightYellow);
        }
        /// <summary>
        /// Column 삭제
        /// </summary>
        public static void DeleteColumnAll(C1FlexGrid _fx)
        {
            if (_fx.DataSource != null && _fx.Cols.Count > 0)
                _fx.Cols.RemoveRange(1, _fx.Cols.Count - 1);
        }

        public static void DeleteColumn(C1FlexGrid _fx, int startCol, int endCol)
        {
            if (_fx.DataSource != null && _fx.Cols.Count > 0)
                _fx.Cols.RemoveRange(startCol, endCol);
        }

        /// <summary>
        /// Row 삭제
        /// </summary>
        public static void DeleteRowAll(C1FlexGrid _fx)
        {
            if (_fx.DataSource != null && ((DataTable)_fx.DataSource).Rows.Count > 0)
            {
                DataRow[] drl = ((DataTable)_fx.DataSource).Select();
                DataTable dt = drl.CopyToDataTable();
                dt.Clear();
                _fx.DataSource = dt;
            }
        }

        public static void DeleteRow(C1FlexGrid _fx, int row)
        {
            _fx.Rows.Remove(row);
        }
        public static void DeleteRow(C1FlexGrid _fx, Row row)
        {
            _fx.Rows.Remove(row);
        }
        public static object GetValue(C1FlexGrid _fx, int row, int col)
        {
            if (_fx.GetData(row, col) == null) return "";
            return _fx.GetData(row, col);
        }
        public static string GetText(C1FlexGrid _fx, int row, int col)
        {
            if (_fx.GetData(row, col) == null) return "";
            return _fx.GetData(row, col).ToString();
        }
        public static string GetText(C1FlexGrid _fx, int row, string col)
        {
            if (_fx.GetData(row, col) == null) return "";
            return _fx.GetData(row, col).ToString();
        }
        public static void SetValue(C1FlexGrid _fx, int row, int col, object obj)
        {
            _fx.SetData(row, col, obj);
        }
        public static void SetText(C1FlexGrid _fx, int row, int col, string val)
        {
            _fx.SetData(row, col, val);
        }

        /// <summary>
        /// 그리드 타이틀 명 가져오기
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="col">헤더 컬럼</param>
        /// <returns></returns>
        public static string GetHeaderText(C1FlexGrid _fx, int col)
        {
            if (_fx.Rows[1][col] == null) return "";
            return _fx.Rows[1][col].ToString();
        }
        /// <summary>
        /// 그리드 셀 배경색 지정
        /// </summary>
        /// <param name="_fx"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="color"></param>
        public static void SetCellBackColor(C1FlexGrid _fx, int row, int col, Color color)
        {
            string strBackcolor = "backcolor" + row.ToString() + col.ToString();

            CellStyle cs = _fx.Styles.Add(strBackcolor);
            cs.BackColor = color;
            CellRange rg = _fx.GetCellRange(row, col);
            rg.Style = _fx.Styles[strBackcolor];


        }
        /// <summary>
        /// 그리드 행 배경색 지정
        /// </summary>
        /// <param name="_fx"></param>
        /// <param name="row"></param>
        /// <param name="color"></param>
        public static void SetRowBackColor(C1FlexGrid _fx, int row, Color color)
        {
            CellStyle cs = _fx.Styles.Add("rowbackcolor");
            cs.BackColor = color;
            CellRange rg = _fx.GetCellRange(row, 1, row, _fx.Cols.Count - 1);
            rg.Style = _fx.Styles["rowbackcolor"];


        }
        /// <summary>
        /// 그리드 cell Fore Color 지정
        /// </summary>
        /// <param name="_fx"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="color"></param>
        public static void SetCellForeColor(C1FlexGrid _fx, int row, int col, Color color)
        {
            CellStyle cs = _fx.Styles.Add("cellforecolor");

            cs.ForeColor = color;


            CellRange rg = _fx.GetCellRange(row, col);
            rg.Style = _fx.Styles["cellforecolor"];
        }

        /// <summary>
        /// 그리드 셀 배경색, 글자색, 굵기 지정
        /// </summary>
        /// <param name="_fx"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="color"></param>
        public static void SetCellStyle(C1FlexGrid _fx, int row, int col, Color backColor, Color foreColor, bool bold)
        {
            CellStyle cs = _fx.Styles.Add("backcolor");
            cs.BackColor = backColor;
            cs.ForeColor = foreColor;

            if (bold)
                cs.Font = new Font(cs.Font, FontStyle.Bold);

            CellRange rg = _fx.GetCellRange(row, col);
            rg.Style = _fx.Styles["backcolor"];


        }

        /// <summary>
        /// 그리드에 데이터 셋 바인딩
        /// </summary>
        /// <param name="_fx"></param>
        /// <param name="ds"></param>
        public static void DataBind(C1FlexGrid _fx, DataSet ds)
        {
            DataBind(_fx, ds.Tables[0]);
        }
        /// <summary>
        /// 그리드에 데이터테이블 바인드
        /// </summary>
        /// <param name="_fx"></param>
        /// <param name="dt"></param>
        public static void DataBind(C1FlexGrid _fx, DataTable dt)
        {
            _fx.DataSource = dt;


            //if (_fx.Rows.Fixed == 1)
            //{
            //    for (int r = 1; r < _fx.Rows.Count; r++)
            //        _fx[r, 0] = r;
            //}

            int countFixed = _fx.Rows.Fixed;
            int cnt = 1;
            if (countFixed > 0)
            {
                for (int r = countFixed; r < _fx.Rows.Count; r++)
                    _fx[r, 0] = cnt++;
            }
        }
        /// <summary>
        /// 그리드 컬럼에 필수입력 표시
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="row">현재 행</param>
        /// <param name="req">수정,삭제 선택 여부 선택하면 true</param>
        /// <param name="col">필수 컬럼 예(2,3,7)</param>
        public static void required(C1FlexGrid _fx, int row, bool req, params int[] col)
        {

            for (int i = 0; i < col.Length; i++)
            {


                int noteColumn = _fx.Cols[col[i]].Index;


                CellRange rgp = _fx.GetCellRange(row, noteColumn);
                if (req)
                {
                    rgp.UserData = (object)"notes";
                }
                else
                {
                    rgp.UserData = "";
                }
            }


            CellNoteManager mgr = new CellNoteManager(_fx);

        }
        /// <summary>
        /// 그리드 컬럼에 필수입력 표시
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="row">현재 행</param>
        /// <param name="req">수정,삭제 선택 여부 선택하면 true</param>
        /// <param name="col">필수 컬럼 예("a","b")</param>
        public static void required(C1FlexGrid _fx, int row, bool req, params string[] col)
        {

            for (int i = 0; i < col.Length; i++)
            {


                int noteColumn = _fx.Cols[col[i]].Index;


                CellRange rgp = _fx.GetCellRange(row, noteColumn);
                if (req)
                {
                    rgp.UserData = (object)"notes";
                }
                else
                {
                    rgp.UserData = "";
                }
            }


            CellNoteManager mgr = new CellNoteManager(_fx);

        }
        /// <summary>
        /// 그리드 컬럼에 필수입력 표시
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="row">현재 행</param>
        /// <param name="req">수정,삭제 선택 여부 선택하면 true</param>
        public static void required(C1FlexGrid _fx, int row, bool req)
        {

            for (int i = 0; i < _fx.Cols.Count; i++)
            {


                int noteColumn = _fx.Cols[i].Index;


                CellRange rgp = _fx.GetCellRange(row, noteColumn);
                if (req)
                {
                    rgp.UserData = (object)"notes";
                }
                else
                {
                    rgp.UserData = "";
                }
            }


            CellNoteManager mgr = new CellNoteManager(_fx);

        }       /// <summary>
        /// 그리드에서 체크박스 선택했을 경우 에디터 가능 체크해제시 에디터 불가능
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="row">체크 행</param>
        /// <param name="checkcol">선택 체크 열</param>
        /// <param name="edit">에디트 여부</param>
        public static void allowediting(C1FlexGrid _fx, int row, int checkcol, bool edit)
        {

            //fx.Rows[row].AllowEditing = edit;
            if (GridHelper.GetText(_fx, row, checkcol) == "True")
            {
                edit = true;
            }
            for (int c = 2; c < _fx.Cols.Count; c++)
            {


                _fx.Cols[c].AllowEditing = edit;
            }

            _fx.Cols[1].AllowEditing = true;
        }
        /// <summary>
        /// 그리드에서 체크박스 선택했을 경우 에디터 가능 체크해제시 에디터 불가능
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="row">체크 행</param>
        /// <param name="checkcol">선택 체크 열</param>
        /// <param name="edit">에디트 여부</param>
        /// <param name="col">에디트 컬럼</param>
        public static void allowediting(C1FlexGrid _fx, int row, int checkcol, bool edit, params string[] col)
        {

            //fx.Rows[row].AllowEditing = edit;
            if (GridHelper.GetText(_fx, row, checkcol) == "True")
            {
                edit = true;
            }
            for (int c = 2; c < _fx.Cols.Count; c++)
            {
                _fx.Cols[c].AllowEditing = false;
                for (int i = 0; i < col.Length; i++)
                {
                    if (_fx.Cols[c].Name == col[i])
                    {
                        _fx.Cols[c].AllowEditing = edit;
                        break;
                    }
                }


            }

            _fx.Cols[1].AllowEditing = true;
        }        /// <summary>
        /// 체크 선택시 그리드 행 배경색 변경
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="row">행</param>
        /// <param name="chk">체크 여부</param>
        public static void setrowbackcolor(C1FlexGrid _fx, int row, bool chk)
        {
            for (int c = _fx.Cols.Fixed; c < _fx.Cols.Count; c++)
            {

                if (chk)
                {
                    _fx.SetCellStyle(row, c, _fx.Styles["chkcolor"]);
                }
                else
                {
                    _fx.SetCellStyle(row, c, _fx.Styles["unchkcolor"]);
                }

            }
        }
        /// 체크 선택시 그리드 행 배경색 변경
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="row">행</param>
        /// <param name="chk">체크 여부</param>
        /// <param name="col">col</param>
        public static void setrowbackcolor(C1FlexGrid _fx, int row, bool chk, params string[] col)
        {
            Color color = _fx.Styles.Add("chkcolor").BackColor;

            setrowbackcolor(_fx, row, chk, color, col);
        }
        /// 체크 선택시 그리드 행 배경색 변경
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="row">행</param>
        /// <param name="chk">체크 여부</param>
        /// <param name="color">color</param>
        /// <param name="col">col</param>
        public static void setrowbackcolor(C1FlexGrid _fx, int row, bool chk, Color color, params string[] col)
        {

            cschk = _fx.Styles.Add("chkcolor");
            cschk.BackColor = color;
            csunchk = _fx.Styles.Add("unchkcolor");
            csunchk.BackColor = Color.White;


            for (int c = _fx.Cols.Fixed; c < _fx.Cols.Count; c++)
            {
                for (int i = 0; i < col.Length; i++)
                {
                    if (_fx.Cols[c].Name == col[i])
                    {
                        if (chk)
                        {
                            _fx.SetCellStyle(row, c, _fx.Styles["chkcolor"]);
                        }
                        else
                        {
                            _fx.SetCellStyle(row, c, _fx.Styles["unchkcolor"]);
                        }
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 그리드 헤더에 체크박스를 클릭했을 경우  행 전체선택,해제
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="chkcol">체크박스 컬럼</param>
        public static void SetHeaderRowCheck(C1FlexGrid _fx, int chkcol)
        {
            // get current row's DataIndex (skip nodes and fixed rows)
            int current = (_fx.Row > 0) ? _fx.Rows[_fx.Row].DataIndex : -1;
            int col = _fx.Col;
            if (current > 0) return;

            if (current == 0 && col == 1)
            {
                for (int i = 1; i < _fx.Rows.Count; i++)
                {
                    SetText(_fx, i, chkcol, GetText(_fx, 0, chkcol));
                }
            }
        }
        /// <summary>
        /// 그리드 헤더에 체크박스를 클릭했을 경우 선택 열 선택,해제
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="chkcol">체크박스 컬럼</param>
        public static void SetHeaderColCheck(C1FlexGrid _fx, int chkcol, params int[] cols)
        {
            // get current row's DataIndex (skip nodes and fixed rows)
            int current = (_fx.Row > 0) ? _fx.Rows[_fx.Row].DataIndex : -1;
            int col = _fx.Col;
            // not a data row?
            if (current < 0)
            {

                return;
            }
            current = current + 1;
            if (current > 0 && col == chkcol)
            {
                for (int i = 0; i < cols.Length; i++)
                {

                    SetText(_fx, current, cols[i], GetText(_fx, current, chkcol));
                }
            }
        }

        public static void SetButtonImage(C1FlexGrid _fx, int row, ButtonImage bi, params int[] cols)
        {
            for (int i = 0; i < cols.Length; i++)
            {

                if (bi == ButtonImage.glasses)
                    _fx.SetCellImage(row, cols[i], NEXCORE.Common.Properties.Resources.glasses20);
                else if (bi == ButtonImage.delete)
                    _fx.SetCellImage(row, cols[i], NEXCORE.Common.Properties.Resources.X20);


            }

            for (int r = 1; r < _fx.Rows.Count; r++)
            {
                for (int i = 0; i < cols.Length; i++)
                {
                    if (_fx.GetData(r, 1).ToString() == "False")
                    {
                        _fx.SetCellImage(r, cols[i], null);
                        //_fx.Select(r, 1);
                    }
                }
            }





        }


        /// <summary>
        /// 현재행정보를저장합니다. 
        /// </summary>
        /// <param name="_fx"></param>
        /// <returns></returns>
        public static DataRow SaveGridRow(C1FlexGrid _fx)
        {
            try
            {
                DataTable dt = (DataTable)_fx.DataSource;



                if (dt != null && dt.Rows.Count > 0
                    && _fx.Row - _fx.Rows.Fixed < dt.Rows.Count
                    && _fx.Row >= _fx.Rows.Fixed)
                {
                    DataRow dr = dt.Rows[_fx.Row - _fx.Rows.Fixed];
                    return dr;
                }
                else
                {
                    DataRow dr = null;
                    return dr;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 일치하는행을현재행으로설정합니다.
        /// </summary>
        /// <param name="_fx">그리드</param>
        /// <param name="currRow">SaveGridRow의반환값임(현재행)</param>
        /// <param name="KeyColNames">키값컬럼명배열</param>
        /// <returns></returns>
        public static int SelectGridRow(C1FlexGrid _fx,
                                        DataRow currRow,
                                        string[] KeyColNames)
        {
            try
            {

                int RetRowIdx = -1;

                DataTable dt = ((DataTable)_fx.DataSource).Copy();


                if (currRow != null)
                {


                    RetRowIdx = GetRowIdx(dt, currRow, KeyColNames) + _fx.Rows.Fixed;

                }
                else
                {

                }


                if (RetRowIdx <= _fx.Rows.Fixed) RetRowIdx = _fx.Rows.Fixed;

                if (RetRowIdx < dt.Rows.Count + _fx.Rows.Fixed)
                {
                    _fx.Row = RetRowIdx;
                }
                return RetRowIdx;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetRowIdx(DataTable dt, DataRow currRow, string[] KeyColNames)
        {
            bool equal = false;
            int ret = 0;
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int i = 0; i < KeyColNames.Length; i++)
                {
                    equal = false;
                    if (dt.Rows[r][KeyColNames[i]].ToString() == currRow[KeyColNames[i]].ToString())
                    {
                        equal = true;
                    }
                }

                if (equal)
                {
                    ret = r;
                    break;
                }
            }
            return ret;
        }
        /// <summary>
        /// 현재행정보를저장합니다. 
        /// </summary>
        /// <param name="c1fg"></param>
        /// <returns></returns>
        //public static DataRow SaveGridRow(C1FlexGrid _fx)
        //{
        //    try
        //    {
        //        DataTable dt = _fx.DataSource as DataTable;
        //        DataRow dr = null;

        //        if (dt != null)
        //        {
        //            foreach (DataRow row in dt.Rows)
        //            {
        //                if (row.RowState != DataRowState.Unchanged)
        //                {
        //                    dr = row;
        //                    break;
        //                }
        //            }
        //        }

        //        return dr;


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static void SetGrid(C1FlexGrid _fx, DataTable dt)
        {
            // --frozen  행단위 틀고정    (col, row, both)
            //--col-width   컬럼단위 폭   (15, 15%) --고정치, 상대치
            //--col-align   컬럼단위 정렬       (center, left, right)
            //--rowmerge_id   세로병합        (0, 1, 2...) --병합순서
            //--col-fontsize    컬럼단위 폰트사이즈
            //--col-type    컬럼단위 셀타입 (checkbox, combobox, button) 버튼과 콤보박스의 경우 body커서의 데이터가 text로 보여진다.

            //--공통사항 
            //--'@@'로 시작되는 컬럼은 숨김 속성을 갖는다.
            //--header커서의 컬럼과 body커서의 컬럼 숫자가 다른 경우 에러를 낸다.
            //--header 이름은 header커서의 별칭을 사용하지만 컬럼이름은 body커서의 별칭을 사용한다.
            //--body커서와 그리드뷰는 body커서의 컬럼 인덱스 순서대로 바인딩 시킨다.
            //--헤더명은 이름이 같을 경우 자동 병합한다. (가로, 세로)
            //--그리드뷰 컬럼의 기본 width값은 body커서의 첫번째 행의 데이터 길이 비율대로 설정한다. (기본비율 설정 -> tag 적용) 

            //OPEN R_HEADER FOR
            //SELECT '<TAG COL-WIDTH=10% /TAG>H_SERIALKEY', '<TAG ROWMERGE_ID=0 /TAG>H_WHSEID', '<TAG ROWMERGE_ID=1 /TAG>H_SUSR2', '<TAG ROWMERGE_ID=2 /TAG>H_MANUFACTURERSKU', 'H_SUSR3', '<TAG FROZEN=COL, COL-WIDTH=20%, COL-ALIGN=CENTER, COL_FONTSIZE=10, COL_TYPE = COMBOBOX /TAG>H_SKUGROUP', 'H_DESCR', 'H_SUSR1', 'H_STDNETWGT', 'H_SUSR9' FROM DUAL
            //UNION ALL
            //SELECT 'H_SERIALKEY', 'H_WHSEID', 'H_SUSR2', 'H_MANUFACTURERSKU', 'H_SUSR3', 'H_SKUGROUP', 'H_DESCR', 'H_SUSR1', 'H_STDNETWGT', 'H_SUSR9' FROM DUAL
            //UNION ALL
            //SELECT 'H_SERIALKEY', 'H_WHSEID', 'H_SUSR2', 'H_MANUFACTURERSKU', 'H_SUSR3', 'H_SKUGROUP', 'H_DESCR', 'H_SUSR1', 'H_STDNETWGT', 'H_SUSR9' FROM DUAL;
        }
        private static System.Collections.Hashtable GetColumnTag(string sTag)
        {
            sTag = sTag.Replace("<TAG", "").Replace("/TAG>", "");
            string[] sTags = sTag.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            System.Collections.Hashtable hs = new System.Collections.Hashtable();

            for (int i = 0; i < sTags.Length; i++)
            {
                string[] temps = sTags[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                hs.Add(temps[0].Trim(), temps[1].Trim());
            }

            return hs;
        }
        public static void SetGridHeader(C1.Win.C1FlexGrid.C1FlexGrid _fx, DataTable dsHeader)
        {

            DataRow dr = dsHeader.Rows[0];
            DataTable dt = new DataTable();
            bool visible = true;
            Int32 colwidth = 100;
            Int32 colfrozen = 0;
            TextAlignEnum tae = new TextAlignEnum();


            GridHelper.DefaultGrid(_fx, false);


            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                string sValue = dr.ItemArray[i].ToString().ToUpper();
                colwidth = 100;
                tae = TextAlignEnum.LeftCenter;

                if (sValue.IndexOf("<TAG") > -1)
                {
                    string sTag = sValue.Substring(sValue.IndexOf("<TAG"), sValue.LastIndexOf("/TAG>"));
                    string sHeaderText = sValue.Substring(sValue.LastIndexOf("/TAG>") + ("/TAG>").Length);

                    System.Collections.Hashtable hs = GetColumnTag(sTag);

                    foreach (System.Collections.DictionaryEntry d in hs)
                    {
                        switch (d.Key.ToString())
                        {
                            case "COL-WIDTH":
                                if (d.Value.ToString().IndexOf(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.PercentSymbol) > -1)
                                {
                                    string sSizePercentage = d.Value.ToString().Replace(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.PercentSymbol, "");
                                    float fSize = (float)(Convert.ToDouble(sSizePercentage) / 100);
                                    colwidth = Convert.ToInt32(_fx.Width * fSize);
                                }
                                else
                                    colwidth = Convert.ToInt32(d.Value);
                                break;
                            case "COL-ALIGN":
                                switch (d.Value.ToString())
                                {
                                    case "CENTER":
                                        tae = TextAlignEnum.CenterCenter;
                                        break;
                                    case "LEFT":
                                        tae = TextAlignEnum.LeftCenter;
                                        break;
                                    case "RIGHT":
                                        tae = TextAlignEnum.RightCenter;
                                        break;
                                    default:
                                        tae = TextAlignEnum.LeftCenter;
                                        break;
                                }

                                break;
                            default:
                                break;
                        }
                    }

                    if (hs.ContainsKey("FROZEN"))
                    {
                        if ((string)hs["FROZEN"] == "COL")
                        {
                            colfrozen = i + 1;
                        }
                    }

                    if (hs.ContainsKey("COL-TYPE"))
                    {
                        if ((string)hs["COL-TYPE"] == "CHECKBOX")
                        {
                            InitColumnCheckBox(_fx, sHeaderText, sHeaderText, colwidth);

                        }
                        else if (((string)hs["COL-TYPE"]) == "COMBOBOX")
                        {
                            InitColumnCombo(_fx, sHeaderText, sHeaderText, colwidth, dt, "", "");
                        }
                    }
                    else
                    {
                        if (sHeaderText.IndexOf("@@") >= 0) visible = false;
                        InitColumn(_fx, sHeaderText, sHeaderText, colwidth, false, visible, false, tae);
                    }



                }
                else
                {
                    if (sValue.IndexOf("@@") >= 0) visible = false;

                    
                    InitColumn(_fx, sValue, sValue, 100, false, visible, false, TextAlignEnum.LeftCenter);

                }
            }

            //멀티 헤더 설정
            if (dsHeader.Rows.Count > 1)
            {
                for (int i = 1; i < dsHeader.Rows.Count; i++)
                {
                    for (int j = 0; j < dsHeader.Columns.Count; j++)
                    {
                        string colname = dsHeader.Rows[i][j].ToString();
                        SetMultiHeader(_fx, dsHeader.Rows.Count, i, 1, j + 1, 1, colname);
                    }

                }

            }
            //컬럼 고정
            _fx.Cols.Frozen = colfrozen;
        }

        public static void SetGridHeader(C1.Win.C1FlexGrid.C1FlexGrid _fx, DataSet dsHeader)
        {

            DataRow dr = dsHeader.Tables[0].Rows[0];
            // Column Property
            DataTable Tbl = dsHeader.Tables[1];
            

            if (dr.ItemArray.Length != Tbl.Columns.Count)
            {
                CommonHelper.CallMsgPopUp("오류", "헤더와 컬럼의 길이가 맞지 않습니다.", "", "1", "");
                return;
            }
            DataTable dt = new DataTable();
            bool visible = true;
            Int32 colwidth = 100;
            Int32 colfrozen = 0;
            TextAlignEnum tae = new TextAlignEnum();


            GridHelper.DefaultGrid(_fx, false);


            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                string sValue = dr.ItemArray[i].ToString().ToUpper();
                colwidth = 100;
                tae = TextAlignEnum.LeftCenter;

                if (sValue.IndexOf("<TAG") > -1)
                {
                    string sTag = sValue.Substring(sValue.IndexOf("<TAG"), sValue.LastIndexOf("/TAG>"));
                    string sHeaderText = sValue.Substring(sValue.LastIndexOf("/TAG>") + ("/TAG>").Length);

                    System.Collections.Hashtable hs = GetColumnTag(sTag);

                    foreach (System.Collections.DictionaryEntry d in hs)
                    {
                        switch (d.Key.ToString())
                        {
                            case "COL-WIDTH":
                                if (d.Value.ToString().IndexOf(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.PercentSymbol) > -1)
                                {
                                    string sSizePercentage = d.Value.ToString().Replace(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.PercentSymbol, "");
                                    float fSize = (float)(Convert.ToDouble(sSizePercentage) / 100);
                                    colwidth = Convert.ToInt32(_fx.Width * fSize);
                                }
                                else
                                    colwidth = Convert.ToInt32(d.Value);
                                break;
                            case "COL-ALIGN":
                                switch (d.Value.ToString())
                                {
                                    case "CENTER":
                                        tae = TextAlignEnum.CenterCenter;
                                        break;
                                    case "LEFT":
                                        tae = TextAlignEnum.LeftCenter;
                                        break;
                                    case "RIGHT":
                                        tae = TextAlignEnum.RightCenter;
                                        break;
                                    default:
                                        tae = TextAlignEnum.LeftCenter;
                                        break;
                                }

                                break;
                            default:
                                break;
                        }
                    }

                    if (hs.ContainsKey("FROZEN"))
                    {
                        if ((string)hs["FROZEN"] == "COL")
                        {
                            colfrozen = i + 1;
                        }
                    }

                    if (hs.ContainsKey("COL-TYPE"))
                    {
                        if ((string)hs["COL-TYPE"] == "CHECKBOX")
                        {
                            InitColumnCheckBox(_fx, Tbl.Columns[i].ColumnName, sHeaderText, colwidth);

                        }
                        else if (((string)hs["COL-TYPE"]) == "COMBOBOX")
                        {
                            InitColumnCombo(_fx, Tbl.Columns[i].ColumnName, sHeaderText, colwidth, dt, "", "");
                        }
                    }
                    else
                    {
                        if (sHeaderText.IndexOf("@@") >= 0) visible = false;
                        InitColumn(_fx, Tbl.Columns[i].ColumnName, sHeaderText, colwidth, false, visible, true, tae);
                    }



                }
                else
                {
                    if (sValue.IndexOf("@@") >= 0) visible = false;


                    InitColumn(_fx, Tbl.Columns[i].ColumnName, sValue, 100, false, visible, true, TextAlignEnum.LeftCenter);

                }
            }

            //멀티 헤더 설정
            if (dsHeader.Tables[0].Rows.Count > 1)
            {
                for (int i = 1; i < dsHeader.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < dsHeader.Tables[0].Columns.Count; j++)
                    {
                        string colname = dsHeader.Tables[0].Rows[i][j].ToString();
                        SetMultiHeader(_fx, dsHeader.Tables[0].Rows.Count, i, 1, j + 1, 1, colname);
                    }

                }

            }
            //컬럼 고정
            _fx.Cols.Frozen = colfrozen;
        }
    }

    #region ** UITypeEditorControl (base class for all of the controls below)

    /// <summary>
    /// UITypeEditorControl
    /// </summary>
    public class UITypeEditorControl :
        ComboBox,
        IServiceProvider,
        IWindowsFormsEditorService
    {
        //===========================================================================
        #region ** fields
        private UITypeEditor _editor;	// UITypeEditor responsible for editing the values
        private Form _form;		// form used to show the drop down
        private Rectangle _bounds;	// cell bounds (used to position control and form)
        private object _value;		// current editor value 
        private bool _dropped;	// whether the drop down was displayed
        private bool _allowTyping;	// whether to allow user to edit the string representation of the value
        #endregion

        //===========================================================================
        #region ** ctor

        public UITypeEditorControl(UITypeEditor editor, bool allowTyping)
        {
            // save ctor parameters
            _editor = editor;
            _allowTyping = allowTyping;

            // initialize combo
            DropDownStyle = ComboBoxStyle.DropDown;
            DrawMode = DrawMode.OwnerDrawFixed;

            // initialize drop down editor
            _form = new Form();
            _form.StartPosition = FormStartPosition.Manual;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.ShowInTaskbar = false;
            _form.TopLevel = true;
            _form.Deactivate += new EventHandler(_form_Deactivate);
        }
        #endregion

        //===========================================================================
        #region ** IC1EmbeddedEditor

        public void C1EditorInitialize(object value, IDictionary attributes)
        {
            // initialize editor value
            _value = value;
            if (value != null)
            {
                TypeConverter tc = TypeDescriptor.GetConverter(value.GetType());
                try
                {
                    Text = (string)tc.ConvertToString(value);
                }
                catch
                {
                    Text = string.Empty;
                }
            }

            // initialize editor style
            Font = (Font)attributes["Font"];
            BackColor = (Color)attributes["BackColor"];
            ForeColor = (Color)attributes["ForeColor"];

            // we haven't dropped the editor yet
            _dropped = false;
        }
        public object C1EditorGetValue()
        {
            // return value from drop down or from edit area
            return (_dropped) ? _value : Text;
        }
        public UITypeEditorEditStyle C1EditorGetStyle()
        {
            return _editor.GetEditStyle();
        }
        public void C1EditorUpdateBounds(Rectangle rc)
        {
            // store bounds, will apply when showing the form
            _bounds = Parent.RectangleToScreen(rc);

            // if the user can type, position the combo
            if (_allowTyping)
            {
                rc.Inflate(2, 2);
                ItemHeight = Math.Max(3, rc.Height - 6);
                Bounds = rc;
            }
            else // can't type, so hide the control
            {
                Bounds = Rectangle.Empty;
            }
        }

        #endregion

        //===========================================================================
        #region ** overrides

        // if the user can't type, show drop down right away
        override protected void OnEnter(EventArgs e)
        {
            if (!_allowTyping)
                DoDropDown();
        }

        // if the user can type, show drop down when requested
        override protected void OnDropDown(EventArgs e)
        {
            if (_allowTyping)
                DoDropDown();
        }

        // suppress OnLeave event until we're done editing
        override protected void OnLeave(EventArgs e)
        {
            // if we dropped down, wait until we're done editing
            if (_dropped)
                return;

            // we didn't drop down, allow default processing
            base.OnLeave(e);
        }

        // this is done only to avoid annoying beeps from the ComboBox
        override public bool PreProcessMessage(ref Message msg)
        {
            switch (msg.Msg)
            {
                case 0x100: // WM_KEYDOWN:

                    // digest key that was pressed
                    KeyEventArgs e = new KeyEventArgs((Keys)(int)msg.WParam);

                    // if it was a tab or enter, handle internally but don't pass
                    // to stupid base class to avoid annoying beeps.
                    switch (e.KeyCode)
                    {
                        case Keys.Tab:
                        case Keys.Enter:
                        case Keys.Escape:
                            OnKeyDown(e);
                            return true;
                    }
                    break;
            }

            // allow regular processing
            return false;
        }
        #endregion

        //===========================================================================
        #region ** private members

        private void DoDropDown()
        {
            // fire event as usual
            base.OnDropDown(EventArgs.Empty);

            // if this is a popup, hide editing area
            if (_editor.GetEditStyle() == UITypeEditorEditStyle.Modal)
                Bounds = System.Drawing.Rectangle.Empty;

            // show editor and get the new value
            _dropped = true;
            _value = _editor.EditValue((IServiceProvider)this, _value);

            // force the drop down to close
            DrawMode = DrawMode.Normal;
            DrawMode = DrawMode.OwnerDrawFixed;
            DroppedDown = false;
            Capture = false;

            // fire OnLeave so grid knows we're done
            base.OnLeave(EventArgs.Empty);
        }

        #endregion

        //===========================================================================
        #region ** event handlers

        // close drop down when form deactivated
        private void _form_Deactivate(object sender, EventArgs e)
        {
            ((IWindowsFormsEditorService)this).CloseDropDown();
        }

        #endregion

        //===========================================================================
        #region ** IServiceProvider interface

        object IServiceProvider.GetService(Type serviceType)
        {
            if (serviceType == typeof(IWindowsFormsEditorService))
                return (IWindowsFormsEditorService)this;
            return null;
        }

        #endregion

        //===========================================================================
        #region ** IWindowsFormsEditorService interface

        void IWindowsFormsEditorService.DropDownControl(Control control)
        {
            // size form
            _form.ClientSize = control.Size;

            // calculate form location to avoid being off the screen
            Point pt = new Point(_bounds.Right - control.Width, _bounds.Bottom);
            Rectangle rc = Screen.GetWorkingArea(this);
            if (_bounds.Bottom + control.Height > rc.Bottom)	// check bottom
                pt.Y = _bounds.Top - _form.Height;
            if (pt.Y < 0) pt.Y = 0;					// check top
            if (_bounds.X + control.Width > rc.Right)		// check right
                pt.X = rc.Right - _form.Width;
            if (pt.X < 0) pt.X = 0;					// check left

            // position form
            _form.Location = pt;

            // add control to form and show it
            _form.Controls.Add(control);
            _form.Show();

            // readjust form size (seems redundant, but isn't...)
            _form.ClientSize = control.Size;

            // wait until user makes a selection
            while (control.Visible)
            {
                Application.DoEvents();
                MsgWaitForMultipleObjects(1, IntPtr.Zero, 0, 5, 255);
            }

            // done
            _form.Hide();
            _form.Controls.Clear();
        }
        void IWindowsFormsEditorService.CloseDropDown()
        {
            _form.Hide();
        }
        DialogResult IWindowsFormsEditorService.ShowDialog(Form dialog)
        {
            // support modal editors
            return dialog.ShowDialog();
        }

        #endregion

        //===========================================================================
        #region ** dll imports

        [System.Runtime.InteropServices.DllImport("User32")]
        private static extern int MsgWaitForMultipleObjects(
            int nCount, IntPtr pHandles, short bWaitAll, int dwMilliseconds, int dwWakeMask);

        #endregion
    }
    #endregion

    #region ** CheckListEditor
    //
    // CheckListEditor
    // UITypeEditor that can be used to edit items in CheckedListBox control.
    // Users can check any combination.
    // 
    public class CheckListEditor : UITypeEditor
    {
        // ** fields
        private IWindowsFormsEditorService _edSvc;
        private CheckedListBox _list;
        private string[] _items;
        private bool _cancel;

        // ** ctor
        public CheckListEditor(string[] items)
        {
            // store reference to items being edited
            _items = items;

            // build selector list
            _list = new CheckedListBox();
            _list.BorderStyle = BorderStyle.Fixed3D;
            _list.CheckOnClick = true;
            _list.ThreeDCheckBoxes = false;
            _list.KeyPress += new KeyPressEventHandler(_list_KeyPress);
        }

        // ** overrides
        override public UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext ctx)
        {
            return UITypeEditorEditStyle.DropDown;
        }
        override public object EditValue(ITypeDescriptorContext ctx, IServiceProvider provider, object value)
        {
            // initialize editor service
            _edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (_edSvc == null)
                return value;

            // null means no flags are checked
            if (value == null)
                value = 0;

            // populate the list
            _list.Items.Clear();
            string items = value.ToString();
            foreach (string item in _items)
            {
                // add this item with the proper check state
                CheckState check = items.Contains(item) ? CheckState.Checked : CheckState.Unchecked;
                _list.Items.Add(item, check);
            }
            _list.Height = Math.Min(300, (_list.Items.Count + 1) * _list.Font.Height);
            _list.Width = 150;

            // show the list
            _cancel = false;
            _edSvc.DropDownControl(_list);

            // build return value from checked items on the list
            if (!_cancel)
            {
                // build a comma-delimited string with the checked items
                StringBuilder sb = new StringBuilder();
                foreach (object item in _list.CheckedItems)
                {
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append(item.ToString());
                }

                // convert empty string
                return (sb.Length > 0) ? sb.ToString() : "";
            }

            // done
            return value;
        }

        // ** event handlers

        // close editor if the user presses enter or escape
        private void _list_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)27:
                    _cancel = true;
                    _edSvc.CloseDropDown();
                    break;
                case (char)13:
                    _edSvc.CloseDropDown();
                    break;
            }
        }
    }
    #endregion


 
}
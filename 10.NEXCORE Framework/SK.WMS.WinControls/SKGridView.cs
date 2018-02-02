using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Common.Data;
using System.Drawing.Drawing2D;
using NEXCORE.Interfaces;
using C1.Win.C1FlexGrid;
using System.Collections;


namespace SK.WMS.WinControls
{
    public partial class SKGridView :  C1FlexGrid
    {
        private Hashtable _hash;
        /// <summary>
        /// 수정한 항목일 경우 배경색
        /// </summary>
        public Color EditColor = Color.Plum;


        #region 이벤트 관련
        public delegate void SKRowColEventHandler(object sender, RowColEventArgs e, SKExtendEventArgs ex);
        public new event SKRowColEventHandler AfterEdit;

        public new event RowColEventHandler BeforeEdit;

        /// <summary>
        /// 확장 Event Arguments. 변경전 데이터, 변경 후 데이터, 변경 여부를 담는다.
        /// </summary>
        public class SKExtendEventArgs : EventArgs
        {
            private object _beforeData;

            /// <summary>
            /// 변경 전 데이터 (ReadOnly)
            /// </summary>
            public object BeforeData
            {
                get
                {
                    return _beforeData;
                }
            }

            private bool _Change;

            /// <summary>
            /// 변경 여부 (ReadOnly)
            /// </summary>
            public bool Change
            {
                get
                {
                    return _Change;
                }
            }

            private object _afterData;

            /// <summary>
            /// 변경된 데이터
            /// </summary>
            public object AfterData
            {
                get
                {
                    return _afterData;
                }
            }

            public SKExtendEventArgs(object beforeData, object AfterData, bool change)
            {
                _afterData = AfterData;
                _beforeData = beforeData;
                _Change = change;
            }
        }
        #endregion

        public SKGridView()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = Color.White;
            this.ForeColor = DefaultForeColor;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);

            this.AutoClipboard = true;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.ColumnInfo = "3,1,0,0,0,100,Columns:";
            this.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.Location = new System.Drawing.Point(2, 138);
            this.Rows.Count = 1;
            this.Rows.DefaultSize = 20;
            this.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.ShowCellLabels = true;

            this._hash = new Hashtable();
        }

        #region 이벤트처리
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        /// <summary>
        /// 수정 전 처리
        /// </summary>
        /// <param name="e"></param>
        protected override void OnBeforeEdit(RowColEventArgs e)
        {
            base.OnBeforeEdit(e);
            Point pt = new Point(e.Row, e.Col);

            if (!_hash.ContainsKey(pt))
            {
                _hash.Add(pt, this[e.Row, e.Col]);
            }

            if (BeforeEdit != null)
            {
                BeforeEdit(this, e);
            }
        }

        /// <summary>
        /// 수정 후 처리
        /// </summary>
        /// <param name="e"></param>
        protected override void OnAfterEdit(RowColEventArgs e)
        {
            base.OnAfterEdit(e);

            SKExtendEventArgs ex = null;

            object BeforeData = _hash[new Point(e.Row, e.Col)];

            if (BeforeData != null)
            {
                bool bChange = isDiff(this[e.Row, e.Col], BeforeData);
                
                CellRange cr = GetCellRange(e.Row, e.Col);

                cr.StyleNew.BackColor = bChange ? EditColor : this.Styles[CellStyleEnum.Normal].BackColor;
                
                ex = new SKExtendEventArgs(BeforeData, this[e.Row, e.Col], bChange);

                if (AfterEdit != null)
                {
                    AfterEdit(this, e, ex);
                }
            }
        }
        #endregion

        #region 메소드
        private bool isDiff(object a, object b)
        {
            if (a != null && b != null)
            {
                switch (a.GetType().Name.ToUpper())
                {
                    case "INTEGER":
                    case "INT32":
                        return Convert.ToInt32(a) != Convert.ToInt32(b);
                    case "LONG":
                    case "INT64":
                        return Convert.ToInt64(a) != Convert.ToInt64(b);
                    case "DATETIME":
                        return Convert.ToDateTime(a) != Convert.ToDateTime(b);
                    case "DOUBLE":
                    case "FLOAT":
                        return Convert.ToDouble(a) != Convert.ToDouble(b);
                    default:
                        return Convert.ToString(a) != Convert.ToString(b);
                }
            }

            return false;
        }

        public void EnableEdit(bool bEnable)
        {
            for (int i = 0; i < this.Cols.Count; i++)
            {
                this.Cols[i].AllowEditing = bEnable;
            }

            EnableEdit();
        }

        public void EnableEdit(bool bEnable, int[] iArr)
        {
            foreach (int i in iArr)
            {
                this.Cols[i].AllowEditing = bEnable;
            }

            EnableEdit();
        }

        public void EnableEdit(bool bEnable, string[] sArr)
        {
            foreach (string s in sArr)
            {
                this.Cols[s].AllowEditing = bEnable;
            }

            EnableEdit();
        }

        private void EnableEdit()
        {
            bool bEnable = false;

            for (int i = 0; i < this.Cols.Count; i++)
            {
                if (this.Cols[i].AllowEditing)
                {
                    bEnable = true;
                }
            }

            this.AllowEditing = bEnable;
        }
        #endregion
    }
}

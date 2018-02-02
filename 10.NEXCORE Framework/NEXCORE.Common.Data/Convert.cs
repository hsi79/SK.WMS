using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace NEXCORE.Common.Data
{
    public class SKConvert
    {
        public static DateTime? GetDateTime(object o)
        {
            if (o == null) return null;

            if (string.IsNullOrEmpty(o.ToString())) return null;

            try
            {
                DateTime time = DateTime.Parse(o.ToString());

                return (DateTime?)time;
            }
            catch
            {
            }
            return null;
        }

        public static Int32 GetInt(object o)
        {
            if (o == null) return Convert.ToInt32(null);

            try
            {
                string strTemp = (string)o;

                if (string.IsNullOrEmpty(strTemp))
                    return Convert.ToInt32(null);

            }
            catch { }

            try
            {
                return Convert.ToInt32(o);
            }
            catch { }

            return Convert.ToInt32(null);

        }

        public static DataTable AddAllRow(int ValueMember, int DisplayMember, DataTable comboData)
        {

            DataTable dt = new DataTable();
            DataRow row;

            dt = comboData.Clone();

            int colCnt = dt.Columns.Count;

            row = dt.NewRow();
            row[ValueMember] = string.Empty;
            row[DisplayMember] = string.Empty;
            row["설명"] = "전체";

            //for (int i = 0; i < colCnt; i++)
            //{
            //    if (i != ValueMember && i != DisplayMember)
            //    {
            //        row[i] = string.Empty;
            //    }
            //}
            dt.Rows.Add(row);

            foreach (DataRow rw in comboData.Rows)
            {
                dt.ImportRow(rw);
            }
            return dt;
        }

        public static DataTable AddAllRow(int ValueMember, int DisplayMember, string defaultWord, DataTable comboData)
        {

            DataTable dt = new DataTable();
            DataRow row;

            dt = comboData.Clone();

            int colCnt = dt.Columns.Count;

            row = dt.NewRow();
            row[ValueMember] = string.Empty;
            row[DisplayMember] = defaultWord;

            //for (int i = 0; i < colCnt; i++)
            //{
            //    if (i != ValueMember && i != DisplayMember)
            //    {
            //        row[i] = string.Empty;
            //    }
            //}
            dt.Rows.Add(row);

            foreach (DataRow rw in comboData.Rows)
            {
                dt.ImportRow(rw);
            }
            return dt;
        }
    }
}

using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Web;

namespace NEXCORE.Common
{
    public static class TimerHelper
    {
        #region Session Timer

        private static DateTime lastAccessTime;

        public static DateTime LastAccessTime
        {
            get { return lastAccessTime; }
            set { lastAccessTime = value; }
        }

        #endregion

    }
}
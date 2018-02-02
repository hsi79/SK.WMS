using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public class BroadCastEventArgs
    {
        /// <summary>
        /// 이벤트를 받을 대상 (PGMID)
        /// </summary>
        public string EventTarget { get; set; }

        /// <summary>
        /// 이벤트를 보내는 소스 (PGMID)
        /// </summary>
        public string EventSoruce { get; set; }


        public NEXCOREData DataObject { get; set; }


        public string MessageName { get; set; }

    }
}

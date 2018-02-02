using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Data;
using System.Collections;

namespace NEXCORE.Common.Data
{
    [Serializable]
    [DataContract]
    public class NEXCOREData
    {
        public NEXCOREData()
        { }

        public NEXCOREData(string dataTableName)
        {
            this.DataTable.TableName = dataTableName;
        }

        [DataMember]
        public string Name;

        [DataMember]
        public int intCnt;

        [DataMember]
        public DataSet DataSet;

        [DataMember]
        public Hashtable Hashtable = new Hashtable();

        [DataMember]
        public string MethodName;

        [DataMember]
        public object Object;

        [DataMember]
        public DataTable DataTable;
    }
}
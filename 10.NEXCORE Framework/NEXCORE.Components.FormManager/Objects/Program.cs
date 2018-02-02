using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;

namespace NEXCORE.Components.FormManager
{
    public class Program : IProgram
    {

        #region Member Variables
        private string _path = String.Empty;
        private string _name = String.Empty;
        private string _type = String.Empty;
        private string _description = string.Empty;
        private string _id = String.Empty;

        #endregion
        #region IProgram Members

        public string Path
        {
            get { return _path; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Type
        {
            get { return _type; }
        }

        public string Description
        {
            get { return _description; }
        }

        public string Id
        {
            get { return _id; }
        }

        public void Initilize(System.Collections.Hashtable properties)
        {
            _id = (string)properties["ID"];
            _path = (string)properties["PATH"];
            _name = (string)properties["NAME"];
            _type = (string)properties["TYPE"];
            _description = (string)properties["DESCRIPTION"];

        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NEXCORE.Interfaces
{
    public interface IFormManager : IManager
    {

        void Init();

        object GetForm(string formName);

        bool Show(string pgmId, Form parentForm);


        DialogResult ShowPopup(string pgmId, Form parentForm);

        
        
        bool ReLoad();

    }
}

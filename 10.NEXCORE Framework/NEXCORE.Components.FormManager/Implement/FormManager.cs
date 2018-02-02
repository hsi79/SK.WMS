using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using System.Reflection;
using System.Windows.Forms;

namespace NEXCORE.Components.FormManager
{
    public class FormManager : IFormManager
    {
        #region Member Properties & Variables
        /// <summary>
        /// Setter Injection
        /// </summary>
        private IFormRepository _formRepository = null;
        #endregion

        #region IFormManager Members

        public void Init()
        {
            if (_formRepository != null)
                _formRepository.LoadForm();
        }

        public object GetForm(string formName)
        {
            IProgram pgm = _formRepository.GetProgram(formName);

            Assembly asm = Assembly.LoadFrom(pgm.Path);

            return asm.CreateInstance(pgm.Name);
        }

        public bool Show(string pgmId, System.Windows.Forms.Form parentForm)
        {
            System.Windows.Forms.Form form = GetFormByPgmId(pgmId);

            form.MdiParent = parentForm;
            
            form.Show();

            return true;
        }

        public DialogResult ShowPopup(string pgmId, System.Windows.Forms.Form parentForm)
        {
            throw new NotImplementedException();
        }

        public bool ReLoad()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Inner Function
        public Form GetFormByPgmId(string pgmId)
        {
            IProgram pgm = _formRepository.GetProgram(pgmId);

            Assembly asm = Assembly.LoadFrom(pgm.Path);

            return (Form)asm.CreateInstance(pgm.Name);

        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Skcc.Security;
using Skcc.Windows.Forms;
using System.Collections;

using NEXCORE.Interfaces;

namespace NEXCORE.Common
{
    public partial class SKFormBase : FormBase
    {

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
        
        /////////////////////////////////////////////////////////////////////////////////////////////////

        private UserInfoContext _userInfoCtx = null;

        public UserInfoContext UserInfoCtx
        {
            get { return _userInfoCtx; }
            set { _userInfoCtx = value; }
        }

        public SKFormBase()
        {
            //RequireAuthentication = false;
            _userInfoCtx = UserInfoContext.GetUserInfoContext();
            if (_userInfoCtx != null)
            {
                SetUserInfoContext(_userInfoCtx);
                //_userID = UserData.UserID;
                //_userCode = UserData.UserCode;
                //_userCmpn = UserData.UserCmpn;
                //_userSKCC = UserData.UserSKCC;
            }

            InitializeComponent();
            SetSecurityContext(new SecurityContext(true, true, true, true));

            
            
        }

        private void SMGFormBase_Load(object sender, EventArgs e)
        {

        }

    }
}
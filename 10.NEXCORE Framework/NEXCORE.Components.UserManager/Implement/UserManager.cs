using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;

using Skcc.Configuration;
using System.Security.Cryptography;
using System.IO;

namespace NEXCORE.Components.UserManager
{
    public class UserManager : IUserManager
    {
        #region 멤버 변수
        /// <summary>
        /// Setter Injection
        /// </summary>
        private UserRepository _userRepository = new UserRepository();
        #endregion

        #region IUserManager 멤버

        public void Init()
        {
            //_userRepository.LoadWMSUsers();
        }
        
        public LOGIN_RESULT_CODE Login(string userId, string password)
        {
            //IList<User> userList = _userRepository.GetUsers();
            IList<User> userList = _userRepository.LoadWMSLoginUser(userId.ToLower());

            string encryptPassword = NEXCORE.Utility.UtilityHelper.Encrypt(password);
            var user = from u in userList
                       where u.UserId.ToLower() == userId.ToLower() && u.Password == encryptPassword
                       select u;

            //TODO : Check Logic 필요

            ////////////////////////////
            if (user.Count<User>() == 0)
            {

                return LOGIN_RESULT_CODE.FAIL;                
            }
            if (user.First<User>().IsLock == "Y")
            {
                return LOGIN_RESULT_CODE.ID_LOCKED;
            }
            
            return LOGIN_RESULT_CODE.SUCCESS;
        }

        public static string Encrypt(string plainText)
        {
            string password = SkccFxConfigManager.GetString("EncryptKey");
            RijndaelManaged managed = new RijndaelManaged();
            byte[] buffer = Encoding.Unicode.GetBytes(plainText);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(password.Length.ToString());
            PasswordDeriveBytes bytes = new PasswordDeriveBytes(password, rgbSalt);
            ICryptoTransform transform = managed.CreateEncryptor(bytes.GetBytes(0x20), bytes.GetBytes(0x10));
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
            stream2.Write(buffer, 0, buffer.Length);
            stream2.FlushFinalBlock();
            byte[] inArray = stream.ToArray();
            stream.Close();
            stream2.Close();
            return Convert.ToBase64String(inArray);
        }

        public User GetUser(string userId)
        {
            _userRepository.LoadWMSUser(userId);
            IList<User> userList = _userRepository.GetUsers();

            var user = from u in userList
                       where u.UserId.ToLower() == userId.ToLower()
                       select u;            

            return user.First<User>();
        }
        public List<User> GetUsers(string usernm)
        {
            return _userRepository.GetUserList(usernm);


        }
        public bool ModifyLockUser(string userId, string lockyn)
        {
            return _userRepository.ModifyLockUser(userId.ToLower(), lockyn);
        }
        public bool ErrorLog(NEXCOREData data)
        {
            return _userRepository.ErrorLog(data);
        }
        public bool LoginHistory(NEXCOREData data)
        {
            return _userRepository.LoginHistory(data);
        }
        public bool PgmHistory(NEXCOREData data)
        {
            return _userRepository.PgmHistory(data);
        }
        public bool ButtonHistory(NEXCOREData data)
        {
            return _userRepository.ButtonHistory(data);
        }
        public bool ChangePassword(string userId, string password)
        {
            return _userRepository.ChangePassword(userId, password);
        }
        public bool AddUser(NEXCOREData data)
        {
            return _userRepository.AddUser(data);
        }
        public bool UpdateUser(NEXCOREData data)
        {
            return _userRepository.UpdateUser(data);
        }
        public bool EtcUpdateUser(NEXCOREData data)
        {
            return _userRepository.EtcUpdateUser(data);
        }
        public bool DeleteUser(NEXCOREData data)
        {
            return _userRepository.DeleteUser(data);
        }
        public void Reload()
        {
            _userRepository.LoadUsers();
        }
        #endregion
    }
}
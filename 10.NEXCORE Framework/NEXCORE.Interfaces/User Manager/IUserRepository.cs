using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface IUserRepository
    {
        void LoadUsers();

        IList<User> GetUsers();
        List<User> GetUserList(string usernm);
    }
}

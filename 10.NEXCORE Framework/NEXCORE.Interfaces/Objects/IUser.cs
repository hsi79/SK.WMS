using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEXCORE.Interfaces
{
    public interface IUser
    {
        string UserId { get; set; }
        string AuthId { get; set; }
        string UserName { get; set; }
        string Password { get;set;}
        string UserType {get;set;}
        bool IsLock { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        string RegId { get; set; }
        DateTime RegTime { get; set; }
        string ModId { get; set; }
        DateTime ModTime { get; set; }
        string Locale { get; set; }
    }
}

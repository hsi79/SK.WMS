﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface IMessageRepository : IDisposable
    {
        List<Message> GetMessageList();

        void LoadMessage();
        
    }
}

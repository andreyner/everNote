﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote.Logger
{
    public static class Log
    {
        public static readonly NLog.Logger Instance = LogManager.GetCurrentClassLogger();
    }
}

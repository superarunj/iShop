﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iShop.Web.Helpers
{
    public class LoggingEvents
    {
        public const int Success = 1000;
        public const int Fail = 2000;
        public const int SavedFail = 2001;
        public const int Created = 3000;
        public const int Deleted = 5000;
        public const int Updated = 6000;
    }
}

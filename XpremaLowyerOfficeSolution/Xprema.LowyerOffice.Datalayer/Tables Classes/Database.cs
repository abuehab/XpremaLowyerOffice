﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.LowyerOffice.Datalayer.Tables_Classes
{
    public   abstract   class Database
    {
        public static DbDataContext context = new DbDataContext();
    }
}

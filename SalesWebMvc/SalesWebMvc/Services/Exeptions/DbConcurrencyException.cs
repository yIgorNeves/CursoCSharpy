﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exeptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message): base(message)
        {
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Options
{
    public class ConnectionStringOptions
    {
        public const string SectionName = "ConnectionString";
        public string DefaultConnection { get; set; } = string.Empty;
    }
}

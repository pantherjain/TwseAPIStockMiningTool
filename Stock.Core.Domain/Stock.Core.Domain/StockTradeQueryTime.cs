﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Core.Domain
{
    public class StockTradeQueryTime
    {
        public TimeSpan sysTime { get; set; }

        public int sessionLatestTime { get; set; }

        public string sysDate { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.DAL
{
    public class RamMetricCreateRequest
    {
        public DateTimeOffset Time { get; set; }
        public int Value { get; set; }
    }
}
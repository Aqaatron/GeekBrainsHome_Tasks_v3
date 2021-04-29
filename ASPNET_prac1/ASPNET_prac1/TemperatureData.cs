using System;
using System.Collections.Generic;

namespace ASPNET_prac1
{

    public class TemperatureInfo
    {
        public int TemperatureValue { get; set; }

        public DateTime TemperatureDateTime { get; set; }
    }

    public class TemperatureData
    {
        public List<TemperatureInfo> TemperatureInfoList { get; set; }

        public TemperatureData()
        {
            TemperatureInfoList = new List<TemperatureInfo>();
        }

    }
}

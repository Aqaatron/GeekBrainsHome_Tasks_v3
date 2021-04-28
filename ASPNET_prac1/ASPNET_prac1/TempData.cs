using System;
using System.Collections.Generic;

namespace ASPNET_prac1
{

    public class TempInfo
    {
        public int TempVal { get; set; }

        public DateTime DateTime { get; set; }
    }

    public class TempData
    {
        public List<TempInfo> TempInfo { get; set; }

        public TempData()
        {
            TempInfo = new List<TempInfo>();
        }

    }
}

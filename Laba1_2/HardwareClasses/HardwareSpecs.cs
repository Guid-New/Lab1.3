using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_2.Logic
{
    public class HardwareSpecs
    {
        public double ClockSpeed { get; set; }
        public bool InternetConnection { get; set; }
        public HardwareType Type { get; set; }
        public int Cores { get; set; }
        public int FreeSpace { get; set; }
        public int Ram { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_2.Logic
{
    public class SystemRequirements
    {
        public int Ghz { get; set; }
        public int Cores { get; set; }
        public int Ram { get; set; }
        public int SpaceNeededMb { get; set; }
        public bool RequireInternet { get; set; }
        public bool RequireInstallation { get; set; }
    }
}

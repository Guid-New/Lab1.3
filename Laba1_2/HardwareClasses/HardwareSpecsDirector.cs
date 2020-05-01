using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_2.Logic.HardwareClasses
{
    class HardwareSpecsDirector
    {
        private readonly HardwareSpecsBuilder _builder = new HardwareSpecsBuilder();

        public HardwareSpecs CreateUltimateGamingRig()
        {
            return _builder.SetHardwareType(HardwareType.PC)
                .SetCoresCount(12)
                .SetClockSpeed(5)
                .SetFreeSpace(10000000)
                .SetInternetConnection(true)
                .SetRam(64)
                .GetHardware();
        }

        public HardwareSpecs CreateConsole()
        {
            return _builder.SetHardwareType(HardwareType.PC)
                .SetCoresCount(8)
                .SetClockSpeed(2)
                .SetFreeSpace(1000)
                .SetInternetConnection(true)
                .SetRam(8)
                .GetHardware();
        }

        public HardwareSpecs CreateMobile()
        {
            return _builder.SetHardwareType(HardwareType.PC)
                .SetCoresCount(8)
                .SetClockSpeed(2.3)
                .SetFreeSpace(64)
                .SetInternetConnection(true)
                .SetRam(8)
                .GetHardware();
        }
    }
}

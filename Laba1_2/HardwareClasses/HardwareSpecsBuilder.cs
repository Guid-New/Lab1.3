using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_2.Logic
{
    public class HardwareSpecsBuilder
    {
        private HardwareSpecs _hardwareSpecs = new HardwareSpecs();

        public HardwareSpecsBuilder SetClockSpeed(double Ghz)
        {
            _hardwareSpecs.ClockSpeed = Ghz;
            return this;
        }

        public HardwareSpecsBuilder SetInternetConnection(bool option)
        {
            _hardwareSpecs.InternetConnection = option;
            return this;
        }

        public HardwareSpecsBuilder SetHardwareType(HardwareType type)
        {
            _hardwareSpecs.Type = type;
            return this;
        }

        public HardwareSpecsBuilder SetCoresCount(int count)
        {
            _hardwareSpecs.Cores = count;
            return this;
        }

        public HardwareSpecsBuilder SetFreeSpace(int count)
        {
            _hardwareSpecs.FreeSpace = count;
            return this;
        }

        public HardwareSpecsBuilder SetRam(int count)
        {
            _hardwareSpecs.Ram = count;
            return this;
        }

        public void Reset()
        {
            _hardwareSpecs = new HardwareSpecs();
        }

        public HardwareSpecs GetHardware()
        {
            return _hardwareSpecs;
        }
    }
}

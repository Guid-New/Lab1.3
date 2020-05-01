using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_2.Logic.Games
{
    class MobileGame : Game, IInstallable, IStreamable
    {
        private protected override bool ValidateSystemRequirements(SystemRequirements requirements)
        {
            throw new NotImplementedException();
        }

        public void Install()
        {
            throw new NotImplementedException();
        }

        public void Stream()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_2.Logic.Games
{
    class ConsoleGame : Game, IInstallable, IStreamable
    {
        private protected override bool ValidateSystemRequirements(SystemRequirements requirements)
        {
            if (!requirements.RequireInstallation)
                return false;
            if (requirements.Cores != 0)
                return false;
            if (requirements.Ram != 0)
                return false;
            if (requirements.Ghz != 0)
                return false;
            if (requirements.SpaceNeededMb <= 0)
                return false;

            return true;
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

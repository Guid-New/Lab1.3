using System;

namespace Lab1_2.Logic.Games
{
    internal class GameRunningException : Exception
    {
        public GameRunningException(string message):base(message)
        {
            
        }
    }
}
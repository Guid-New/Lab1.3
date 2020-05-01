using System;

namespace Lab1_2.Logic.GameEventArgs
{
    public class GameStartedEventArgs : EventArgs
    {
        public double CurrentTime { get; set; }
        public int CurrentSave { get; set; }
    }
}

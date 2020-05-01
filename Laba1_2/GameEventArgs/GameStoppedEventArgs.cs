using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_2.Logic.GameEventArgs
{
    public class GameStoppedEventArgs
    {
        public double TimePlayed { get; set; }
        public double TotalTime { get; set; }
        public int CurrentSave { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Lab1_2.Logic;
using Lab1_2.Logic.GameEventArgs;
using Lab1_2.Logic.Games;

namespace Lab1_2
{
    public class Hardware
    {
        public HardwareSpecs Specs { get; set; }

        public void LoadGame(Game game)
        {
            game.Authentication += OnAuthentication;
            game.Stopped += OnGameStopped;
            game.Started += OnGameStarted;
        }

        private void OnAuthentication(object sender, AuthenticationEventArgs e)
        {
            Console.WriteLine(e.Successful ? "Authentication successful" : "Authentication failed");
        }

        private void OnGameStarted(object sender, GameStartedEventArgs e)
        {
            Console.WriteLine($"Game started on {e.CurrentSave} save, {e.CurrentTime} minutes played");
        }

        private void OnGameStopped(object sender, GameStoppedEventArgs e)
        {
            Console.WriteLine($"Game saved to save number {e.CurrentSave}, you played {e.TimePlayed} minutes, total time {e.TotalTime} minutes");
        }
    }
}

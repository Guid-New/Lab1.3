using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Lab1_2.Logic.GameEventArgs;

namespace Lab1_2.Logic.Games
{
    public abstract class Game
    {
        //реалізація класу... 
        private SystemRequirements _requirements;
        private bool _isRunning;
        private bool _isAuthenticated;
        private Tuple<string, string> _accountInfo;
        private readonly Stopwatch _stopwatch = new Stopwatch();
        private int _currentSave;
        private int _rating;

        public List<double> Saves { get; } = new List<double>();
        private Genre Genre { get; set; }
        public string Name { get; set; }

        public int Rating
        {
            get => _rating;
            set
            {
                if (value < 1 || value > 5)
                    throw new ArgumentException($"rating {value} is not valid");
                _rating = value;
            }
        }

        public void Load(Hardware hardware)
        {

        }

        public SystemRequirements Requirements
        {
            get => _requirements;
            set
            {
                if (!ValidateSystemRequirements(value))
                    throw new IncorrectSystemRequirementsException("system requirements are incorrect");

                _requirements = value;
            }
        }

        private protected abstract bool ValidateSystemRequirements(SystemRequirements requirements);

        public void Register(string login, string password) => _accountInfo = new Tuple<string, string>(login, password);

        public void Authenticate(string login, string password)
        {
            var args = new AuthenticationEventArgs { Successful = false };
            if (login == _accountInfo.Item1 && password == _accountInfo.Item2)
            {
                _isAuthenticated = true;
                args.Successful = true;
            }
            OnAuthentication(args);
        }

        public void RunNew()
        {
            if (_isRunning)
                throw new GameRunningException("game is already running");
            if (!_isAuthenticated)
                throw new GameRunningException("to play you need to login into account");
            _isRunning = true;
            _currentSave = Saves.Count;
            Saves.Add(default(int));
            _stopwatch.Start();
            OnStarted(new GameStartedEventArgs { CurrentSave = _currentSave, CurrentTime = Saves[_currentSave] });
        }

        public void Run(int indexOfSave)
        {
            if (_isRunning)
                throw new GameRunningException("game is already running");
            if (!_isAuthenticated)
                throw new GameRunningException("to play you need to login into account");
            _isRunning = true;
            if (indexOfSave < 0 || indexOfSave >= Saves.Count)
                throw new GameRunningException("incorrect index");
            _currentSave = indexOfSave;
            _stopwatch.Start();
            OnStarted(new GameStartedEventArgs { CurrentSave = _currentSave, CurrentTime = Saves[_currentSave] });
        }

        public void StopAndSave()
        {
            if (!_isRunning)
                throw new GameRunningException("game is already stopped");
            _isRunning = false;
            _stopwatch.Stop();
            var timePlayed = (((double)_stopwatch.ElapsedMilliseconds / 1000) / 60);
            Saves[_currentSave] += timePlayed;
            _stopwatch.Reset();
            OnStopped(new GameStoppedEventArgs { CurrentSave = _currentSave, TimePlayed = timePlayed, TotalTime = Saves[_currentSave] });
        }
        
        //події та їх викликачі
        public event EventHandler<AuthenticationEventArgs> Authentication;

        protected virtual void OnAuthentication(AuthenticationEventArgs e)
        {
            Authentication?.Invoke(this, e);
        }

        public event EventHandler<GameStartedEventArgs> Started;

        protected virtual void OnStarted(GameStartedEventArgs e)
        {
            Started?.Invoke(this, e);
        }

        public event EventHandler<GameStoppedEventArgs> Stopped;

        protected virtual void OnStopped(GameStoppedEventArgs e)
        {
            Stopped?.Invoke(this, e);
        }
    }
}
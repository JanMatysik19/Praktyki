﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using WPF10.Model;

namespace WPF10.ViewModel
{
    internal class StopwatchViewModel : INotifyPropertyChanged
    {
        private StopWatchModel _stopwatchModel = new StopWatchModel();

        private DispatcherTimer _timer = new DispatcherTimer();

        public bool Running { get {  return _stopwatchModel.Running; } }

        public StopwatchViewModel()
        {
            _timer.Interval = TimeSpan.FromMilliseconds(50);
            _timer.Tick += TimerTick;
            _timer.Start();
            Console.WriteLine("START");
            //Start();

            _stopwatchModel.LapTimeUpdated += LapTimeUpdatedEventHandler;
        }


        public void Start()
        {
            _stopwatchModel.Start();
        }

        public void Stop()
        {
            _stopwatchModel.Stop();
        }

        public void Lap()
        {
            _stopwatchModel.Lap();
        }

        public void Reset()
        {
            bool running = Running;
            _stopwatchModel.Reset();
            if (running) _stopwatchModel.Start();
        }

        int _lastHours;
        int _lastMinutes;
        decimal _lastSeconds;
        bool _lastRunning;

        void TimerTick(object sender, object e)
        {
            if(_lastRunning != Running)
            {
                _lastRunning = Running;
                OnPropertyChanged("Running");
            }

            if (_lastHours != Hours)
            {
                _lastHours = Hours;
                OnPropertyChanged("Hours");
            }
            if (_lastMinutes != Minutes)
            {
                _lastMinutes = Minutes;
                OnPropertyChanged("Minutes");
            }
            if (_lastSeconds != Seconds)
            {
                _lastSeconds = Seconds;
                OnPropertyChanged("Seconds");
            }
        }



        public int Hours
        {
            get { return _stopwatchModel.Elapsed.HasValue ? _stopwatchModel.Elapsed.Value.Hours : 0; }
            set { }
        }

        public int Minutes
        {
            get { return _stopwatchModel.Elapsed.HasValue ? _stopwatchModel.Elapsed.Value.Minutes : 0; }
            set { }
        }
        public decimal Seconds
        {
            get
            { 
                if(_stopwatchModel.Elapsed.HasValue) return _stopwatchModel.Elapsed.Value.Seconds + (_stopwatchModel.Elapsed.Value.Milliseconds * 0.001M);
                else return 0.0M;
            }
            set { }
        }



        public int LapHours
        {
            get { return _stopwatchModel.LapTime.HasValue ? _stopwatchModel.LapTime.Value.Hours : 0; }
            set { }
        }

        public int LapMinutes
        {
            get { return _stopwatchModel.LapTime.HasValue ? _stopwatchModel.LapTime.Value.Minutes : 0; }
            set { }
        }

        public decimal LapSeconds
        {
            get
            {
                if (_stopwatchModel.LapTime.HasValue) return (decimal)_stopwatchModel.LapTime.Value.Seconds + (_stopwatchModel.LapTime.Value.Milliseconds * 0.001M);
                else return 0.0M;
            }
            set { }
        }



        int _lastLapHours;
        int _lastLapMinutes;
        decimal _lastLapSeconds;

        private void LapTimeUpdatedEventHandler(object sender, LapEventArgs e)
        {
            if(_lastLapHours != LapHours)
            {
                _lastLapHours = LapHours;
                OnPropertyChanged("LapHours");
            }
            if (_lastLapMinutes != LapMinutes)
            {
                _lastLapMinutes = LapMinutes;
                OnPropertyChanged("LapMinutes");
            }
            if (_lastLapSeconds != LapSeconds)
            {
                _lastLapSeconds = LapSeconds;
                OnPropertyChanged("LapSeconds");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if(propertyChanged != null) propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

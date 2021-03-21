using System;

namespace UdemyExercises
{
    public class StopWatch
    {
        private bool _started;
        private DateTime _currentStart;
        private int _totalSeconds;

        private void Start()
        {
            if (_started)
                throw new InvalidOperationException();
            Console.WriteLine("Starting...");
            _started = true;
            _currentStart = DateTime.Now;
        }

        private void Stop()
        {
            if (!_started)
                throw new InvalidOperationException();
            _started = false;
            _totalSeconds += (int) DateTime.Now.Subtract(_currentStart).TotalSeconds;
            _currentStart = DateTime.Now;
            Console.WriteLine($"Current Time: {ElapsedTime}");
        }

        public void Toggle()
        {
            if (_started)
                Stop();
            else Start();
        }

        public string ElapsedTime
        {
            get
            {
                int seconds = _totalSeconds % 60;
                int minutes = _totalSeconds / 60;
                return $"{minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}";
            }
        }
    }
}
using System;

namespace StopWatch
{
    class MyStopWatch
    {
        private bool _isRunning;
        private DateTime _start;
        private DateTime _stop;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("[StopWatch] StopWatch is already running.");

            _isRunning = true;
            _start = DateTime.Now;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("[StopWatch] StopWatch is not running.");

            _isRunning = false;
            _stop = DateTime.Now;
            Duration += _stop - _start;
        }

        public TimeSpan Duration { get; private set; }

        public void Reset()
        {
            Duration = TimeSpan.Zero;
            _isRunning = false;
        }
    }
}
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Xml.Schema;

namespace StopWatchApp
{
    public class StopWatch
    {
        private static bool _clockOngoing { get; set; }
        private static TimeSpan _duration { get; set; }
        private static TimeSpan _totalDuration { get; set; }

        public void Start()
        {
            if (_clockOngoing)
                throw new InvalidOperationException("Clock is already running.");
            _clockOngoing = true;
            _duration = DateTime.Now.TimeOfDay;
        }

        public void Stop()
        {
            _clockOngoing = false;
            var stopTime = DateTime.Now.TimeOfDay;
            _duration = stopTime.Subtract(_duration);
            _totalDuration = _totalDuration.Add(_duration);
        }

        public TimeSpan GetDuration()
        {
            return _totalDuration;
        }
    }
}
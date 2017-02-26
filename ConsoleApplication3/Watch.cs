using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class StopWatch
    {
        private static bool _running;
        private static DateTime _startTime;
        private static DateTime _endTime;

        public static void Start()
        {
            if (_running)
                throw new InvalidOperationException("StopWatch is already running!");

                _running = true;
            _startTime = DateTime.Now;
        }

        public static void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("StopWatch is not running!");

            _running = false;
            _endTime = DateTime.Now;
        }

        public static TimeSpan CalculateInterval()
        {
            var duration = _endTime - _startTime;

            return duration;
        }
    }
}
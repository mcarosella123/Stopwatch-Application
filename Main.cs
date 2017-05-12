using System;

namespace StopWatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var createWatch = new StopWatch();
            try
            {
                createWatch.Start();
                createWatch.Stop();
                Console.WriteLine(createWatch.GetDuration());
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Start button was used twice in a row without stopping.");
            }
        }
    }
}

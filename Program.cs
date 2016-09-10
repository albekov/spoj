using System;
using System.Diagnostics;

namespace SpojTasks
{
    internal static class Program
    {
        private static void Main()
        {
#if DEBUG
            var stopwatch = Stopwatch.StartNew();
#endif

            Template.Main();

#if DEBUG
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds} ms.");
#endif
        }
    }
}
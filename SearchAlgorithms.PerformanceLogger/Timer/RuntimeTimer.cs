using System;
using System.Diagnostics;
using SearchAlgorithms.Interfaces;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SearchAlgorithms.PerformanceLogger.Timer
{
    public static class RuntimeTimer
    {
        public static TimeSpan Measure(ISearchAlgorithm sortAlgorithm, IArrayGenerator arrayGenerator, int value)
        {
            var array = arrayGenerator.GetArray;
            Action act = () => sortAlgorithm.Contains(array, value);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            act.Invoke();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}
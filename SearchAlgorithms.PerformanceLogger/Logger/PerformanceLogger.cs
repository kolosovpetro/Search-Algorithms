using System;
using System.IO;
using SearchAlgorithms.Interfaces;
using SearchAlgorithms.PerformanceLogger.Timer;
using SortAlgorithms.ArrayGenerators.Interfaces;
using static SearchAlgorithms.PerformanceLogger.Logger.Routes;

namespace SearchAlgorithms.PerformanceLogger.Logger
{
    public static class PerformanceLogger
    {
        public static void Log(ISearchAlgorithm sortAlgorithm, IArrayGenerator arrayGenerator, int value)
        {
            var elapsed = RuntimeTimer.Measure(sortAlgorithm, arrayGenerator, value);
            var arrayType = arrayGenerator.GetType().Name;
            var size = arrayGenerator.Length;
            var algorithmName = sortAlgorithm.GetType().Name;
            var benchmarkFileName = $"{algorithmName}_{arrayType}.csv";
            var benchmarkDirectory = BenchmarksFolder + $"{algorithmName}/";
            Directory.CreateDirectory(benchmarkDirectory);
            var message = $"Elapsed; {elapsed}; Array Size; {size}; Array Type; {arrayType}; {algorithmName};";
            Console.WriteLine(message);
            using var sw = new StreamWriter(benchmarkDirectory + benchmarkFileName, true);
            sw.WriteLine(message);
        }
    }
}
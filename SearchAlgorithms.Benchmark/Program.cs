using System;
using System.Collections.Generic;
using SearchAlgorithms.Interfaces;
using SearchAlgorithms.SearchAlgorithms;
using SortAlgorithms.ArrayGenerators.ArrayGenerators;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SearchAlgorithms.Benchmark
{
    public static class Program
    {
        private static void Main()
        {
            const int sizeStep = 200;
            const int maxSize = 10000;
            var random = new Random();

            for (var i = sizeStep; i <= maxSize; i += sizeStep)
            {
                var arrayList = new List<IArrayGenerator>
                {
                    new AShapeArray(i),
                    new ConstantArray(i),
                    new RandomArray(i),
                    new ReversedArray(i),
                    new SortedArray(i),
                    new VShapeArray(i)
                };

                var searchAlgorithms = new List<ISearchAlgorithm>
                {
                    new BinarySearch(),
                    new ImprovedLinearSearch(),
                    new ImprovedLinearSearchWithSentinel(),
                    new SimpleLinearSearch()
                };

                foreach (var searchAlgorithm in searchAlgorithms)
                {
                    foreach (var array in arrayList)
                    {
                        if (searchAlgorithm is BinarySearch) 
                            Array.Sort(array.GetArray);
                        
                        var searchValue = random.Next(i);
                        PerformanceLogger.Logger.PerformanceLogger.Log(searchAlgorithm, array, searchValue);
                    }
                }
            }
        }
    }
}
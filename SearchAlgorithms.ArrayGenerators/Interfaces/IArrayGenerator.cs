using System;

namespace SortAlgorithms.ArrayGenerators.Interfaces
{
    public interface IArrayGenerator
    {
        int Length { get; }
        int[] GetArray { get; }

        void PrintArray()
        {
            foreach (var value in GetArray)
                Console.Write(value + " ");
        }
    }
}
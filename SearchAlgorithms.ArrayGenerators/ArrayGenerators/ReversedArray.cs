using System;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class ReversedArray : IArrayGenerator
    {
        private readonly RandomArray _randomArray;
        public int Length => GetArray.Length;
        public int[] GetArray { get; }

        public ReversedArray(int arraySize)
        {
            _randomArray = new RandomArray(arraySize);
            GetArray = GenerateArray();
        }

        private int[] GenerateArray()
        {
            var array = _randomArray.GetArray;
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
    }
}
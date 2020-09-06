using System;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class ConstantArray : IArrayGenerator
    {
        private static readonly Random Random = new Random();
        private readonly int _arraySize;
        public int Length => GetArray.Length;
        public int[] GetArray { get; }

        public ConstantArray(int arraySize)
        {
            _arraySize = arraySize;
            GetArray = GenerateArray();
        }


        public int[] GenerateArray()
        {
            var value = Random.Next(_arraySize);
            var array = new int[_arraySize];

            for (var i = 0; i < _arraySize; i++)
                array[i] = value;

            return array;
        }
    }
}
using System;
using System.Linq;
using SortAlgorithms.ArrayGenerators.Interfaces;

namespace SortAlgorithms.ArrayGenerators.ArrayGenerators
{
    public class VShapeArray : IArrayGenerator
    {
        private readonly RandomArray _randomArray;
        public int Length => GetArray.Length;
        public int[] GetArray { get; }

        public VShapeArray(int arraySize)
        {
            _randomArray = new RandomArray(arraySize / 2);
            GetArray = GenerateArray();
        }

        private int[] GenerateArray()
        {
            var left = _randomArray.GetArray;
            Array.Sort(left);
            Array.Reverse(left);
            var right = _randomArray.GetArray;
            Array.Sort(right);
            return left.Concat(right).ToArray();
        }
    }
}
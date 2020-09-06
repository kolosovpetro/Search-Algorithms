using SearchAlgorithms.Interfaces;

namespace SearchAlgorithms.SearchAlgorithms
{
    public class BinarySearch : ISearchAlgorithm
    {
        public bool Contains(int[] array, int searchValue)
        {
            var min = 0;
            var max = array.Length - 1;

            while (min <= max)
            {
                var mid = (min + max) / 2;

                if (searchValue == array[mid]) return true;

                if (searchValue < array[mid]) max = mid - 1;

                else min = mid + 1;
            }

            return false;
        }
    }
}
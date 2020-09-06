using SearchAlgorithms.Interfaces;

namespace SearchAlgorithms.SearchAlgorithms
{
    public class ImprovedLinearSearchWithSentinel : ISearchAlgorithm
    {
        public bool Contains(int[] array, int searchValue)
        {
            var last = array[^1];
            array[^1] = searchValue;
            var step = 0;

            while (array[step] != searchValue)
                step++;

            array[^1] = last;

            return step < array.Length - 1 || last == searchValue;
        }
    }
}
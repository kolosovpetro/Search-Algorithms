using SearchAlgorithms.Interfaces;

namespace SearchAlgorithms.SearchAlgorithms
{
    public class SimpleLinearSearch : ISearchAlgorithm
    {
        public bool Contains(int[] array, int searchValue)
        {
            var contains = false;

            foreach (var t in array)
            {
                if (t == searchValue) 
                    contains = true;
            }

            return contains;
        }
    }
}
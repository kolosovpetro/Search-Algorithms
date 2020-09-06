using SearchAlgorithms.Interfaces;

namespace SearchAlgorithms.SearchAlgorithms
{
    public class ImprovedLinearSearch: ISearchAlgorithm
    {
        public bool Contains(int[] array, int searchValue)
        {
            foreach (var t in array)
            {
                if (t == searchValue)
                    return true;
            }

            return false;
        }
    }
}
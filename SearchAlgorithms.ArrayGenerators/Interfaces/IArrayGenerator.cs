namespace SortAlgorithms.ArrayGenerators.Interfaces
{
    public interface IArrayGenerator
    {
        int Length { get; }
        int[] GetArray { get; }
    }
}
using NUnit.Framework;
using Platinum.Algorithms.Sorting;

namespace Platinum.Test
{
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 7, 3, 1, 10, 5, 2, 11 })]
        public void BubbleSortAscendingIsNotNull(int[] array)
        {          
            Assert.NotNull(Sorting.BubbleSort(array, Direction.Ascending));
        }

        [Test]
        [TestCase(new int[] { 7, 3, 1, 10, 5, 2, 11 })]
        public void BubbleSortDescendingIsNotNull(int[] array)
        {          
            Assert.NotNull(Sorting.BubbleSort(array, Direction.Descending));
        }

        [Test]
        [TestCase(new int[] { 7, 3, 1, 10, 5, 2, 11 })]
        public void QuickSortAscendingIsNotNull(int[] array)
        {
            Assert.NotNull(Sorting.QuickSort(array, 0, array.Length - 1, Direction.Ascending));
        }

        [Test]
        [TestCase(new int[] { 7, 3, 1, 10, 5, 2, 11 })]
        public void QucikSortDescendingIsNotNull(int[] array)
        {
            Assert.NotNull(Sorting.QuickSort(array, 0, array.Length - 1, Direction.Descending));
        }
    }
}
using NUnit.Framework;
using Platinum.Algorithms.Sorting;
using Platinum.Test.Helpers;

namespace Platinum.Test.Tests
{
    public class SortingTest
    {
        public Sorting Sorting = new();
        public int[] IntSequence = Enumerable.Range(1, 100).ToArray();

        [SetUp]
        public void Test()
        {
            Extension.Shuffle(IntSequence);
        }

        [Test]
        public void BubbleSortAscendingIsNotNullAndEmpty()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Sorting.BubbleSort(IntSequence, Direction.Ascending), Is.Not.Null);
                Assert.That(Sorting.BubbleSort(IntSequence, Direction.Ascending), Is.Not.Empty);
            });
        }

        [Test]
        public void BubbleSortAscendingIsOrderedCorrect()
        {
            Assert.That(Sorting.BubbleSort(IntSequence, Direction.Ascending), Is.Ordered.Ascending);
        }

        [Test]
        public void BubbleSortDescendingIsNotNullAndEmpty()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Sorting.BubbleSort(IntSequence, Direction.Descending), Is.Not.Null);
                Assert.That(Sorting.BubbleSort(IntSequence, Direction.Descending), Is.Not.Empty);
            });
        }

        [Test]
        public void BubbleSortDescendingIsOrderedCorrect()
        {
            Assert.That(Sorting.BubbleSort(IntSequence, Direction.Descending), Is.Ordered.Descending);
        }

        [Test]
        public void QuickSortAscendingIsNotNullAndEmpty()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Sorting.QuickSort(IntSequence, 0, IntSequence.Length - 1, Direction.Ascending), Is.Not.Null);
                Assert.That(Sorting.QuickSort(IntSequence, 0, IntSequence.Length - 1, Direction.Ascending), Is.Not.Empty);
            });
        }

        [Test]
        public void QuickSortAscendingIsOrderedCorrect()
        {
            Assert.That(Sorting.QuickSort(IntSequence, 0, IntSequence.Length - 1, Direction.Ascending), Is.Ordered.Ascending);
        }

        [Test]
        public void QucikSortDescendingIsNotNullAndEmpty()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Sorting.QuickSort(IntSequence, 0, IntSequence.Length - 1, Direction.Descending), Is.Not.Null);
                Assert.That(Sorting.QuickSort(IntSequence, 0, IntSequence.Length - 1, Direction.Descending), Is.Not.Empty);
            });
        }

        [Test]
        public void QuickSortDescendingIsOrderedCorrect()
        {
            Assert.That(Sorting.QuickSort(IntSequence, 0, IntSequence.Length - 1, Direction.Descending), Is.Ordered.Descending);
        }
    }
}

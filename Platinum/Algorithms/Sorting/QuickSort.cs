namespace Platinum.Algorithms.Sorting
{
    public partial class Sorting
    {
        public int[] QuickSort(int[] array, int left, int right, Direction direction)
        {
            if (direction == Direction.Ascending)
            {
                var i = left;
                var j = right;
                var pivot = array[(left + right) / 2];
                while (i < j)
                {
                    while (array[i] < pivot) i++;
                    while (array[j] > pivot) j--;
                    if (i <= j)
                    {
                        var tmp = array[i];
                        array[i++] = array[j];
                        array[j--] = tmp;
                    }
                }
                if (left < j) QuickSort(array, left, j, Direction.Ascending);
                if (i < right) QuickSort(array, i, right, Direction.Ascending);
            }
            else
            {
                var i = left;
                var j = right;
                var pivot = array[(left + right) / 2];
                while (i < j)
                {
                    while (array[i] > pivot) i++;
                    while (array[j] < pivot) j--;
                    if (i <= j)
                    {
                        var tmp = array[i];
                        array[i++] = array[j];
                        array[j--] = tmp;
                    }
                }
                if (left < j) QuickSort(array, left, j, Direction.Descending);
                if (i < right) QuickSort(array, i, right, Direction.Descending);
            }
            return array;
        }
    }
}

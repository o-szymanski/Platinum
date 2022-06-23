namespace Platinum.Algorithms.Sorting
{
    public partial class Sorting
    {
        public static int[] BubbleSort(int[] input, Direction direction)
        {
            int temp;
            if (direction == Direction.Ascending)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length - 1 - i; j++)
                    {
                        if (input[j] > input[j + 1])
                        {
                            temp = input[j + 1];
                            input[j + 1] = input[j];
                            input[j] = temp;
                        }
                    }
                }
                return input;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length - 1 - i; j++)
                    {
                        if (input[j] < input[j + 1])
                        {
                            temp = input[j + 1];
                            input[j + 1] = input[j];
                            input[j] = temp;
                        }
                    }
                }
                return input;
            }
        }
    }
}

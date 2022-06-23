namespace Platinum.Test.Helpers
{
    internal static class Extension
    {
        internal static void Shuffle<T>(T[] array)
        {
            Random random = new();
            int n = array.Length;
            while (n > 1)
            {
                int k = random.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}

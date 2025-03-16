namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 654, 47, 238, -23, 532, 1, 980 };
            Console.WriteLine(Min(arr));
        }
        static int Min(int[] arr)
        {

            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }
            return min;
        }
    }
}
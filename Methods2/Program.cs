//namespace Methods2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 23, 654, 47, 238, -23, 532, 1, 980 };
//            Console.WriteLine(Min(arr));
//        }
//        static int Min(int[] arr)
//        {

//            int min = arr[0];
//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (min > arr[i])
//                    min = arr[i];
//            }
//            return min;
//        }
//    }
//}



using System;
namespace Methods2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine($"Cevrenin sahesi:{Area(4.6)}");
            Console.WriteLine($"Duzbucaqlinin sahesi:{Area(4.5, 6.3)}");
            Console.WriteLine($"Duzbucaqli paralelepipedin tam sethin sahesi:{Area(4, 2.5, 5.123)}");
            Console.WriteLine($"Ucbucaqlinin daxiline cekilmis cevrenin sahesi:{Area(2, 8, 1.1, 1)}");
        }
        static double Area(double r)
        {
            int p = 3;
            double S = p * r * r;      //cevrenin sahesi
            return S;
        }
        static double Area(double a, double b)
        {
            double S = a * b;         //duzbucaqlinin sahesi
            return S;
        }
        static double Area(double a, double b, double c)
        {
            double S = 2 * (a * b + a * c + b * c);

            return S;           //duzbucaqli paralelepipedin tam sethinin sahesi
        }
        static double Area(double a, double b, double c, double r)
        {
            double p = (a + b + c) / 2;
            double S = p * r;

            return S;     //ucbucaqlinin daxiline cekilmis cevrenin sahesi
        }
    }
}



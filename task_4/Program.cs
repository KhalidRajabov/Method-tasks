using System;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sahe deyə Method(lar) yaradılır.
            //Çevrənin sahəsi -S = p * r² (p = 3)
            //Düzbucaqlının sahəsi -S = a * b
            //Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a + b + c) / 2

            
            Console.WriteLine(Sahe(4));
            Console.WriteLine(Sahe(4,5));
            Console.WriteLine(Sahe(4,6,3,4));
        }

        static double Sahe( double r)
        {
            double pi = 3;
            return pi* r * r;
        }
        static double Sahe(double a, double b)
        {
            return a * b;
        }
        static double Sahe( double r, double a, double b, double c)
        {
            double p = (a + b+c) / 2;
            double s = p * r;
            return s;
        }

    }
}

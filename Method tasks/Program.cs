using System;

namespace task_1
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            //1) Bir method olsun iki parametr qəbul etsin
            //və bu parametrlərdən birincini ikinciyə bölüb
            //nəticəni geri qaytarsın.

            Console.Write("Birinci ededi daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ikinci ededi daxil edin: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a} : {b} = {Divide(a, b)}");
        }
        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

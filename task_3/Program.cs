using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Bir method olsun
            //göndərilən "n" sayda ədədin hamsını toplayıb geri qaytarsın.
            int result = SubMassiveElement(1,2,3,4,5,5,5,5,5);
            Console.WriteLine(result);
        }


        static int SubMassiveElement(params int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
        
    }
}

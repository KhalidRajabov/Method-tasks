using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2) Repeat deyə bir method olsun və iki parametr qəbul etsin
             * biri "word" digəri "count" yəni bu şəkildə "Repeat(string word, int count)" 
             * bu method göndərilən word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın.
             * Məsələn:
            Repeat("Ha!") //Ha!
            Repeat("Ha!", 2) //Ha!Ha!
            Repeat("Ha!", 3) //Ha!Ha!Ha!*/

            Console.Write("Sozu daxil edin: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.Write("Neche defe tekrarlansin? ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Repeat(a, b));
        }

        static string Repeat(string word, int count)
        {
            for (int i = 1; i < count; i++)
            {
                Console.Write(word);
            }
            return word;
        }

    }
}

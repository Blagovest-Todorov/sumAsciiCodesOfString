using System;

namespace _24.sumStringDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string = ");
            string symbolWord = Console.ReadLine ();  //here we summ the symbols numbers  (by Asci code table  ) of a given string characters /

            Console.Write("sum of Asci code of all chars = ");
            int sum = 0;
            for (int i = 0; i < symbolWord.Length; i++)
            {
                sum += symbolWord[i];
            }
            Console.WriteLine($"{sum}");
        }
    }
}

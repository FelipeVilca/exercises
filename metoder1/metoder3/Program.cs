using System;

namespace metoder3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två heltal för addition: ");
            Console.Write("Skriv ditt första tal ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt andra tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            summan(tal1, tal2);
        }
         static void summan(int tal1, int tal2)
        {
            int sum = tal1 + tal2;
            Console.Write("Dina tal adderat blir: " + sum);
        }
    }
}

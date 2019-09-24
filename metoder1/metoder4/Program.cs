using System;

namespace metoder4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej vad kostade din vara? ");
            double pris = Convert.ToInt32(Console.ReadLine());
            double moms = 1.25;

            double result = medMoms(pris, moms);
            Console.WriteLine("Din vara inklusive moms blir " + result);          
                  
        }
        static double medMoms(double pris, double moms)
        {
            double sum = pris * moms;
            return sum;
        }
    }
}

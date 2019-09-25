using System;

namespace metoder6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Skapa metoden ToPercentage() som tar in ett decimaltal och returnerar ett heltal. 
            */
            Console.WriteLine("Vänligen skriv in ett decimaltal ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            double avrundat = tal1 + 0.5;
            Console.WriteLine("Ditt tal avrundat till helta blir " + avrundat);
        }
    }
}

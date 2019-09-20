using System;

namespace Vektorer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int [5];
            Console.WriteLine("Skriv in 5 tal:");
            Console.Write("Skriv in ditt första tal: ");
            tal[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt andra tal: ");
            tal[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt tredje tal: ");
            tal[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt fjärde tal: ");
            tal[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt femte tal: ");
            tal[4] = Convert.ToInt32(Console.ReadLine());

        
            int sum = 0;
            for (int i = 0; i < tal.Length; i++){
                sum = sum + tal[i];

            }
            
            Console.WriteLine("Dina tal summerat blir " + sum); 
        }
    }
}

using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            int tal1,tal2,sum;
            Console.WriteLine("Skriv in två heltal ");
            Console.Write("Skriv in ditt första tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ditt andra tal: "); 
            tal2 = Convert.ToInt32(Console.ReadLine());
            sum = tal1+tal2;
            Console.WriteLine("Dina tal summerat blir: " + sum);

            

      


        }
    }
}

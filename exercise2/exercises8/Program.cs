using System;

namespace exercises8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Skriv ett program som simulerar en bank. 
            Man ska kunna sätta in pengar och ta ut pengar, samt kolla saldo. 
            Detta görs via en meny som du ska göra med switch-sats. 
            Observera att du bör jobba med loopar i denna uppgift! 
            */
          while (true)
            {//Skriver menyn för användaren
                Console.WriteLine("Välj:");
                Console.WriteLine("[I]nsättning");
                Console.WriteLine("[U]ttag");
                Console.WriteLine("[S]aldo");
                Console.WriteLine("[A]vsluta");
                string menySelection = Console.ReadLine();//Val för användaren
                if (menySelection == "I" || menySelection == "i")
                {
                    Console.WriteLine("Var god och mata in sedlarna");
                }
                else if (menySelection == "U" || menySelection == "u")
                {
                    Console.WriteLine("Skriv in belopp");
                }
                else if (menySelection == "S" || menySelection == "s")
                {
                    Console.WriteLine("Saldo är 500:-");
                }
                else if (menySelection == "A" || menySelection == "a")
                {
                    Console.WriteLine("Välkommen åter");
                }
                {
                    break; //Avbryter loopen
                }
            }
        }
    }
}

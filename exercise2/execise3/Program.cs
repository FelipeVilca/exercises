using System;

namespace execise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Låt användaren mata in två namn. Skriv sedan ut en kort berättelse med dessa två namn. 
            */
            Console.WriteLine("Hej vänligen skriv in två namn ");
            Console.Write("Skriv in ditt första namn: ");
            string name1 = Console.ReadLine();
            Console.Write("Skriv in ditt andra namn: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Det var en gång två personer den ena hette " + name1 + 
            " och den andra hette " + name2 + " De var väldigt lyckliga båda två :) ");

        }
    }
}

using System;

namespace exercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Skapa ett program som ställer frågan ”Är det fint väder?”. 
            Om användaren svara ”j” skriver programmet ut ”Vi går på picknick!”. 
            Annars händer ingenting. 
            */
            Console.WriteLine("Är det fint väder? ");
            string answer = Console.ReadLine();
            if (answer == "j")
            {
                Console.WriteLine("Vi går på picknick ");
            }
        }
    }
}

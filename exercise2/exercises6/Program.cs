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
            Arbeta vidare på övningen ovanför men lägg till att användaren kan svara ”n”. 
            Då skriver programmet ut ”Vi stannar inne och läser en bok”. Det ska inte spela 
            någon roll om användaren matar in stor eller liten bokstav.Kontrollera värdet (del 3)
            Arbeta vidare på övningen. Gör så att om användaren matar in något annat 
            än ”J”, ”j”, ”n”, ”N” så skriver programmet ut ”Jag förstår inte!”.
            */
            Console.WriteLine("Är det fint väder? ");
            string answer = Console.ReadLine();
            if (answer == "j" || answer == "J")
            {
                Console.WriteLine("Vi går på picknick ");
            }
            else if (answer == "n" || answer == "N")
            {
                Console.WriteLine("Vi stannar inne och läser en bok ");
            }
            else
            {
                Console.WriteLine("Jag förstår inte! ");
            }
        }
    }
}

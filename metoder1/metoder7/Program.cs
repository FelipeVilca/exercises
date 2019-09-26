using System;

namespace metoder7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skapa en metod som kontrollerar om man är myndig. Metoden ska ta in 
            ett heltal och returnera true eller false.
            */
            Console.WriteLine("Hej hur gammal är du? ");
            int Age = Convert.ToInt32(Console.ReadLine());
            bool myMyndig = true;
            myMyndig = Age >= 18; 
            {
                Console.WriteLine(myMyndig);
            }
        } 
        static bool myndig(int Age, bool myMyndig)
        {
            return myMyndig;
        }   
    }  
}

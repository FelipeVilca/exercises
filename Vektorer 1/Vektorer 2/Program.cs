using System;

namespace Vektorer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Skapa en string array med fem element. Användaren får mata in fem namn
            via en for-loop. Programmet skriver sedan ut dessa namn med hjälp av en for-loop.*/
            string[] name = new string [5];
            Console.WriteLine("Hej vänligen skriv in fem namn ");
            int sum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("Skriv in namn: ");
                string names = Console.ReadLine();
                sum = sum + name[i];
                
            }
            

        }
    }
}

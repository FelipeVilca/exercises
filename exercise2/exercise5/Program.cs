using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            I denna övning ska du göra ett program som låter användaren mata in sitt namn. 
            Därefter hälsar du användaren välkommen. Du ska sedan låta användaren mata in sin 
            ålder och spara undan den i lämplig variabel. Räkna sedan ut antalet dagar användaren 
            har levt utifrån det angivna åldern. Presentera detta för användaren. 
            */
            Console.WriteLine("Hej och välkommen ");
            Console.Write("Vad heter du? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hej och välkommen "+ name + " hur gammal är du? ");
            int Age = Convert.ToInt32(Console.ReadLine());
            int year, sum;
            year = 365;
            sum = Age * year;
            Console.WriteLine(name + " du har levt i " + sum + " dagar ");
        }
    }
}

using System;

namespace metoder5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fortsättning på föregående övning. Gör om funktionen så att man i
            metodanropet (via parameterlistan) får ange vad momsen ligger på.  
            */
            Console.WriteLine("Hej vad kostade din vara? ");
            double pris = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur mycket % är momsen på? ");
            double moms = Convert.ToInt32(Console.ReadLine());
            double delen = moms/100;
            double tal1 = 1;


            double result = medMoms(pris, delen, tal1);
            Console.WriteLine("Din vara inklusive moms blir " + result);
        }
        static double medMoms(double pris, double delen, double tal1)
        {
            double sum = pris * (delen + tal1);
            return sum;
        }
    }
}

using System;
using System.ComponentModel.Design;
namespace BonuspisteetKerto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinka monta bonuspistettä? ");
            int pisteet = int.Parse(Console.ReadLine());

            if (pisteet > 0 && pisteet < 4)
            {
                Console.WriteLine("Saat bonuspisteitä:" + (pisteet * 10));
            }
            else if (pisteet > 3 && pisteet < 7)
            {
                Console.WriteLine("Saat bonuspisteitä: " + (pisteet * 100));
            }
            else if (pisteet > 7 && pisteet <= 9)
            {
                Console.WriteLine("Saat bonuspisteitä: " + (pisteet * 1000));
            }
            else
            {
                Console.WriteLine("Tapahtui virhe");
            }

                

            
        }
    }
}

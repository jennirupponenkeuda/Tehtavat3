using System;
namespace SuurempiKahdesta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna eka luku: ");
            int ekaluku = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toka luku: ");
            int tokaluku = int.Parse(Console.ReadLine());

            if (tokaluku < ekaluku)
            {
                Console.WriteLine();
                Console.WriteLine(ekaluku);
                Console.WriteLine(tokaluku);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(tokaluku);
                Console.WriteLine(ekaluku);
            }
        }
    }
}

using System;
namespace SuurinKolmesta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna eka luku: ");
            int ekaluku = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toka luku: ");
            int tokaluku = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna kolmas luku: ");
            int kolmasluku = int.Parse(Console.ReadLine());

            int[] luvut = { ekaluku, tokaluku, kolmasluku }; //alustetaan luvut taulukkoon
            Array.Sort(luvut); //Nousevaan järjestykseen asettaminen
            Array.Reverse(luvut); // Jotta saadaan laskevaan järjestykseen, tällä komennolla käännetään

            Console.WriteLine("Luvut suurimmasta alkaen:");
            foreach (int i in luvut) // Tällä käydään taulukko läpi ja tulostetaan luvut yksi kerrallaan
            {
                
                Console.WriteLine(i);

            }
        }
    }
}
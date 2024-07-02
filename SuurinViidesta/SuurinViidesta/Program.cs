using System;
using System.Linq; //Tässä tehtävässä haluan kokeilla max -metodia, joten tarvitsen tätä
namespace SuurinViidesta
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[5]; //alustetaan taulukko, johon lisätään käyttäjän syöttämiä lukuja 5 kappaletta

            for (int i = 0; i < 5; i++) //silmukka, joka toistaa luvun pyytämisen, kunnes taulukon 5 paikkaa ovat täynnä
            {
                Console.WriteLine("Anna luku: ");
                luvut[i] = int.Parse(Console.ReadLine()); //tallentaa käyttäjän antaman luvun taulukkoon
            }
            int suurinluku = luvut.Max(); // etsii suurimman luvun taulukosta, huom! Tämän tulee olla silmukan ulkopuolella!
            Console.WriteLine("Suurin luku on: " + suurinluku);

        }
    }
}

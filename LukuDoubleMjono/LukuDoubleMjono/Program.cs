using System;
using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;
using System.Globalization;
namespace LukuDoubleMjono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse kokonaisluku, double tai merkkijono?");
            string valinta = Console.ReadLine();
            switch (valinta)
            {
                case "kokonaisluku":
                    Console.WriteLine("Anna kokonaisluku: ");
                    int kokonaisluku = int.Parse(Console.ReadLine());
                    Console.WriteLine("Antamasi kokonaisluku kasvatettuna yhdellä on: " + (kokonaisluku + 1));
                    break;
                case "double":
                    Console.WriteLine("Anna desimaaliluku: ");
                    string desimaaliluku = Console.ReadLine();
                    if (double.TryParse(desimaaliluku, NumberStyles.Float, CultureInfo.InvariantCulture, out double desimaali)) // Tämän metodin avulla pyritään muuttamaan virheellisesti annettu (esim. pilkkua käyttäen yms.) luku desimaaliluvuksi eli metodi käsittelee desimaalilukua
                    {
                        Console.WriteLine("Antamasi desimaaliluku kasvatettuna yhdellä: " + (desimaali + 1.0));
                    }
                    else
                    {
                        Console.WriteLine("Et antanut desimaalilukua"); // Tämä rakenne olisi hyvä olla myös muissa kohdissa ohjelman paremman toimivuuden kannalta
                    }
                    break;

                case "merkkijono":
                    Console.WriteLine("Anna merkkijono: ");
                    string mjono = Console.ReadLine();
                    Console.WriteLine("Antamasi merkkijono tähdellä merkattuna on: " + mjono + "*");
                    break;
                }
            }
        }
    }




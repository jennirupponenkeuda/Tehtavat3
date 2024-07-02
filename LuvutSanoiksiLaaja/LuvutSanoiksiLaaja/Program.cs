using System;
namespace LuvutSanoiksiLaaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna numero väliltä 0-999: ");


            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0 && numero <= 999) //tarkastetaan, että numero on annetulla välillä 0-99
            {
                Console.WriteLine("Numerosi on: " + NumeroKirjoitettuna(numero)); // alustetaan tulostettava teksi + viitataan aliohjelmaan, joka muuntaa annetun numeron tekstiksi
            }
            else
            {
                Console.WriteLine("Et antanut numeroa väliltä 0-999");
            }
        }
        static string NumeroKirjoitettuna(int numero) // aliohjelma, josta saadaan numerot sanoina/kirjaimina
        {
            if (numero == 0)
                return "nolla";

            string[] ykkoset = { "", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän" }; //taulukko, huom! eka tulee olla tyhjä, sillä taulukkojen laskenta alkaa 0, ja tässä tapauksessa haluamme sen alkavan 1, jotta indeksi osuu kohdilleen.
            string[] kymmenet = { "", "kymmenen", "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };
            string[] sadat = { "", "sata", "kaksisataa", "kolmesataa", "neljäsataa", "viisisataa", "kuusisataa", "seitsemänsataa", "kahdeksansataa", "yhdeksänsataa" };
            string[] muut = { "", "kymmenen", "yksitoista", "kaksitoista", "kolmetoista", "neljätoista", "viisitoista", "kuusitoista", "seitsemäntoista", "kahdeksantoista", "yhdeksäntoista" };

            string sana = ""; // alustetaan merkkijono, joka on aluksi tyhjä ja johon sana sitten tulee ja joka ns. palautetaan

            if ((numero / 100) > 0) // tarkastetaan, onko käyttäjän antamassa numerossa satoja
            {
                sana += sadat[numero / 100]; // tämä lisää sadat -taulukosta oikeasta indeksistä sanan alustettuun sana-merkkijonoon
                numero %= 100; // tämän avulla selvitetään, mitä ns. sadasta jää yli, eli ykköset ja kymmenet
            }
            if (numero > 0)
            {
                if (numero < 10) // tämän avulla alle 10 olevat numeron indeksi otetaan ykkoset -taulukon oikeasta indeksistä
                {
                    sana += ykkoset[numero]; // lisätään alustettuun merkkijonoon sana
                }
                else if (numero < 20) // jos numero on myös alle 20, tulee oikea ideksi ottaa muut -taulukosta
                {
                    sana += muut[numero - 10]; // lisätään alustettuun merkkijonoon sana, huom! vähennetään kymmenen, jotta indeksi osuu kohdalleen.
                }
                else
                {
                    sana += kymmenet[numero / 10]; // etsitään kymmenet, eli oikea indeksi kymmenet -taulukosta
                    if ((numero % 10) > 0) // tarkastetaan mitä kymmenestä jää yli, eli ykköset
                    {
                        sana += ykkoset[numero % 10]; // otetaan ykkoset -taulukosta oikea indeksi
                    }
                }
            }
            return sana; // aliohjelma palauttaa merkkijonon pääohjelmaan
        }
    }
}

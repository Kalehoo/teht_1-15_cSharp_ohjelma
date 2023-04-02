using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht_1_15_cSharp_ohjelma
{
    class Program
    {
        #region Aloitus / Start 
        // Määritetään sovellus aloittamaan luokasta Valikko()
        static void Main(string[] args)
        {
            bool naytaValikko = true;
            while (naytaValikko)
            {
                naytaValikko = Valikko();
            }


        }
        #endregion

        #region Julkiset muuttujat / Public Variables
        public class julkiset
        {
            // public static antaa käyttää muuttujia yli luokkien
            // public static lets us use variables over classes

            
            public static string pak_msg = "\nPaina mitä tahansa näppäintä jatkaaksesi...";
            public static string error_msg = "Jokin meni vikaan. Yritä uudelleen...";
            public static string[] list_T = {
            "(1) C# Valinta: Luvun vertailu",
            "(2) C# Valinta: Iän tarkastus",
            "(3) C# Valinta: Myyntihinnan laskeminen",
            "(4) C# Valinta: Parillinen vai pariton",
            "(5) C# Valinta: Luvun arvaus"};

        }

        #endregion

        #region Valikko / Menu
        // Luodaan valikko, joka ohjaa eri luokkiin switch-komennon kautta
        // Switch on syntaksi, joka määrittää vaihtoehdot eri koodeille mitä suoritetaan käyttäjän komennolla

        // Creating menu, that directs into different classes using syntax switch
        // Switch is a syntax, which defines different options for different code blocks by user selection

        private static bool Valikko()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Valitse vaihtoehto:");
            Console.ResetColor();
            foreach (string lista_T_full in julkiset.list_T)
            {
                Console.WriteLine(lista_T_full);
            }
            Console.WriteLine("(Q) Poistu");
            Console.Write("\r\nValitse vaihtoehto: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Tehtava1();
                    return true;
                case "2":
                    Tehtava2();
                    return true;
                case "3":
                    Tehtava3();
                    return true;
                case "4":
                    Tehtava4();
                    return true;
                case "5":
                    Tehtava5();
                    return true;
                case "Q":
                    return false;
                case "q":
                    return false;
                default:
                    return true;
            }
        }
        #endregion

        #region (1) C# Valinta: Luvun vertailu / Comparing Numbers
        // Tee ohjelma, joka kysyy käyttäjältä luvun / Create program, that asks number from user
        // Ohjelma ilmoittaa onko luku joko 0, pienempi tai suurempi kuin 0 / Program either declaers number being equal to 0, smaller or bigger that 0.
        public static void Tehtava1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(julkiset.list_T[0]);
            Console.ResetColor();

            bool luku1_Antamatta = true;
            while (luku1_Antamatta)
            {
                // Annetaan integerin minimi- ja maksimiarvo / Giving minimal and maximal value of integer
                int luku1_Min = -2147483648;
                int luku1_Max = 2147483647;
                
                Console.WriteLine("Sovellus vertaa syöttämääsi lukua lukuun 0.");
                Console.WriteLine($"Syötä Luku jota tahdot verrata ({luku1_Min} ja {luku1_Max} väliltä):");

                int vertaus_Luku = Convert.ToInt32(Console.ReadLine());

                // Ehto, mikäli luku täsmää arvojen väliin ja on suurempi kuin 0 / Condition if number matches between values and is bigger than 0
                if (vertaus_Luku >= luku1_Min && vertaus_Luku <= luku1_Max && vertaus_Luku > 0)
                {
                    Console.WriteLine($"Luku {vertaus_Luku} on suurempi kuin 0.");
                    luku1_Antamatta = false;
                    Console.WriteLine(julkiset.pak_msg);
                    Console.ReadKey();

                }
                // Ehto, mikäli luku täsmää arvojen väliin ja on pienempi kuin 0 / Condition if number matches between values and is smaller than 0
                else if (vertaus_Luku >= luku1_Min && vertaus_Luku <= luku1_Max && vertaus_Luku < 0)
                {
                    Console.WriteLine($"Luku {vertaus_Luku} on pienempi kuin 0.");
                    luku1_Antamatta = false;
                    Console.WriteLine(julkiset.pak_msg);
                    Console.ReadKey();

                }
                // Ehto, mikäli luku täsmää arvojen väliin ja on yhtä suuri kuin 0 / Condition if number matches between values and is equal to 0
                else if (vertaus_Luku >= luku1_Min && vertaus_Luku <= luku1_Max && vertaus_Luku == 0)
                {
                    Console.WriteLine($"Luku {vertaus_Luku} on yhtä suuri kuin 0");
                    luku1_Antamatta = false;
                    Console.WriteLine(julkiset.pak_msg);
                    Console.ReadKey();
                }

                // Muut tapaukset luovat virheen / Other cases causing error
                else
                {
                    Console.WriteLine(julkiset.error_msg);
                    luku1_Antamatta = true;
                    Console.WriteLine(julkiset.pak_msg);
                    Console.ReadKey();
                }

                
            }


        }
        #endregion
        #region (2) C# Valinta: Iän tarkastus / Checking Age
        //Tee ohjelma joka kysyy käyttäjältä ikää ja tarkistaa, että se on realistinen (vähintään 0 ja korkeintaan 120).
        //Create a program that ask age from user, and checks that being realistic (min 0 max 120).
        private static void Tehtava2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(julkiset.list_T[1]);
            Console.ResetColor();

            DateTime aika_tanaan = DateTime.Today;

            int vuosi_Int = Convert.ToInt32(DateTime.Today.Year);

            //Luodaan loop jonka aikana ikä on antamatta / Creating loop where age is not given
            bool ika_Antamatta = true;
            while (ika_Antamatta)
            {

                Console.WriteLine("Iän realistisuuden tarkistussovellus tarkistaa, \n onko syöttämäsi ikä realistinen.");
                Console.WriteLine("\n\n Syötä sovellukseen ikäsi:");

                int ika = Convert.ToInt32(Console.ReadLine());

                int ika_Min = 0;
                int ika_Max = 120;

                int syntymaVuosi = vuosi_Int - ika;
                int synt_Vuosi_Range_Min = syntymaVuosi - 1;

                if (ika >= ika_Min && ika <= ika_Max) // Ehto, joka testaa että annettu luku on ikähaarukassa / Condition, which tests given number being inside given min and max values
                {
                    Console.WriteLine($"Syöttämäsi ikä {ika} on realistinen.");
                    Console.WriteLine($"Eli olet syntynyt aikavälillä {synt_Vuosi_Range_Min} - {syntymaVuosi}");
                    Console.WriteLine(julkiset.pak_msg);
                    Console.ReadKey();
                    
                    // Ikä on annettu, irtaannutaan loopista / Age is given, which results to getting out from loop
                    ika_Antamatta = false;

                }
                else
                {
                    Console.WriteLine($"Syöttämäsi ikä {ika} on epärealistinen.");
                    Console.WriteLine(julkiset.pak_msg);
                    Console.ReadKey();

                    // Ikä on annettu, irtaannutaan loopista / Age is given, which results to getting out from loop
                    ika_Antamatta = false;
                }

            }


            Console.WriteLine();

        }
        #endregion
        #region (3) C# Valinta: Myyntihinnan laskeminen / Selling price check
        // Tuotteen myyntihinnasta annetaan alennusta 10% ja, jos hinta on yli 100 euroa alennus on 25%. Tee ohjelma joka laskee annetusta hinnasta tuotteen lopullisen myyntihinnan
        // Giving 10% discount from value of product, and if price is over 100 euroes discount is 25%. Create program which counts final selling price from value of the product.
        private static void Tehtava3()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(julkiset.list_T[2]);
            Console.ResetColor();

            //Annetaan alennuksille arvot desimaalilukuina / Giving values of discounts by decimals
            double myyntihinta_Alennus = 00.10;
            double yli100_Alennus = 00.25;
            double alennusSumma;

            //Luodaan string-arvo eri prosenteille / Creating string-values for different percents
            string[] alennukset_String = {"10%", "25%"};

            double lopullinen_Hinta;

            Console.WriteLine("Myyntihintalaskuri:");
            Console.WriteLine("Syötä tuotteen myyntihinta:");
            double hinta = Convert.ToDouble(Console.ReadLine());
                      
            // Ehto, jos hinta on alle 100€ / Condition if price is under 100€
            if (hinta < 100)
            {
                alennusSumma = hinta * myyntihinta_Alennus;
                lopullinen_Hinta = hinta - alennusSumma;
                Console.WriteLine($"Tuotteen hinta: {hinta} euroa. \nLopullinen myyntihinta = {lopullinen_Hinta} euroa. \nAlennus: {alennukset_String[0]}, eli {alennusSumma} euroa.");
                Console.WriteLine(julkiset.pak_msg);
                Console.ReadKey();

            }

            // Ehto, jos hinta on yhtä suuri tai yli 100 / Condition if price is equal or more than 100€
            if (hinta >= 100)
            {
                alennusSumma = hinta * yli100_Alennus;
                lopullinen_Hinta = hinta - alennusSumma;
                Console.WriteLine($"Tuotteen hinta: {hinta} euroa. \nLopullinne myyntihinta = {lopullinen_Hinta} euroa. \nAlennus: {alennukset_String[1]}, eli {alennusSumma} euroa.");
                Console.WriteLine(julkiset.pak_msg);
                Console.ReadKey();
            }


        }
        #endregion
        #region (4) C# Valinta: Parillinen vai pariton / Even or odd number
        /*Tee ohjelma, joka ilmoittaa onko käyttäjän antama luku parillinen vai pariton
        *Tässä tarvitsette %-operaattoria, ja kykyä hieman selvittää kuinka parillisuus saadaan selville ohjelmoinnissa
        * https://chsarp-station.com/´how-to-test-for-even-or-odd-numbers-in-c/
        * Create A program, which informs if number given by user is either odd or even
        * You need for this %-operator, and ability to find out how to find out even numbers in programming
        */

        private static void Tehtava4()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(julkiset.list_T[3]);
            Console.ResetColor();

            
            Console.WriteLine("Onko numero parillinen vai pariton?:");
            Console.WriteLine("\nSyötä tarkistettava numero:");
            int tarkistettava = Convert.ToInt32(Console.ReadLine());

            /* Tarkistetaan %-operaattorin avulla onko luku joko parillinen (2) vai yhtä suuri kuin 0
            *  Finding out with %-operator is value either even (2) or equal to 0 */

            if (tarkistettava%2 == 0)
            {
                Console.WriteLine("Numero on parillinen\n");
                Console.WriteLine(julkiset.pak_msg);
                Console.ReadKey();

            }
            // Muissa tapauksissa luku on pariton / In other cases value is odd 
            else
            {
                Console.WriteLine("Numero on pariton\n");
                Console.WriteLine(julkiset.pak_msg);
                Console.ReadKey();

            }
            

        }
        #endregion
        #region (5) C# Valinta: Luvun arvaus
        /* Tallenna ohjelmaan luku ja pyydä käyttäjää arvaamaan se luku. Jos käyttäjä arvasi oikein,
        * tulosta teksti "arvasit oikein". Jos käyttäjä ei arvannut oikein, kerro oliko arvaus liian suuri vai pieni
        * Register value to program and ask user to guess that value. If user guessed right,
        * print text "you guessed right". If user didn't guess right, tell user if guess was too small or big.
        */
        private static void Tehtava5()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(julkiset.list_T[4]);
            Console.ResetColor();

            // Määritellään arvattava luku, minimi- ja maksimi-arvo
            // Defining number to guess, min and max-values

            int luku_Arvattava = 47; // Arvattava luku
            int min_Luku = 0;
            int max_Luku = 100;

            //Määritellään vähäiset viestit array:n alle kivasti nippuun / Defining small amount of messages under array
            string[] msgs_Arvaus = {
                $"Arvaa mikä luku on kyseessä aina {min_Luku} ja {max_Luku} väliltä", // 0
                "\nSyötä luku minkä oletat arvattavan luvun olevan:", // 1
                $"Aivan oikein! Luku oli todellakin {luku_Arvattava}.", //2
                $"Väärä vastaus. Luku ei ollut oikein... " }; //3

            bool arpajaiset = true;

            while (arpajaiset)
            {
                Console.Clear();
                Console.WriteLine(msgs_Arvaus[0]); //0
                Console.WriteLine(msgs_Arvaus[1]); //1
                int arvaus = Convert.ToInt32(Console.ReadLine());

                if (arvaus == luku_Arvattava)
                {
                    Console.WriteLine(msgs_Arvaus[2]); //2

                    // Looppi on nyt pois päältä
                    // Loop is off for now

                    // Jos haluat määrittää tiettyjen tulosten heittävän käyttäjän takaisin looppiin, vaihda boolin arpajaiset arvoksi true
                    // IF you want to throw user back to loop, change bool arpajaiset to true
                    arpajaiset = false; 
                    
                    Console.WriteLine(julkiset.pak_msg);
                    Console.ReadKey();
                                        
                }
                else if (arvaus > luku_Arvattava)
                {
                    Console.WriteLine(msgs_Arvaus[3]); //3
                    Console.WriteLine($"Lukusi {arvaus} oli suurempi kuin arvattava numero.");

                    // -''-
                    arpajaiset = false;
                    
                    
                    Console.WriteLine(julkiset.pak_msg);
                    Console.ReadKey();
                }
                else if (arvaus < luku_Arvattava)
                {
                    Console.WriteLine(msgs_Arvaus[3]); //3
                    Console.WriteLine($"Lukusi {arvaus} oli pienempi kuin arvattava numero.");

                    // -''-
                    arpajaiset = false;


                    Console.WriteLine(julkiset.pak_msg);
                    Console.ReadKey();
                }

            }


            Console.WriteLine();
        }


    }
    #endregion

}

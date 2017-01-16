using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TehtavatVKO2
{
    class Program
    {
        static void Main(string[] args)
        {
            //teht1();
            //teht2();
            //teht3();
            //teht4();
            //teht5();
            //teht6();
            //teht7();kesken
            //teht8();
            //teht9();
            //teht10();
            //teht11();
            //teht12();
            //teht13();
            //teht14();
            //teht15();
            //teht16();
            //teht17();
            //teht18();
            teht19();
        }

        static void teht1()
        {
            int luku = 0;
            Console.Write("Anna luku > ");
            luku = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi.");
            }
            else if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi.");
            }
            else if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme.");
            }
            else
            {
                Console.WriteLine("Jokin muu luku.");
            }
            Console.WriteLine();
            Console.Write("Press enter to exit");
            Console.ReadLine();
        }
        static void teht2()
        {
            int[] numero = new int[12] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
            int pisteet;
            int pisteNumero = 0;

            Console.Write("Anna pistemäärä > ");
            pisteet = System.Convert.ToInt32(Console.ReadLine());
            pisteNumero = numero[pisteet];
            Console.WriteLine("Koulunumero on " + pisteNumero + ".");
            Console.WriteLine();
            Console.Write("Paina Enter lopettaaksesi");
            Console.Read();

        }
        static void teht2wanha()
        {
            int[] numero;
            numero = new int[6] { 0, 1, 2, 3, 4, 5 };
            int pisteet;
            int pisteNumero = 0;

            Console.Write("Anna pistemäärä > ");
            pisteet = System.Convert.ToInt32(Console.ReadLine());
            if (pisteet == 0 || pisteet == 1)
            {
                pisteNumero = numero[0];
            }
            Console.WriteLine("Koulunumero on " + pisteNumero + ".");
            Console.WriteLine();
            Console.Write("Paina Enter lopettaaksesi");
            Console.Read();

        }
        static void teht3()
        {
            int[] luvut = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Anna luku > ");
                luvut[i] = System.Convert.ToInt32(Console.ReadLine());
            }
            int summa = luvut[0] + luvut[1] + luvut[2];
            int keskiarvo = summa / 3;
            Console.WriteLine("Antamiesi lukujen summa on " + summa + ".");
            Console.WriteLine("Antamiesi lukujen keskiarvo on " + keskiarvo + ".");
            Console.Write("Paina Enter lopettaaksesi");
            Console.ReadKey();
        }
        static void teht4()
        {
            int ika;
            Console.Write("Anna ikäsi > ");
            ika = System.Convert.ToInt32(Console.ReadLine());
            if (ika < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            else if (18 <= ika && ika <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
            Console.ReadKey();
        }
        static void teht5()
        {
            int sekunnit;
            int minuutit = 0;
            int tunnit = 0;
            Console.Write("Anna sekunnit > ");
            sekunnit = System.Convert.ToInt32(Console.ReadLine());
            if (sekunnit >= 60)
            {
                minuutit = sekunnit / 60;
                sekunnit = sekunnit - minuutit * 60;
            }
            if (minuutit >= 60)
            {
                tunnit = minuutit / 60;
                minuutit = minuutit - tunnit * 60;
            }
            if (tunnit != 0)
            {
                Console.Write(tunnit + "h ");
            }
            if (minuutit != 0)
            {
                Console.Write(minuutit + "min ");
            }
            Console.WriteLine(sekunnit + "s");
            Console.ReadKey();
        }
        static void teht6()
        {
            Console.Write("Anna matka > ");
            double matka = System.Convert.ToDouble(Console.ReadLine());
            double kulutus = matka / 100 * 7.02;
            double hinta = kulutus * 1.595;
            Console.WriteLine("Bensaa kuluu " + kulutus + " litraa ja matka maksaa " + hinta + " euroa.");
            Console.ReadKey();
        }
        static void teht7()
        {
            Console.Write("Anna vuosi > ");
            int vuosi = System.Convert.ToInt32(Console.ReadLine());

        }
        static void teht8()
        {
            int[] luvut = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Anna luku > ");
                luvut[i] = System.Convert.ToInt32(Console.ReadLine());
            }
            if (luvut[0] >= luvut[1] && luvut[0] >= luvut[2])
            {
                Console.WriteLine("Suurin luku on " + luvut[0]);
            }
            else if (luvut[1] >= luvut[0] && luvut[1] >= luvut[2])
            {
                Console.WriteLine("Suurin luku on " + luvut[1]);
            }
            else
            {
                Console.WriteLine("Suurin luku on " + luvut[2]);
            }
            Console.ReadKey();
        }
        static void teht9()
        {
            bool jatka = true;
            int[] luvut = new int[100];
            int x = 0;
            int summa = 0;
            while (jatka == true)
            {
                Console.Write("Anna luku > ");
                luvut[x] = System.Convert.ToInt32(Console.ReadLine());
                if (luvut[x] == 0)
                {
                    jatka = false;
                }
                else
                {
                    x++;
                }
            }
            for (int i = 0; i <= x; i++)
            {
                summa = summa + luvut[i];
            }
            Console.WriteLine("Lukujen summa on " + summa);
            Console.ReadKey();
        }
        static void teht10()
        {
            int[] luvut = new int[9] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < 9; i++)
            {
                if (luvut[i] % 2 == 0)
                {
                    Console.WriteLine(luvut[i] + " HEP");
                }
                else
                {
                    Console.WriteLine(luvut[i]);
                }
            }
            Console.ReadKey();
        }
        static void teht11()
        {
            Console.Write("Anna luku > ");
            int luku = System.Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < luku; i++)
            {
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        //teht12 sort
        static void teht12()
        {
            int[] luvut = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna luku > ");
                luvut[i] = System.Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(luvut);
            Console.Write("Luvut ovat ");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(luvut[i]);
                if (i == 0)
                {

                }
                else
                {
                    Console.Write(", ");
                }
            }
            Console.ReadKey();
        }
        static void teht13()
        {
            int[] pisteet = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna pisteet > ");
                pisteet[i] = System.Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(pisteet);
            int pisteSumma = pisteet[1] + pisteet[2] + pisteet[3];
            Console.WriteLine("Kokonaispisteet " + pisteSumma);
            Console.ReadKey();
        }
        static void teht14()
        {
            int[] arvosanat = new int[10];
            int[] tahdet = new int[6];
            Console.WriteLine("Anna arvosanat väliltä 0-5.");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Anna arvosana > ");
                arvosanat[i] = System.Convert.ToInt32(Console.ReadLine());
                for (int x = 0; x < 6; x++)
                {
                    if (arvosanat[i] == x)
                    {
                        tahdet[x]++;
                    }
                }
            }

            Console.WriteLine();
            for (int y = 0; y < 6; y++)
            {
                Console.Write(y + ": ");
                for (int a = 0; a < tahdet[y]; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
        static void teht15wanha()
        {
            Console.Write("Anna luku > ");
            int kerrokset = System.Convert.ToInt32(Console.ReadLine());
            kerrokset = kerrokset - 2;
            int tahdet = 1 + kerrokset * 2;
            int tila = (tahdet - 1) / 2;
            int tilaOrg = tila;
            int[] tahdetTaulu = new int[kerrokset];
            string tahti = "*";

            for (int x = 0; x < kerrokset; x++)
            {
                for (int i = 0; i < tila; i++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y < tahdet; y++)
                {
                    Console.Write(tahti);
                }
                Console.WriteLine();
                tila = tila - 2;
            }
            Console.ReadKey();
        }
        static void teht15()
        {
            Console.Write("Anna luku > ");
            int luku = System.Convert.ToInt32(Console.ReadLine());
            int mluku = luku;
            int mlukuOrg = mluku;
            int tahdet = 1;
            int lisatahdet;

            for (int korkeus = 0; korkeus < luku - 2; korkeus++)
            {
                lisatahdet = 0;
                for (int y = 0; y < mluku - 3; y++)
                {
                    Console.Write(" ");
                }
                mluku--;
                for (int i = 0; i <= korkeus; i++)
                {
                    Console.Write("*");
                    lisatahdet++;
                }
                lisatahdet--;
                for (int x = 0; x < lisatahdet; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            for (int a = 0; a < 2; a++)
            {
                for (int y = 0; y < mlukuOrg - 3; y++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");

            }
            Console.ReadKey();
        }
        //teht16 random
        static void teht16()
        {
            Random rnd = new Random();
            int luku = rnd.Next(1, 101);  // 1 <= luku < 101
            int arvaus;
            bool oikein = false;
            while (oikein == false)
            {
                Console.Write("Arvaa luku > ");
                arvaus = System.Convert.ToInt32(Console.ReadLine());
                if (arvaus == luku)
                {
                    Console.WriteLine("Oikein!");
                    oikein = true;
                }
                else if (arvaus < luku)
                {
                    Console.WriteLine("Liian pieni");
                }
                else if (arvaus > luku)
                {
                    Console.WriteLine("Liian iso");
                }
            }
            Console.ReadKey();
        }
        static void teht17()
        {
            Random rnd = new Random();
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[10];
            for (int a = 0; a < 5; a++)
            {
                array1[a] = rnd.Next(1, 51);
            }
            for (int b = 0; b < 5; b++)
            {
                array2[b] = rnd.Next(1, 51);
            }
            for (int c = 0; c < 5; c++)
            {
                array3[c] = array1[c];
            }
            for (int c = 0; c < 5; c++)
            {
                array3[c + 5] = array2[c];
            }
            Array.Sort(array3);
            for (int d = 0; d < 10; d++)
            {
                Console.WriteLine(array3[d]);
            }
            Console.ReadKey();
        }
        static void teht18()
        {
            string lause = Console.ReadLine();
            int x = 0;
            char[] taulukko = lause.ToCharArray();
            for (int i = 0; i < lause.Length; i++)
            {
                if (char.IsLetterOrDigit(taulukko[i]))
                {
                    x++;
                }
            }
            char[] eivaleja = new char[x];
            char[] eivaleja2 = new char[x];
            int a = 0; ;
            for (int i = 0; i < lause.Length; i++)
            {
                if (char.IsLetterOrDigit(taulukko[i]))
                {
                    eivaleja[a] = taulukko[i];
                    a++;
                }
            }
            for (int b = 0; b < x; b++)
            {
                eivaleja2[b] = eivaleja[b];
            }
            Array.Reverse(eivaleja2);
            for (int c = 0; c < x; c++)
            {
                Console.Write(eivaleja2[c]);
            }
            Console.WriteLine();
            bool palindromi = true;
            bool[] palindromiTaulu = new bool[x];
            for (int c = 0; c < x; c++)
            {
                if (eivaleja[c] == eivaleja2[c])
                {
                    palindromiTaulu[c] = true;
                }

            }
            for (int c = 0; c < x; c++)
            {
                if (palindromiTaulu[c] == false)
                {
                    palindromi = false;
                }
            }
            if (palindromi == true)
            {
                Console.WriteLine("Kirjoitit palindromin!");
            }
            else
            {
                Console.WriteLine("ei ole palindromi");
            }
            Console.ReadKey();
        }
        static void teht19()
        {
            String sana = "mato";
            char[] sanaTaulu = sana.ToCharArray();
            char[] sanaArvaus = new char[5];
            char[] hirsi = new char[5];
            String hirsiSana = "XXXXX";
            char[] h1 = hirsiSana.ToCharArray();
            Console.WriteLine("*** Hirsipuu ***");
            Console.WriteLine("----------------");
            Console.WriteLine();
            String arvaus;
            char[] kirjain;
            int havisit = 0;
            //while(havisit < 4)
            //{
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hirsi:");
                for (int a = 0; a < 4; a++)
                {
                    Console.Write(hirsi[a]);
                    havisit++;
                }
                Console.WriteLine();
                Console.Write("Sana: ");
                for (int b = 0; b < 4; b++)
                {
                    Console.Write(sanaArvaus[b]);
                }
                Console.WriteLine();
                Console.Write("Arvaa seuraava kirjain > ");
                arvaus = Console.ReadLine();
                kirjain = arvaus.ToCharArray();
                if (kirjain[i] != sanaTaulu[i])
                {
                    hirsi[i] = h1[i];
                    i--;
                }
                else
                {
                    sanaArvaus[i] = sanaTaulu[i];
                }
                //}
                Console.ReadKey();

            }



        }
    }
}
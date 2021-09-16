using System;
using System.Collections;

namespace Prog_ora_09_16
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Első feladat
            bool siker = false;
            int a = 0, b = 0;

            do {
                Console.WriteLine("Adja meg az első számot:");
                Console.WriteLine(" ");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    siker = true;
                }
                catch
                {
                    Console.WriteLine("Nem jó értéket adott meg");
                }
            } while (!siker);

            siker = false;
            Console.WriteLine(" ");

            do
            {
                Console.WriteLine("Adja meg a második számot:");
                Console.WriteLine(" ");
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                    if (b == 0)
                    {
                        Console.WriteLine("A második szám értéke nem lehet nulla"); 
                    }
                    else
                    {
                        siker = true;
                    }  
                }
                catch
                {
                    Console.WriteLine("Nem jó értéket adott meg");
                }
            } while (!siker);
            Console.WriteLine(" ");

            int osszeg = a + b;
            int kulonbseg = a - b;
            int szorzat = a * b;
            int hanyados = a / b;

            Console.WriteLine("A megadott számok összege {0}", osszeg);
            Console.WriteLine("A megadott szamok különbsége {0}", kulonbseg);
            Console.WriteLine("A megdott számok szorzata {0}", szorzat);
            Console.WriteLine("A megadott szamo hányadosa {0}", hanyados);
            */

            /* Második feladat
            bool siker = false;
            int szulev = 0, kor = 0;
            string nev;

            DateTime ev = DateTime.Now;

            Console.WriteLine("Adja meg a nevét:");
            nev = Convert.ToString(Console.ReadLine());
            do {
                Console.WriteLine("Adja meg a születési évét:");
                try
                {
                    szulev = Convert.ToInt32(Console.ReadLine());

                    if (ev.Year < szulev)
                    {
                        Console.WriteLine("Nem jó születési időt adott meg!");
                    }
                    else{
                        siker = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Nem a születési dátumát adta meg!");
                }
            } while (!siker);

            Console.Clear();

            kor = ev.Year - szulev;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(Console.WindowWidth/2-nev.Length/2,Console.WindowHeight/2 - 1);
            Console.WriteLine(nev);
            Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.WindowHeight / 2 - 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} éves",kor);

            Console.ReadKey(); 
            */

            /* Harmadik feladat
            bool siker = false;
            int meret = 0, i, j, a=0;
            Random rsz = new Random();

            
            do
            {
                Console.WriteLine("Adja meg a tömb méretét:");
                Console.WriteLine(" ");
                try
                {
                    meret = Convert.ToInt32(Console.ReadLine());
                    siker = true;
                }
                catch
                {
                    Console.WriteLine("Nem számot adott meg!");
                }

            } while (!siker);

            int[] tomb = new int[meret];

            Console.WriteLine("A tömb elemei:");
            for (i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rsz.Next(0, 100);
                Console.WriteLine(tomb[i]);
            }

            Console.WriteLine("A tömb elemei növekvő sorrendben:");
            for (i = 0; i < tomb.Length; i++)
            {
                for (j=i; j<tomb.Length; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        a = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = a;
                    }
                }
                Console.WriteLine(tomb[i]);
            }
            */

            bool siker = false;
            int meret = 0, i, osszeg=0, lk=0, ln=0;
            Random rsz = new Random();


            do
            {
                Console.WriteLine("Adja meg a lista méretét:");
                Console.WriteLine(" ");
                try
                {
                    meret = Convert.ToInt32(Console.ReadLine());
                    siker = true;
                }
                catch
                {
                    Console.WriteLine("Nem számot adott meg!");
                }

            } while (!siker);

            var lista = new ArrayList();

            Console.WriteLine("A lista elemei:");
            for (i=0; i<meret; i++)
            {
                lista.Add(rsz.Next(0, 100));
                osszeg += Convert.ToInt32(lista[i]);
                if (i == 0)
                {
                    lk = Convert.ToInt32(lista[i]); 
                    ln = Convert.ToInt32(lista[i]); 
                }

                if (lk > Convert.ToInt32(lista[i]))
                {
                    lk = Convert.ToInt32(lista[i]); ;
                }

                if (ln < Convert.ToInt32(lista[i]))
                {
                    ln = Convert.ToInt32(lista[i]); ;
                }

                Console.WriteLine(lista[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("A lista elemeinek az összege {0}",osszeg);
            Console.WriteLine("A lista elemeinek az átalga {0}", osszeg/meret);
            Console.WriteLine("A legnagobb szám {0}", ln);
            Console.WriteLine("A legkissebb szám {0}", lk);
        }
    }
}

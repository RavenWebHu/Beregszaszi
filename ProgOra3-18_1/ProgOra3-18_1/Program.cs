using System;
using System.IO;
using System.Text;

namespace ProgOra3_18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ertek = true;
            int i;
            string adat = "";

            //Olvasás
            StreamWriter iras = new StreamWriter("E:\\adatok.txt", true, Encoding.UTF8);
            

            do
            {
                adat = "";
                for (i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("Add meg a neved:");
                            break;
                        case 1:
                            Console.WriteLine("Add meg a születési dátudom:");
                            break;
                        case 2:
                            Console.WriteLine("Add meg a nemed:");
                            break;
                        case 3:
                            Console.WriteLine("Add meg a bulizási hajlamod:");
                            break;
                        default:
                            break;
                    }
                    adat = Console.ReadLine();
                    if (adat == "")
                    {
                        ertek = false;
                        break;
                    }
                    else
                    {
                            iras.Write(adat + ";");
                    }
                    
                }
                iras.WriteLine(" ");
            } while (ertek);
            

            //Beolvasás

            StreamReader olvas = new StreamReader("E:\\adatok.txt");
            

            while (adat != null)
            {
                adat = olvas.ReadLine();
                Console.WriteLine(adat);
                olvas.Close();
            }


        }
    }
}

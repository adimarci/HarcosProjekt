using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace HarcosProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a harcos nevét: ");
            string harcosnev = Console.ReadLine();
            
            Console.Write("Státusza: ");
            int statusz = Convert.ToInt32(Console.ReadLine());

            Harcos harcos1 = new Harcos(harcosnev,statusz);
            Console.WriteLine("Az ön harcosa:"+harcos1);

            List<Harcos> harcosLista = new List<Harcos>();
            Harcos harcos2 = new Harcos("Pokak",1);
            harcosLista.Add(harcos2);

            Harcos harcos3 = new Harcos("Pepa", 2);
            harcosLista.Add(harcos3);

            Harcos harcos4 = new Harcos("Adaj", 3);
            harcosLista.Add(harcos4);

            string sor;
            System.IO.StreamReader file =
                new System.IO.StreamReader("harcosok.txt");
            while ((sor = file.ReadLine()) != null)
            {
                string[] split = sor.Split(',');
                harcosLista.Add(new Harcos(split[0],Convert.ToInt32(split[1])));
            }
            file.Close();

            int sorszam=0;
            foreach  (Harcos f in harcosLista)
            {
                sorszam++;
                Console.WriteLine(sorszam +" - "+f);
            }


            string menupontok;
            Random rnd = new Random();

            Console.WriteLine("Válasszon műveletet: \n \t a) Megküzdeni" + "\n \t b) Gyógyulni \n \t c)Kilépni");
            menupontok = Convert.ToString(Console.ReadLine());
            do
            {
                
                while (menupontok != "a" && menupontok != "b" && menupontok != "c")
                {
                    Console.WriteLine("Nem jó menüpontot adott meg kérem adja meg újra:");
                    menupontok = Convert.ToString(Console.ReadLine());
                }

                if (menupontok=="a")
                {
                    Console.WriteLine("Hanyadik harcossal szeretne megküzdeni");
                    sorszam = 0;
                    foreach (Harcos f in harcosLista)
                    {
                        
                        sorszam++;
                        Console.WriteLine(sorszam + " - " + f);
                    }
                   
                    int valasztottharcossorszama =Convert.ToInt32( Console.ReadLine());

                    harcos1.Megkuzd(harcosLista[valasztottharcossorszama -1]);

                    Console.WriteLine("Válasszon műveletet: \n \t a) Megküzdeni" + "\n \t b) Gyógyulni \n \t c)Kilépni");
                    menupontok = Convert.ToString(Console.ReadLine());
                }
               


            } while (menupontok != "c");

            {
                Environment.Exit(0);
            }


            Console.ReadKey();

           }
            
        }
    }


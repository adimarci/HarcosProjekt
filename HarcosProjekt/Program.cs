using System;
using System.Collections.Generic;
using System.Linq;
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
            
            Console.WriteLine("Státusza: ");
            int statusz = Convert.ToInt32(Console.ReadLine());

            Harcos harcos1 = new Harcos(harcosnev,statusz);
            Console.WriteLine(harcos1);

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

            foreach(Harcos f in harcosLista)
            {
                Console.WriteLine(f);
            }

            Console.ReadKey();



        
           }
            
        }
    }


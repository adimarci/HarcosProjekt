﻿using System;
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
            Harcos Jani = new Harcos("Jani",1);
            Console.WriteLine(Jani);
            Harcos MasikHarcos = new Harcos("Pokak",2);
            Jani.Megkuzd(MasikHarcos);
            Jani.Gyogyul(Jani);
            
            Console.ReadKey();
        }
    }
}

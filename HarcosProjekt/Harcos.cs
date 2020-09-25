using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Harcos
    {
        private string nev;
        private int szint;
        private int tapasztalat;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;

        public Harcos(string nev, int szint, int tapasztalat, int eletero, int alapEletero, int alapSebzes)
        {
            this.Nev = nev;
            this.Szint = szint;
            this.Tapasztalat = tapasztalat;
            this.Eletero = eletero;
            this.alapEletero = alapEletero;
            this.alapSebzes = alapSebzes;
        }

        public Harcos(string nev, int statuszSablon)
        {
            nev = this.Nev;
            this.szint = 1;
            this.tapasztalat = 0;
            if (statuszSablon == 1)
            {
                alapEletero = 15;
                alapSebzes = 3;

            }else if (statuszSablon == 2)
            {
                alapEletero = 12;
                alapSebzes = 4;
            }else if (statuszSablon==3)
            {
                alapEletero = 8;
                alapSebzes = 5;
            }
            else
            {
                alapEletero = MaxEletero;
            }

        }


        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int AlapEletero { get => alapEletero;}
        public int AlapSebzes { get => alapSebzes;}
        public int Sebzes { get => alapSebzes + szint; }
        public int SzintLepeshez { get => 10 + szint * 5; }
        public int MaxEletero { get => AlapEletero + szint * 3; }

       

        public override string ToString()
        {
            return string.Format("");
        }
    
    
    
    }
}

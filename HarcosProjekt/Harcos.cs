using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
            this.Nev = nev;
            this.szint = 1;
            this.tapasztalat = 0;
            alapEletero = MaxEletero;
            
            if (statuszSablon == 1)
            {
                alapEletero = 12;
                alapSebzes = 3;

            } else if (statuszSablon == 2)
            {
                alapEletero = 9;
                alapSebzes = 4;
            } else if (statuszSablon == 3)
            {
                alapEletero = 5;
                alapSebzes = 5;
            }

            this.eletero = MaxEletero;



        }

        public void Megkuzd(Harcos MasikHarcos)
        {
            if (this.nev == MasikHarcos.nev)
            {
                Console.WriteLine("UGYANAZ A NEVE");
            } else if (MasikHarcos.eletero == 0)
            {
                Console.WriteLine("MEGHALT" + MasikHarcos.nev);
            }
            else
            {
                Console.WriteLine("TÁMADÁS");
                if (this.eletero > 0)
                {
                    MasikHarcos.eletero -= this.AlapSebzes;
                    MasikHarcos.tapasztalat += 5;
                    Console.WriteLine(MasikHarcos.nev + " Életereje: " + MasikHarcos.eletero + "tapasztalata:" + this.tapasztalat);

                }

                if (MasikHarcos.eletero > 0)
                {
                    this.eletero -= MasikHarcos.Sebzes;

                    this.tapasztalat += 5;
                    Console.WriteLine(this.nev + " Életereje: " + this.eletero + "tapasztalata:" + this.tapasztalat);
                }
                if (MasikHarcos.eletero == 0)
                {
                    this.tapasztalat += 10;
                    Console.WriteLine("Megölte" + MasikHarcos.nev + "-t tapasztalata:" + this.tapasztalat);

                }
                if (this.eletero == 0)
                {
                    MasikHarcos.tapasztalat += 10;
                    Console.WriteLine("Megölte" + this.nev + "-t tapasztalata:" + MasikHarcos.tapasztalat);

                }
            }
        }

        public void Gyogyul()
        {
            
            if (eletero==0)
            {
                eletero = MaxEletero;
                Console.WriteLine("Életerő visszatöltve,jelenlegi életerő: "+eletero);
            }
            else if(eletero>=MaxEletero)
            {
                Console.WriteLine("Maximum életerőn van");
                eletero = MaxEletero;
            }
            else
            {
                eletero += 3;
                Console.WriteLine("Gyógyult,jelenlegi életerő: " + eletero);
            }
        }


        public string Nev { get => nev; set => nev = value; }


        public int Szint
        {
            get => szint; set
            {
                if (value == szint + 1 && tapasztalat >= SzintLepeshez)
                {
                    tapasztalat -= SzintLepeshez;
                    szint++;
                    eletero = MaxEletero;
                }
            }
        }
        public int Tapasztalat
        {
            get => tapasztalat;
            set
            {
                tapasztalat = value;

                if (tapasztalat>=SzintLepeshez)
                {
                    szint++;
                }

            }
        }

        public int Eletero
        {
            get
            {
                return eletero;
            }
            set
            {
                if (eletero!=0)
                {
                    eletero = value;
                }else if (eletero > MaxEletero)
                {
                    eletero = MaxEletero;
                }
                else
                {
                    eletero = value;
                    tapasztalat = 0;
                }
            }
        }
        
        public int AlapEletero { get => alapEletero;}
        public int AlapSebzes { get => alapSebzes;}
        public int Sebzes { get => alapSebzes + szint; }
        public int SzintLepeshez { get => 10 + szint * 5; }
        public int MaxEletero { get => AlapEletero + szint * 3; }

       

        public override string ToString()
        {
            return string.Format("{0} – LVL: {1} – EXP: {2} /{3} – HP:{4} /{5} – DMG: {6}",nev,szint,tapasztalat,SzintLepeshez,eletero,MaxEletero,Sebzes);
        }
    
    
    
    }
}

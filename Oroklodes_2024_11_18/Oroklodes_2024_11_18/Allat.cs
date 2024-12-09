using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_2024_11_18
{
    enum Nem
    {
        hím,
        nőstény
    }
    abstract class Allat
    {
        protected string szin;
        protected  Nem nem;
        protected string nev;
        protected int kor;
        protected int egyediazon;

        public string Nev { get => nev;  }
        protected int Kor { get => kor; set => kor = value; }

        public Allat(string nev,int kor,string szin,Nem nem)
        {
            this.nev = nev;
            this.kor = kor;
            this.szin = szin;
            this.nem = nem;

        }
        public virtual string HangotAd()
        {
            return "";
        }
        public override string ToString()
        {
            string kiiras = $"Név {this.nev}, kor: {this.kor}, szín{this.szin},Nem {this.nem}";
            return kiiras; 
        }
        public void Oregszik()
        {
            this.kor++;
        }
    }
}

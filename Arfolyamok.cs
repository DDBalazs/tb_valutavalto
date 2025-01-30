using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tb_valutavalto_20250128
{
    internal class Arfolyamok
    {
        private string devkod;
        private int egyseg;
        private double arf;

        public string Devkod { get => devkod; set => devkod = value; }
        public int Egyseg { get => egyseg; set => egyseg = value; }
        public double Arf { get => arf; set => arf = value; }
    
    public Arfolyamok(string sor)
        {
            string[] dbok = sor.Split(';');
            devkod = dbok[0];
            egyseg = Convert.ToInt32(dbok[1]);
            arf = Convert.ToDouble(dbok[2]);
        }
    }
}

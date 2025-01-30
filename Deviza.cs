using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tb_valutavalto_20250128
{
    internal class Deviza
    {
        string devegy;
        string devnev;
        public string Devegy { get => devegy; set => devegy = value; }
        public string Devnev { get => devnev; set => devnev = value; }
    
        public Deviza(string sor)
        {
            string[] dbok = sor.Split(';');
            devegy = dbok[0];
            devnev = dbok[1];
        }

        public string nevVissza()
        {
            return devegy + " - " + devnev;
        }

    }
}

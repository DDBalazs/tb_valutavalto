using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tb_valutavalto_20250128
{
    public partial class frmvalutavaltas : Form
    {
        List<Deviza> devnemeklista = new List<Deviza>();
        List<Arfolyamok> arfolyamlista = new List<Arfolyamok>();
        void devbetoltes()
        {
            devnemeklista.Clear();
            FileStream fs = new FileStream("..\\..\\src\\devizanemek.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                Deviza d = new Deviza(sr.ReadLine());
                devnemeklista.Add(d);
            }
            sr.Close();
            fs.Close();

            arfolyamlista.Clear();
            fs = new FileStream("..\\..\\src\\arfolyamok.txt", FileMode.Open);
            sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                Arfolyamok a = new Arfolyamok(sr.ReadLine());
                arfolyamlista.Add(a);
            }
            sr.Close();
            fs.Close();

            for(int i = 0; i < arfolyamlista.Count; i++)
            {
                int j = 0;
                while (arfolyamlista[i].Devkod != devnemeklista[j].Devegy)
                {
                    j = j + 1;
                }
                dbdeviza.Items.Add(devnemeklista[j].nevVissza());
            }
        }
        public frmvalutavaltas()
        {
            InitializeComponent();
        }

        private void frmvalutavaltas_Load(object sender, EventArgs e)
        {
            devbetoltes();
        }

        private void dbdeviza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

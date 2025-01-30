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
    public partial class frmarfolyam : Form
    {
        void devizaBetoltes()
    {
        List<Deviza> lista = new List<Deviza>();
        FileStream fs = new FileStream("..\\..\\src\\devizanemek.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        while (!sr.EndOfStream)
        {
            Deviza d = new Deviza(sr.ReadLine());
            lista.Add(d);
        }
        sr.Close();
        fs.Close();

        if (File.Exists("..\\..\\src\\arfolyamok.txt"))
        {
            List<string> arflista = new List<string>();
            fs = new FileStream("..\\..\\src\\arfolyamok.txt", FileMode.Open);
            sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] darabok = sor.Split(';');
                arflista.Add(darabok[0]);
            }
            sr.Close();
            fs.Close();
            for (int i = 0; i < lista.Count; i++)
            {
                if (!arflista.Contains(lista[i].Devegy))
                {
                    cbdevnem.Items.Add(lista[i].nevVissza());
                }
            }
        }
        else
        {
            for (int i = 0; i < lista.Count; i++)
            {
                cbdevnem.Items.Add(lista[i].nevVissza());
            }
        }
    }

        public frmarfolyam()
        {
            InitializeComponent();
        }

        private void frmarfolyam_Load(object sender, EventArgs e)
        {
            devizaBetoltes();
        }

        private void txdevegy_TextChanged(object sender, EventArgs e)
        {
            if (txdevegy.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txdevegy.Text);
                }
                catch
                {
                    MessageBox.Show("Egész számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txdevegy.Clear();
                    txdevegy.Focus();
                }
            }
        }

        private void txdevhuf_TextChanged(object sender, EventArgs e)
        {
            if (txdevhuf.TextLength > 0)
            {
                try
                {
                    double szam = Convert.ToDouble(txdevhuf.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txdevhuf.Clear();
                    txdevhuf.Focus();
                }
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (cbdevnem.SelectedItem == null)
            {
                MessageBox.Show("Adja meg a deviza nemet", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbdevnem.Focus();
            }
            else if (txdevegy.TextLength == 0)
            {
                MessageBox.Show("Adja meg a váltási egységet", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txdevegy.Focus();
            }
            else if (txdevhuf.TextLength == 0)
            {
                MessageBox.Show("Adja meg az árfolyamot (HUF)", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txdevhuf.Focus();
            }
            else
            {
                string devkod = cbdevnem.Text;
                devkod = devkod.Substring(0, 3);
                if (File.Exists("..\\..\\src\\arfolyamok.txt"))
                {
                    FileStream fs = new FileStream("..\\..\\src\\arfolyamok.txt", FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write("\n" + devkod + ";" + txdevegy.Text + ";" + txdevhuf.Text);
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("Sikeres adatmódosítás!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txdevhuf.Clear();
                    txdevegy.Clear();
                    cbdevnem.SelectedIndex = 0;
                }
                else
                {
                    FileStream fs = new FileStream("..\\..\\src\\arfolyamok.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(devkod + ";" + txdevegy.Text + ";" + txdevhuf.Text);
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("Sikeres adatmódosítás!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txdevhuf.Clear();
                    txdevegy.Clear();
                    cbdevnem.SelectedIndex = 0;
                }
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            DialogResult uzenet = new DialogResult();
            uzenet = MessageBox.Show("Biztosan elszeretné vetni?", "Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (uzenet == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}

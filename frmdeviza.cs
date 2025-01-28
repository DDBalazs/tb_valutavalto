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
    public partial class frmdeviza : Form
    {
        public frmdeviza()
        {
            InitializeComponent();
        }
        bool ellenorzes()
        {
            if (File.Exists("..\\..\\src\\devizanemek.txt"))
            {
                FileStream fs = new FileStream("..\\..\\src\\devizanemek.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                bool vane = false;

                while (!sr.EndOfStream)
                {
                    string elso = sr.ReadLine();
                    string[] darabok = elso.Split(';');
                    if (darabok[0] == txdevkod.Text)
                    {
                        vane = true;
                    }
                }
                sr.Close();
                fs.Close();
                if (vane == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txdevkod_TextChanged(object sender, EventArgs e)
        {
            if(txdevkod.Text.Length == 3)
            {
                if (ellenorzes())
                {
                    MessageBox.Show("EZ a devizanem már létezik!","HIBA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txdevkod.Clear();
                    txdevkod.Focus();
                }
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            DialogResult uzenet = new DialogResult();
            uzenet = MessageBox.Show("Biztosan elszeretné vetni?", "Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(uzenet == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if(txdevkod.Text.Length < 3)
            {
                MessageBox.Show("Nem adta meg a deviza kódot","HIBA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txdevkod.Focus();
            }
            else if(txdevnev.Text.Length == 0)
            {
                MessageBox.Show("Nem adta meg a deviza nevét!","HIBA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txdevnev.Focus();
            }
            else
            {
                if (File.Exists("..\\..\\src\\devizanemek.txt")){
                    FileStream fs = new FileStream("..\\..\\src\\devizanemek.txt", FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write("\n"+txdevkod.Text+";"+txdevnev.Text);

                    sw.Close();
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream("..\\..\\src\\devizanemek.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(txdevkod.Text + ";" + txdevnev.Text);

                    sw.Close();
                    fs.Close(); 
                }
                txdevkod.Clear();
                txdevnev.Clear();
                MessageBox.Show("Sikeres adatfeltöltés!", "SIKER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

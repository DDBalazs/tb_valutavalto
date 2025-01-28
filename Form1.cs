using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tb_valutavalto_20250128
{
    public partial class FoForm : Form
    {
        public FoForm()
        {
            InitializeComponent();
        }

        private void msexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void msdevrog_Click(object sender, EventArgs e)
        {
            frmdeviza ujdeviza = new frmdeviza();
            ujdeviza.ShowDialog();
        }

        private void msarfolyam_Click(object sender, EventArgs e)
        {
            frmarfolyam arfolyam = new frmarfolyam();
            arfolyam.ShowDialog();
        }
    }
}

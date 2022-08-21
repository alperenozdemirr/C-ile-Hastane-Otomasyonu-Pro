using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnAcil_Click(object sender, EventArgs e)
        {    
            AcilVeri acil = new AcilVeri();
            acil.ShowDialog();
        }
        private void btnRandevu_Click(object sender, EventArgs e)
        {
            RandevuMuayne muayne = new RandevuMuayne();
            muayne.ShowDialog();
        }
    }
}

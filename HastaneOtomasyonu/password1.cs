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
    public partial class password1 : Form
    {
        public password1()
        {
            InitializeComponent();
        }
        public string User = "admin";
        public string Password = "admin";


        
        private void password1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUser.Text == User && tbxPassword.Text == Password)
            {

               //Giris.ShowDialog();
                tbxOnay.Text = "Giriş Doğrulandı";
                tbxOnay.ForeColor = Color.Green;

            }
            else
            {
                tbxOnay.Text = "Bilgiler Hatalı!!!";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else { tbxPassword.PasswordChar = '*'; }
        }
    }
}

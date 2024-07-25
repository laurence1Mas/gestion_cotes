using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cotes
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (username == "admin" && password == "agate")
            {
                Form1 home1 = new Form1();
                frmlogin lg = new frmlogin();
                this.Hide();
                home1.Show();
            }
            else if (username == "" && password == "")
            {
                MessageBox.Show("veillez remplir les champs", "user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("mot de pass incorect", "user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

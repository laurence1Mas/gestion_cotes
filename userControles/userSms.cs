using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cotes.userControles
{
    public partial class userSms : UserControl
    {
        classes.clsrelever clsr = new classes.clsrelever();
        public userSms()
        {
            InitializeComponent();
        }
        public void loardlist()
        {
            dgsms.DataSource = clsr.getsms();
        }
        private void userSms_Load(object sender, EventArgs e)
        {
            loardlist();
        }

        private void dgsms_DoubleClick(object sender, EventArgs e)
        {
            if (dgsms.RowCount > 0)
            {
                txtnumero.Text = dgsms["dgcodeetudiant", dgsms.CurrentRow.Index].Value.ToString();
                txtetudiant.Text = dgsms["dgetudiant", dgsms.CurrentRow.Index].Value.ToString();
                txtmoyenne.Text = dgsms["dgmoyennee", dgsms.CurrentRow.Index].Value.ToString();
                txtmension.Text = dgsms["dgmension", dgsms.CurrentRow.Index].Value.ToString();
                txtannee.Text = dgsms["dgannee", dgsms.CurrentRow.Index].Value.ToString();
                txttelephone.Text = dgsms["dgtelephone", dgsms.CurrentRow.Index].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                if(txtnumero.Text != null && txtetudiant.Text != null && txtmoyenne.Text != null && txtmension.Text != null && txtannee.Text != null && txttelephone.Text != null && txttelephone.MaxLength >= 10)
            clsr.SendSMS("COM4", txtetudiant.Text, txttelephone.Text, txtmoyenne.Text, txtmension.Text, txtannee.Text);
            MessageBox.Show("Operation effectuée avec succès", "sms", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation non effectuée avec succès", "sms", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

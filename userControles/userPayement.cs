using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace gestion_cotes.userControles
{
    public partial class userPayement : UserControl
    {
        classes.ClsPayement clspa = new classes.ClsPayement();
        classes.Clsinscription clsinsc = new classes.Clsinscription();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userPayement()
        {
            InitializeComponent();
            loadlist();
        }

        public void refresh()
        {
            txtcode.Text = "";
            cmbinscription.Text = "";
            txtmontant.Text = "";
            datepayement.Text = "";
        }
        private void bindingclass()
        {
            clspa.Codepayement = txtcode.Text;
            clspa.Refinscription = Convert.ToString(cmbinscription.SelectedValue);
            clspa.Montantp = Convert.ToDecimal(txtmontant.Text);
            clspa.Datepayement = Convert.ToDateTime(datepayement.Text);
        }
        private void loadlist()
        {
            dgpayement.DataSource = clspa.getpayement();
            cmbinscription.DataSource = clsinsc.getInscription();
            cmbinscription.ValueMember = "codeinscription";
            cmbinscription.DisplayMember = "refetudiant";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userPayement_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clspa.Ajoutepayement(clspa);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "payement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "payement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clspa.Modifierpayement(clspa);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "payement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "payement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void dgpayement_DoubleClick(object sender, EventArgs e)
        {
            if(dgpayement.RowCount > 0)
            {
                txtcode.Text = dgpayement["dgcode", dgpayement.CurrentRow.Index].Value.ToString();
                cmbinscription.Text = dgpayement["dgrefinscription", dgpayement.CurrentRow.Index].Value.ToString();
                txtmontant.Text = dgpayement["dgmontant", dgpayement.CurrentRow.Index].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reports.recupayement rpt = new reports.recupayement();
            rpt.DataSource = M.get_Report_recu("Vrecupayement", "codepayement", txtcode.Text);
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}

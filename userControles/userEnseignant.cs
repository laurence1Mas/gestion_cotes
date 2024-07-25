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
    public partial class userEnseignant : UserControl
    {
        classes.Clsenseignant enseis = new classes.Clsenseignant();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userEnseignant()
        {
            InitializeComponent();
            loadlist();
        }

        public void refresh()
        {
            txtcode.Text = "";
            txtnom.Text = "";
            cmbgenre.Text = "";
            cmbetat.Text = "";
            txtadresse.Text = "";
            txtnumero.Text = "";
            txtmail.Text = "";
        }
        private void bindingclass()
        {
            enseis.Codeenseignant = txtcode.Text;
            enseis.Noms = txtnom.Text;
            enseis.Genre = Convert.ToString(cmbgenre.SelectedItem);
            enseis.Etat_civil = Convert.ToString(cmbetat.SelectedItem);
            enseis.Adresse = txtadresse.Text;
            enseis.Numero = txtnumero.Text;
            enseis.Mail = txtmail.Text;
        }
        private void loadlist()
        {
            dgenseignant.DataSource = enseis.getenseignant();
        }
        private void userEnseignant_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = enseis.Ajouteenseigant(enseis);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "inscription", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = enseis.Modifierenseignant(enseis);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "enseignant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "enseignant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = enseis.supprimerenseigant(enseis);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "enseignant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "enseignant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void dgenseignant_DoubleClick(object sender, EventArgs e)
        {
            if(dgenseignant.RowCount > 0)
            {
                txtcode.Text = dgenseignant["dgcode", dgenseignant.CurrentRow.Index].Value.ToString();
                txtnom.Text= dgenseignant["dgnom", dgenseignant.CurrentRow.Index].Value.ToString();
                cmbgenre.Text= dgenseignant["dggenre", dgenseignant.CurrentRow.Index].Value.ToString();
                cmbetat.Text= dgenseignant["dgetat", dgenseignant.CurrentRow.Index].Value.ToString();
                txtadresse.Text= dgenseignant["dgadresse", dgenseignant.CurrentRow.Index].Value.ToString();
                txtnumero.Text= dgenseignant["dgnumero", dgenseignant.CurrentRow.Index].Value.ToString();
                txtmail.Text= dgenseignant["dgmail", dgenseignant.CurrentRow.Index].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reports.ex2 rpt = new reports.ex2();
            rpt.DataSource = M.get_Report_ens();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}

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
using gestion_cotes.reports;

namespace gestion_cotes.userControles
{
    public partial class userEtudiant : UserControl
    {
        classes.Clsetudiant etu = new classes.Clsetudiant();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userEtudiant()
        {
            InitializeComponent();
            loardlist();
        }
        public void refresh()
        {
            txtcode.Text = "";
            txtnom.Text= "";
            txtpostnom.Text = "";
            txtprenom.Text = "";
            cmbgenre.Text = "";
            cmbetat.Text = "";
            txtlieu.Text = "";
            datenais.Text = "";
            txtadresse.Text = "";
            txtnumero.Text = "";
            txtmail.Text = "";
        }
        private void bidingclass()
        {
            etu.Codeetudiant =txtcode.Text;
            etu.Nom = txtnom.Text;
            etu.Postnom = txtpostnom.Text;
            etu.Prenom = txtprenom.Text;
            etu.Genre = Convert.ToString(cmbgenre.SelectedItem);
            etu.Etat_civil = Convert.ToString(cmbetat.SelectedItem);
            etu.Lieu_naissance = txtlieu.Text;
            etu.Date_naissance = datenais.Text;
            etu.Adresse = txtadresse.Text;
            etu.Numero = txtnumero.Text;
            etu.Mail = txtmail.Text;
        }

        private void loardlist()
        {
            dgetudiant.DataSource = etu.getetudiant();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bidingclass();
            int value = etu.Ajouteretudiant(etu);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "inscription", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loardlist();
                refresh();
            }
        }

        private void userEtudiant_Load(object sender, EventArgs e)
        {
            loardlist();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bidingclass();
            int value = etu.Modifieretudiant(etu);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loardlist();
                refresh();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            bidingclass();
            int value = etu.supprimeretudiant(etu);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loardlist();
                refresh();
            }
        }

        private void dgetudiant_DoubleClick(object sender, EventArgs e)
        {
            if (dgetudiant.RowCount > 0)
            {
                txtcode.Text = dgetudiant["dgcode", dgetudiant.CurrentRow.Index].Value.ToString();
                txtnom.Text= dgetudiant["dgnom", dgetudiant.CurrentRow.Index].Value.ToString();
                txtpostnom.Text= dgetudiant["dgpostnom", dgetudiant.CurrentRow.Index].Value.ToString();
                txtprenom.Text= dgetudiant["dgprenom", dgetudiant.CurrentRow.Index].Value.ToString();
                cmbgenre.Text= dgetudiant["dggenre", dgetudiant.CurrentRow.Index].Value.ToString();
                cmbetat.Text= dgetudiant["dgetat", dgetudiant.CurrentRow.Index].Value.ToString();
                txtlieu.Text= dgetudiant["dglieunais", dgetudiant.CurrentRow.Index].Value.ToString();
                datenais.Text= dgetudiant["dgdatenais", dgetudiant.CurrentRow.Index].Value.ToString();
                txtadresse.Text= dgetudiant["dgadresse", dgetudiant.CurrentRow.Index].Value.ToString();
                txtnumero.Text= dgetudiant["dgnumero", dgetudiant.CurrentRow.Index].Value.ToString();
                txtmail.Text= dgetudiant["dgmail", dgetudiant.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            reports.ex rpt = new reports.ex();
            rpt.DataSource = M.get_Report_Z2();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}

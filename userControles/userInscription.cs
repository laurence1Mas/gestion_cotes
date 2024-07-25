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
    public partial class userInscription : UserControl
    {
        classes.Clsinscription clsinsc = new classes.Clsinscription();
        classes.clsetudiants clsetu = new classes.clsetudiants();
        classes.clspromotions clspro = new classes.clspromotions();
        classes.Clsannee clsa = new classes.Clsannee();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userInscription()
        {
            InitializeComponent();
            loadlist();
        }

        public void refresh()
        {
            txtcode.Text = "";
            cmbetudiant.Text = "";
            cmbpromotion.Text = "";
            cmbannee.Text = "";
            dateinscription.Text = "";
        }
        private void bindingclass()
        {
            clsinsc.Codeinscription = txtcode.Text;
            clsinsc.Refetudiant = Convert.ToString(cmbetudiant.SelectedValue);
            clsinsc.Refpromotion = Convert.ToString(cmbpromotion.SelectedValue);
            clsinsc.Refannee = Convert.ToString(cmbannee.SelectedValue);
            clsinsc.Date_inscription = Convert.ToDateTime(dateinscription.Text);
        }
        private void loadlist()
        {
            dginscription.DataSource = clsinsc.getInscription();
            cmbetudiant.DataSource = clsetu.getlistetudiant();
            cmbetudiant.ValueMember = "codeetudiant";
            cmbetudiant.DisplayMember = "noms";
            cmbpromotion.DataSource = clspro.getPromotion();
            cmbpromotion.ValueMember = "codepromotion";
            cmbpromotion.DisplayMember = "promotion";
            cmbannee.DataSource = clsa.getannee();
            cmbannee.ValueMember = "codeannee";
            cmbannee.DisplayMember = "designation";
        }
        private void userInscription_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsinsc.Ajouterinscription(clsinsc);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show(" erreur dans l'Operation ", "inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsinsc.Modifierinscription(clsinsc);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();

            }
            else
            {
                MessageBox.Show(" erreur dans l'Operation ", "inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsinsc.supprimerInscription(clsinsc);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show(" erreur dans l'Operation ", "inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void dginscription_DoubleClick(object sender, EventArgs e)
        {
            if(dginscription.RowCount > 0)
            {
                txtcode.Text = dginscription["dgcode", dginscription.CurrentRow.Index].Value.ToString();
                cmbetudiant.Text = dginscription["dgrefetudiant", dginscription.CurrentRow.Index].Value.ToString();
                cmbpromotion.Text = dginscription["dgpromotion", dginscription.CurrentRow.Index].Value.ToString();
                cmbannee.Text = dginscription["dgannee", dginscription.CurrentRow.Index].Value.ToString();
                dateinscription.Text = dginscription["dgdateinscription", dginscription.CurrentRow.Index].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reports.carteEtu rpt = new reports.carteEtu();
            rpt.DataSource = M.get_Report_carte("Vinscription", "codeinscription",txtcode.Text);
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}

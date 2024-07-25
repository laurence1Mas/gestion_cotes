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
    public partial class userCours : UserControl
    {
        classes.ClsCours clsc = new classes.ClsCours();
        classes.Clsenseignant clsenseis = new classes.Clsenseignant();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userCours()
        {
            InitializeComponent();
            loadlist();
        }
        public void refresh()
        {
            txtcode.Text = "";
            txtcategorie.Text = "";
            txtcodecours.Text="";
            txtdesignation.Text = "";
            txtue.Text = "";
            txtcm.Text = "";
            txttp.Text = "";
            txttd.Text = "";
            txtmax.Text = "";
            cmbenseignant.Text = "";
            cmbsemestre.Text = "";
        }
        private void bindingclass()
        {
            clsc.Codecours = txtcode.Text;
            clsc.Categorie = Convert.ToChar( txtcategorie.Text);
            clsc.Code = txtcodecours.Text;
            clsc.Designation = txtdesignation.Text;
            clsc.Ue = txtue.Text;
            clsc.Cm = Convert.ToInt32(txtcm.Text);
            clsc.Tp = Convert.ToInt32(txttp.Text);
            clsc.Td = Convert.ToInt32(txttd.Text);
            clsc.Maximum = Convert.ToInt32(txtmax.Text);
            clsc.Refenseignant = Convert.ToString(cmbenseignant.SelectedValue);
            clsc.Semestre = Convert.ToString(cmbsemestre.SelectedItem);
        }
        private void loadlist()
        {
            dgcours.DataSource = clsc.getcours();
            cmbenseignant.DataSource = clsenseis.getenseignant();
            cmbenseignant.ValueMember = "codeenseignant";
            cmbenseignant.DisplayMember = "noms";
        }
        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsc.Ajoutecours(clsc);
            if (value>=1)
            {
                MessageBox.Show("Operation effectuée avec succès", "cours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "cours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void userCours_Load(object sender, EventArgs e)
        {
            dgcours.DataSource = clsc.getcours();
            loadlist();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsc.Modifiercours(clsc);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "cours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "cours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
        }

        private void dgcours_DoubleClick(object sender, EventArgs e)
        {
            if(dgcours.RowCount > 0)
            {
                txtcode.Text = dgcours["dgcode", dgcours.CurrentRow.Index].Value.ToString();
                txtcategorie.Text = dgcours["dgcategorie", dgcours.CurrentRow.Index].Value.ToString();
                txtcodecours.Text = dgcours["dgcodecours", dgcours.CurrentRow.Index].Value.ToString();
                txtdesignation.Text = dgcours["dgdesignation", dgcours.CurrentRow.Index].Value.ToString();
                txtue.Text = dgcours["dgue", dgcours.CurrentRow.Index].Value.ToString();
                txtcm.Text = dgcours["dgcm", dgcours.CurrentRow.Index].Value.ToString();
                txttp.Text = dgcours["dgtp", dgcours.CurrentRow.Index].Value.ToString();
                txttd.Text = dgcours["dgtd", dgcours.CurrentRow.Index].Value.ToString();
                cmbenseignant.Text = dgcours["dgenseignant", dgcours.CurrentRow.Index].Value.ToString();
                cmbsemestre.Text = dgcours["dgsemestre", dgcours.CurrentRow.Index].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reports.coursliste rpt = new reports.coursliste();
            rpt.DataSource = M.get_Report_Z();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}

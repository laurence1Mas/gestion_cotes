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
    public partial class userCotation : UserControl
    {
        classes.clsCotation clsco = new classes.clsCotation();
        classes.Clsinscription clsci = new classes.Clsinscription();
        classes.ClsCours clsc = new classes.ClsCours();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userCotation()
        {
            InitializeComponent();
            loadlist();
        }
        private void loadlist()
        {
            dgcotation.DataSource = clsco.getcotation();
            cmbinscription.DataSource = clsci.getInscription();
            cmbinscription.ValueMember = "codeinscription";
            cmbinscription.DisplayMember = "refetudiant";
            cmbcours.DataSource = clsc.getcours();
            cmbcours.ValueMember = "codeCours";
            cmbcours.DisplayMember = "UE";
        }
        public void refresh()
        {
            txtcode.Text = "";
            cmbinscription.Text = "";
            cmbcours.Text = "";
            txttp.Text = "";
            txttd.Text = "";
            txtmaxtp.Text = "";
            txtmaxtd.Text = "";
            txtexamen.Text = "";
            txtmaxexamen.Text = "";
        }
        private void bindingclass()
        {
            clsco.Codecotation =txtcode.Text;
            clsco.Refinscription = Convert.ToString(cmbinscription.SelectedValue);
            clsco.Refcours = Convert.ToString(cmbcours.SelectedValue);
            clsco.Tp = Convert.ToDecimal(txttp.Text);
            clsco.Td = Convert.ToDecimal(txttd.Text);
            clsco.Maxtp = Convert.ToInt32(txtmaxtp.Text);
            clsco.Maxtd = Convert.ToInt32(txtmaxtd.Text);
            clsco.Exam = Convert.ToDecimal(txtexamen.Text);
            clsco.Maxexam = Convert.ToInt32(txtmaxexamen.Text);
        }
        private void userCotation_Load(object sender, EventArgs e)
        {
            loadlist();
            dgcotation.DataSource = clsco.getcotation();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsco.Ajoutercotation(clsco);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "cotation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "cotation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsco.Modifiercotation(clsco);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "cotation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "cotation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void dgcotation_DoubleClick(object sender, EventArgs e)
        {
            if (dgcotation.RowCount >0)
            {
                txtcode.Text = dgcotation["dgcode", dgcotation.CurrentRow.Index].Value.ToString();
                cmbinscription.Text = dgcotation["dgrefinscription", dgcotation.CurrentRow.Index].Value.ToString();
                cmbcours.Text= dgcotation["dgrefcours", dgcotation.CurrentRow.Index].Value.ToString();
                txttp.Text= dgcotation["dgtp", dgcotation.CurrentRow.Index].Value.ToString();
                txttd.Text = dgcotation["dgtd", dgcotation.CurrentRow.Index].Value.ToString();
                txtmaxtp.Text = dgcotation["dgmaxtp", dgcotation.CurrentRow.Index].Value.ToString();
                txtmaxtd.Text = dgcotation["dgmaxtd", dgcotation.CurrentRow.Index].Value.ToString();
                txtexamen.Text = dgcotation["dgexamen", dgcotation.CurrentRow.Index].Value.ToString();
                txtmaxexamen.Text = dgcotation["dgmaxexamen", dgcotation.CurrentRow.Index].Value.ToString();
            }
        }

        private void dgtypecote_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reports.releveCote rpt = new reports.releveCote();
            rpt.DataSource = M.get_Report_relever("relevercote", "etudiant", cmbinscription.Text);
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}

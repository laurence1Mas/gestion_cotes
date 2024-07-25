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
    public partial class userAutres : UserControl
    {
        classes.Clsannee clsa = new classes.Clsannee();
        classes.Clsoptions clsop = new classes.Clsoptions();
        classes.Clspromotion clsprom = new classes.Clspromotion();
        public userAutres()
        {
            InitializeComponent();
            loadlistAnnee();
            loadlistOption();
            loadlistpromotion();
        }

        private void bindigclassAnnee()
        {
            clsa.Codeannee = txtcodeAn.Text;
            clsa.Designation = txtdesignationAn.Text;
        }
        //=====================================
        private void bindigclassOption()
        {
            clsop.Codeoption = txtcodeOp.Text;
            clsop.Designation = txtdesignationOp.Text;
        }
        //========================================
        private void bindigclassPromotion()
        {
            clsprom.Codepromotion = txtpro.Text;
            clsprom.Designation = txtdesignationProm.Text;
            clsprom.Refoption = Convert.ToString(cmboption.SelectedValue);
        }
        //========================================
        private void loadlistOption()
        {
            dgoption.DataSource = clsop.getoption();
        }
        //========================================
        private void loadlistAnnee()
        {
            dgannee.DataSource = clsa.getannee();
        }
        //========================================
        private void loadlistpromotion()
        {
            dgpromotion.DataSource = clsprom.getPromotion();
            cmboption.DataSource = clsop.getoption();
            cmboption.ValueMember = "codeoption";
            cmboption.DisplayMember = "designation";
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
    
        }

        private void userAutres_Load(object sender, EventArgs e)
        {
            loadlistAnnee();
            loadlistOption();
            loadlistpromotion();
        }

        private void btnajouterOp_Click(object sender, EventArgs e)
        {
            bindigclassOption();
            int value = clsop.Ajouteroption(clsop);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "option", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistOption();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "option", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistOption();
            }
        }

        private void btnajouterAn_Click(object sender, EventArgs e)
        {
            bindigclassAnnee();
            int value = clsa.Ajouterannee(clsa);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "annee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistAnnee();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "annee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistAnnee();
            }
        }

        private void btnajouterProm_Click(object sender, EventArgs e)
        {
            bindigclassPromotion();
            int value = clsprom.Ajouterpromotion(clsprom);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistpromotion();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistpromotion();
            }
        }

        private void btnmodifierOp_Click(object sender, EventArgs e)
        {
            bindigclassOption();
            int value = clsop.Modifieroption(clsop);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "option", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistOption();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "option", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistOption();
            }
        }

        private void btnsupprimerOp_Click(object sender, EventArgs e)
        {
            bindigclassOption();
            int value = clsop.supprimeroption(clsop);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "option", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistOption();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "option", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistOption();
            }
        }

        private void btnmodifierAn_Click(object sender, EventArgs e)
        {
            bindigclassAnnee();
            int value = clsa.Modifierannee(clsa);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "annee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistAnnee();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "annee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistAnnee();
            }
        }

        private void btnsupprimerAn_Click(object sender, EventArgs e)
        {
            bindigclassAnnee();
            int value = clsa.supprimerannee(clsa);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "annee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistAnnee();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "annee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistAnnee();
            }
        }

        private void btnmodifierProm_Click(object sender, EventArgs e)
        {
            bindigclassPromotion();
            int value = clsprom.Modifierpromotion(clsprom);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistpromotion();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistpromotion();
            }
        }

        private void btnsupprimerProm_Click(object sender, EventArgs e)
        {
            bindigclassPromotion();
            int value = clsprom.supprimerpromotion(clsprom);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistpromotion();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistpromotion();
            }
        }

        private void dgoption_DoubleClick(object sender, EventArgs e)
        {
            if(dgoption.RowCount > 0)
            {
                txtcodeOp.Text = dgoption["dgcodeoption", dgoption.CurrentRow.Index].Value.ToString();
                txtdesignationOp.Text = dgoption["dgdesignationOption", dgoption.CurrentRow.Index].Value.ToString();
            }
        }

        private void dgannee_DoubleClick(object sender, EventArgs e)
        {
            if(dgannee.RowCount > 0)
            {
                txtcodeAn.Text = dgannee["dgcodeannee", dgannee.CurrentRow.Index].Value.ToString();
                txtdesignationAn.Text = dgannee["dgdesignationannee", dgannee.CurrentRow.Index].Value.ToString();
            }
        }

        private void dgpromotion_DoubleClick(object sender, EventArgs e)
        {
            if(dgpromotion.RowCount > 0)
            {
                txtpro.Text = dgpromotion["dgcodepromotion", dgpromotion.CurrentRow.Index].Value.ToString();
                txtdesignationProm.Text = dgpromotion["dgdesignationpromotion", dgpromotion.CurrentRow.Index].Value.ToString();
                cmboption.Text = dgpromotion["dgrefoption", dgpromotion.CurrentRow.Index].Value.ToString();
            }
        }
    }
}

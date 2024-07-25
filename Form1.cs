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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel.Height = btnetudiant.Height;
            panel.Top = btnetudiant.Top;

        }

        private void containerpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnetudiant_Click(object sender, EventArgs e)
        {
            panel.Height = btnetudiant.Height;
            panel.Top = btnetudiant.Top;
            containerpan.Controls.Clear();
            containerpan.Controls.Add(new userControles.userEtudiant());
        }

        private void btnenseignant_Click(object sender, EventArgs e)
        {
            panel.Height = btnenseignant.Height;
            panel.Top = btnenseignant.Top;
            containerpan.Controls.Clear();
            containerpan.Controls.Add(new userControles.userEnseignant());
        }

        private void btncours_Click(object sender, EventArgs e)
        {
            panel.Height = btncours.Height;
            panel.Top = btncours.Top;
            containerpan.Controls.Clear();
            containerpan.Controls.Add(new userControles.userCours());
        }

        private void btninscription_Click(object sender, EventArgs e)
        {
            panel.Height = btninscription.Height;
            panel.Top = btninscription.Top;
            containerpan.Controls.Clear();
            containerpan.Controls.Add(new userControles.userInscription());
            
        }

        private void btnpayement_Click(object sender, EventArgs e)
        {
            panel.Height = btnpayement.Height;
            panel.Top = btnpayement.Top;
            containerpan.Controls.Clear();
            containerpan.Controls.Add(new userControles.userPayement());
        }

        private void btnautres_Click(object sender, EventArgs e)
        {
            panel.Height = btnautres.Height;
            panel.Top = btnautres.Top;
            containerpan.Controls.Clear();
            containerpan.Controls.Add(new userControles.userAutres());
        }

        private void btncotation_Click(object sender, EventArgs e)
        {
            panel.Height = btncotation.Height;
            panel.Top = btncotation.Top;
            containerpan.Controls.Clear();
            containerpan.Controls.Add(new userControles.userCotation());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.Height = btnsms.Height;
            panel.Top = btnsms.Top;
            containerpan.Controls.Clear();
            containerpan.Controls.Add(new userControles.userSms());
        }
    }
}

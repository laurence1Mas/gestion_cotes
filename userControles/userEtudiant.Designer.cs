namespace gestion_cotes.userControles
{
    partial class userEtudiant
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.datenais = new System.Windows.Forms.DateTimePicker();
            this.cmbetat = new System.Windows.Forms.ComboBox();
            this.cmbgenre = new System.Windows.Forms.ComboBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpostnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgetudiant = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpostnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgetat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dglieunais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdatenais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgetudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement etudiant";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsupprimer);
            this.groupBox3.Controls.Add(this.btnmodifier);
            this.groupBox3.Controls.Add(this.btnajouter);
            this.groupBox3.Location = new System.Drawing.Point(909, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ANCTIONS";
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.Red;
            this.btnsupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.Color.White;
            this.btnsupprimer.Location = new System.Drawing.Point(19, 160);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(121, 34);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "SUPPRIMER";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(19, 106);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(121, 34);
            this.btnmodifier.TabIndex = 1;
            this.btnmodifier.Text = "MODIFIER";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.Location = new System.Drawing.Point(19, 61);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(121, 34);
            this.btnajouter.TabIndex = 0;
            this.btnajouter.Text = "AJOUTER";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcode);
            this.groupBox2.Controls.Add(this.datenais);
            this.groupBox2.Controls.Add(this.cmbetat);
            this.groupBox2.Controls.Add(this.cmbgenre);
            this.groupBox2.Controls.Add(this.txtmail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtnumero);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtadresse);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtlieu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtprenom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtpostnom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtnom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(29, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Identites";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(771, 20);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(85, 34);
            this.txtcode.TabIndex = 23;
            this.txtcode.Visible = false;
            // 
            // datenais
            // 
            this.datenais.Location = new System.Drawing.Point(469, 61);
            this.datenais.Name = "datenais";
            this.datenais.Size = new System.Drawing.Size(195, 27);
            this.datenais.TabIndex = 22;
            // 
            // cmbetat
            // 
            this.cmbetat.FormattingEnabled = true;
            this.cmbetat.Items.AddRange(new object[] {
            "celibataire",
            "marie",
            "divorce"});
            this.cmbetat.Location = new System.Drawing.Point(247, 128);
            this.cmbetat.Name = "cmbetat";
            this.cmbetat.Size = new System.Drawing.Size(195, 29);
            this.cmbetat.TabIndex = 21;
            // 
            // cmbgenre
            // 
            this.cmbgenre.FormattingEnabled = true;
            this.cmbgenre.Items.AddRange(new object[] {
            "masculin",
            "feminin"});
            this.cmbgenre.Location = new System.Drawing.Point(247, 61);
            this.cmbgenre.Name = "cmbgenre";
            this.cmbgenre.Size = new System.Drawing.Size(195, 29);
            this.cmbgenre.TabIndex = 20;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(675, 60);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(195, 34);
            this.txtmail.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(671, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "mail";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(469, 184);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(195, 34);
            this.txtnumero.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "numero";
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(469, 119);
            this.txtadresse.Multiline = true;
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(195, 34);
            this.txtadresse.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "adresse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(465, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "date de naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "lieu de naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "etat-civil";
            // 
            // txtlieu
            // 
            this.txtlieu.Location = new System.Drawing.Point(247, 184);
            this.txtlieu.Multiline = true;
            this.txtlieu.Name = "txtlieu";
            this.txtlieu.Size = new System.Drawing.Size(195, 34);
            this.txtlieu.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "genre";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(27, 184);
            this.txtprenom.Multiline = true;
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(195, 34);
            this.txtprenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "prenom";
            // 
            // txtpostnom
            // 
            this.txtpostnom.Location = new System.Drawing.Point(27, 123);
            this.txtpostnom.Multiline = true;
            this.txtpostnom.Name = "txtpostnom";
            this.txtpostnom.Size = new System.Drawing.Size(195, 34);
            this.txtpostnom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "postnom";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(27, 58);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(195, 34);
            this.txtnom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgetudiant
            // 
            this.dgetudiant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgetudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgetudiant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgnom,
            this.dgpostnom,
            this.dgprenom,
            this.dggenre,
            this.dgetat,
            this.dglieunais,
            this.dgdatenais,
            this.dgadresse,
            this.dgnumero,
            this.dgmail});
            this.dgetudiant.Location = new System.Drawing.Point(24, 330);
            this.dgetudiant.Name = "dgetudiant";
            this.dgetudiant.Size = new System.Drawing.Size(1061, 182);
            this.dgetudiant.TabIndex = 1;
            this.dgetudiant.DoubleClick += new System.EventHandler(this.dgetudiant_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "codeetudiant";
            this.dgcode.HeaderText = "code";
            this.dgcode.Name = "dgcode";
            // 
            // dgnom
            // 
            this.dgnom.DataPropertyName = "nom";
            this.dgnom.HeaderText = "nom";
            this.dgnom.Name = "dgnom";
            // 
            // dgpostnom
            // 
            this.dgpostnom.DataPropertyName = "postnom";
            this.dgpostnom.HeaderText = "postnom";
            this.dgpostnom.Name = "dgpostnom";
            // 
            // dgprenom
            // 
            this.dgprenom.DataPropertyName = "prenom";
            this.dgprenom.HeaderText = "prenom";
            this.dgprenom.Name = "dgprenom";
            // 
            // dggenre
            // 
            this.dggenre.DataPropertyName = "genre";
            this.dggenre.HeaderText = "genre";
            this.dggenre.Name = "dggenre";
            // 
            // dgetat
            // 
            this.dgetat.DataPropertyName = "etat_civil";
            this.dgetat.HeaderText = "etat-civil";
            this.dgetat.Name = "dgetat";
            // 
            // dglieunais
            // 
            this.dglieunais.DataPropertyName = "lieu_naissance";
            this.dglieunais.HeaderText = "lieu-naissance";
            this.dglieunais.Name = "dglieunais";
            // 
            // dgdatenais
            // 
            this.dgdatenais.DataPropertyName = "date_naissance";
            this.dgdatenais.HeaderText = "date-naissance";
            this.dgdatenais.Name = "dgdatenais";
            // 
            // dgadresse
            // 
            this.dgadresse.DataPropertyName = "adresse";
            this.dgadresse.HeaderText = "adresse";
            this.dgadresse.Name = "dgadresse";
            // 
            // dgnumero
            // 
            this.dgnumero.DataPropertyName = "numero";
            this.dgnumero.HeaderText = "numero";
            this.dgnumero.Name = "dgnumero";
            // 
            // dgmail
            // 
            this.dgmail.DataPropertyName = "mail";
            this.dgmail.HeaderText = "mail";
            this.dgmail.Name = "dgmail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(654, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "recherche";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(750, 293);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(215, 34);
            this.txtsearch.TabIndex = 23;
            // 
            // btnimprimer
            // 
            this.btnimprimer.Location = new System.Drawing.Point(984, 293);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(101, 34);
            this.btnimprimer.TabIndex = 24;
            this.btnimprimer.Text = "IMPRIMER";
            this.btnimprimer.UseVisualStyleBackColor = true;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
            // 
            // userEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgetudiant);
            this.Controls.Add(this.groupBox1);
            this.Name = "userEtudiant";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1108, 515);
            this.Load += new System.EventHandler(this.userEtudiant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgetudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgetudiant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpostnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.ComboBox cmbgenre;
        private System.Windows.Forms.ComboBox cmbetat;
        private System.Windows.Forms.DateTimePicker datenais;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpostnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgetat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dglieunais;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdatenais;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmail;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button btnimprimer;
    }
}

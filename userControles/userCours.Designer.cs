namespace gestion_cotes.userControles
{
    partial class userCours
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
            this.dgcours = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcodecours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgponderation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgenseignant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsemestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcodecours = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbsemestre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcategorie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbenseignant = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgcours)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgcours
            // 
            this.dgcours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgcours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgcategorie,
            this.dgcodecours,
            this.dgdesignation,
            this.dgue,
            this.dgcm,
            this.dgtp,
            this.dgtd,
            this.dgponderation,
            this.dgcredit,
            this.dgenseignant,
            this.dgsemestre});
            this.dgcours.Location = new System.Drawing.Point(26, 322);
            this.dgcours.Name = "dgcours";
            this.dgcours.Size = new System.Drawing.Size(1061, 150);
            this.dgcours.TabIndex = 2;
            this.dgcours.DoubleClick += new System.EventHandler(this.dgcours_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "codeCours";
            this.dgcode.FillWeight = 30.39185F;
            this.dgcode.HeaderText = "n°";
            this.dgcode.Name = "dgcode";
            // 
            // dgcategorie
            // 
            this.dgcategorie.DataPropertyName = "categorie";
            this.dgcategorie.FillWeight = 72.57845F;
            this.dgcategorie.HeaderText = "categorie";
            this.dgcategorie.Name = "dgcategorie";
            // 
            // dgcodecours
            // 
            this.dgcodecours.DataPropertyName = "code";
            this.dgcodecours.HeaderText = "code";
            this.dgcodecours.Name = "dgcodecours";
            // 
            // dgdesignation
            // 
            this.dgdesignation.DataPropertyName = "designation";
            this.dgdesignation.FillWeight = 229.6575F;
            this.dgdesignation.HeaderText = "designation";
            this.dgdesignation.Name = "dgdesignation";
            // 
            // dgue
            // 
            this.dgue.DataPropertyName = "ue";
            this.dgue.FillWeight = 234.6146F;
            this.dgue.HeaderText = "UE";
            this.dgue.Name = "dgue";
            // 
            // dgcm
            // 
            this.dgcm.DataPropertyName = "cm";
            this.dgcm.FillWeight = 48.06054F;
            this.dgcm.HeaderText = "CM";
            this.dgcm.Name = "dgcm";
            // 
            // dgtp
            // 
            this.dgtp.DataPropertyName = "tp";
            this.dgtp.FillWeight = 49.201F;
            this.dgtp.HeaderText = "TP";
            this.dgtp.Name = "dgtp";
            // 
            // dgtd
            // 
            this.dgtd.DataPropertyName = "td";
            this.dgtd.FillWeight = 50.34202F;
            this.dgtd.HeaderText = "TD";
            this.dgtd.Name = "dgtd";
            // 
            // dgponderation
            // 
            this.dgponderation.DataPropertyName = "maximum";
            this.dgponderation.FillWeight = 51.48104F;
            this.dgponderation.HeaderText = "max";
            this.dgponderation.Name = "dgponderation";
            // 
            // dgcredit
            // 
            this.dgcredit.DataPropertyName = "credit";
            this.dgcredit.HeaderText = "credit";
            this.dgcredit.Name = "dgcredit";
            // 
            // dgenseignant
            // 
            this.dgenseignant.DataPropertyName = "refenseignant";
            this.dgenseignant.FillWeight = 152.2843F;
            this.dgenseignant.HeaderText = "enseignant";
            this.dgenseignant.Name = "dgenseignant";
            // 
            // dgsemestre
            // 
            this.dgsemestre.DataPropertyName = "semestre";
            this.dgsemestre.FillWeight = 81.38888F;
            this.dgsemestre.HeaderText = "semestre";
            this.dgsemestre.Name = "dgsemestre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 247);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Cours";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsupprimer);
            this.groupBox3.Controls.Add(this.btnmodifier);
            this.groupBox3.Controls.Add(this.btnajouter);
            this.groupBox3.Location = new System.Drawing.Point(909, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 169);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ANCTIONS";
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.Red;
            this.btnsupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.Color.White;
            this.btnsupprimer.Location = new System.Drawing.Point(19, 125);
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
            this.btnmodifier.Location = new System.Drawing.Point(19, 71);
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
            this.btnajouter.Location = new System.Drawing.Point(19, 26);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(121, 34);
            this.btnajouter.TabIndex = 0;
            this.btnajouter.Text = "AJOUTER";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcodecours);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtmax);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbsemestre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txttd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txttp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtcm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtcategorie);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbenseignant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcode);
            this.groupBox2.Controls.Add(this.txtue);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtdesignation);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(29, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Identites";
            // 
            // txtcodecours
            // 
            this.txtcodecours.Location = new System.Drawing.Point(285, 55);
            this.txtcodecours.Multiline = true;
            this.txtcodecours.Name = "txtcodecours";
            this.txtcodecours.Size = new System.Drawing.Size(126, 34);
            this.txtcodecours.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "code";
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(567, 135);
            this.txtmax.Multiline = true;
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(69, 34);
            this.txtmax.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(563, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "MAX";
            // 
            // cmbsemestre
            // 
            this.cmbsemestre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbsemestre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbsemestre.FormattingEnabled = true;
            this.cmbsemestre.Items.AddRange(new object[] {
            "PREMIERE",
            "DEUXIEME"});
            this.cmbsemestre.Location = new System.Drawing.Point(659, 135);
            this.cmbsemestre.Name = "cmbsemestre";
            this.cmbsemestre.Size = new System.Drawing.Size(195, 29);
            this.cmbsemestre.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(655, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "semestre";
            // 
            // txttd
            // 
            this.txttd.Location = new System.Drawing.Point(485, 135);
            this.txttd.Multiline = true;
            this.txttd.Name = "txttd";
            this.txttd.Size = new System.Drawing.Size(69, 34);
            this.txttd.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "TD";
            // 
            // txttp
            // 
            this.txttp.Location = new System.Drawing.Point(388, 135);
            this.txttp.Multiline = true;
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(69, 34);
            this.txttp.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "TP";
            // 
            // txtcm
            // 
            this.txtcm.Location = new System.Drawing.Point(289, 135);
            this.txtcm.Multiline = true;
            this.txtcm.Name = "txtcm";
            this.txtcm.Size = new System.Drawing.Size(69, 34);
            this.txtcm.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "CM";
            // 
            // txtcategorie
            // 
            this.txtcategorie.Location = new System.Drawing.Point(72, 55);
            this.txtcategorie.Multiline = true;
            this.txtcategorie.Name = "txtcategorie";
            this.txtcategorie.Size = new System.Drawing.Size(195, 34);
            this.txtcategorie.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "categorie";
            // 
            // cmbenseignant
            // 
            this.cmbenseignant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbenseignant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbenseignant.FormattingEnabled = true;
            this.cmbenseignant.Location = new System.Drawing.Point(659, 60);
            this.cmbenseignant.Name = "cmbenseignant";
            this.cmbenseignant.Size = new System.Drawing.Size(195, 29);
            this.cmbenseignant.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(655, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "enseignant";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(783, 18);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(85, 34);
            this.txtcode.TabIndex = 23;
            this.txtcode.Visible = false;
            // 
            // txtue
            // 
            this.txtue.Location = new System.Drawing.Point(441, 55);
            this.txtue.Multiline = true;
            this.txtue.Name = "txtue";
            this.txtue.Size = new System.Drawing.Size(195, 34);
            this.txtue.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(437, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "UE";
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(72, 135);
            this.txtdesignation.Multiline = true;
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(195, 34);
            this.txtdesignation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "designation";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(714, 282);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(215, 34);
            this.txtsearch.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(618, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "recherche";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(935, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 32;
            this.button1.Text = "IMPRIMER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgcours);
            this.Name = "userCours";
            this.Size = new System.Drawing.Size(1108, 515);
            this.Load += new System.EventHandler(this.userCours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcours)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgcours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbenseignant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbsemestre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcodecours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcodecours;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgponderation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgenseignant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsemestre;
    }
}

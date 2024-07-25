namespace gestion_cotes.userControles
{
    partial class userInscription
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateinscription = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbannee = new System.Windows.Forms.ComboBox();
            this.cmbpromotion = new System.Windows.Forms.ComboBox();
            this.cmbetudiant = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dginscription = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrefetudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpromotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgannee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdateinscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginscription)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(712, 293);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(215, 34);
            this.txtsearch.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(616, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "recherche";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 247);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Inscription";
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
            this.groupBox2.Controls.Add(this.dateinscription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbannee);
            this.groupBox2.Controls.Add(this.cmbpromotion);
            this.groupBox2.Controls.Add(this.cmbetudiant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcode);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(29, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "description";
            // 
            // dateinscription
            // 
            this.dateinscription.Location = new System.Drawing.Point(480, 128);
            this.dateinscription.Name = "dateinscription";
            this.dateinscription.Size = new System.Drawing.Size(200, 27);
            this.dateinscription.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "date-inscription";
            // 
            // cmbannee
            // 
            this.cmbannee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbannee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbannee.FormattingEnabled = true;
            this.cmbannee.Location = new System.Drawing.Point(480, 68);
            this.cmbannee.Name = "cmbannee";
            this.cmbannee.Size = new System.Drawing.Size(195, 29);
            this.cmbannee.TabIndex = 31;
            // 
            // cmbpromotion
            // 
            this.cmbpromotion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbpromotion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpromotion.FormattingEnabled = true;
            this.cmbpromotion.Location = new System.Drawing.Point(117, 126);
            this.cmbpromotion.Name = "cmbpromotion";
            this.cmbpromotion.Size = new System.Drawing.Size(263, 29);
            this.cmbpromotion.TabIndex = 30;
            // 
            // cmbetudiant
            // 
            this.cmbetudiant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbetudiant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbetudiant.FormattingEnabled = true;
            this.cmbetudiant.Location = new System.Drawing.Point(117, 68);
            this.cmbetudiant.Name = "cmbetudiant";
            this.cmbetudiant.Size = new System.Drawing.Size(263, 29);
            this.cmbetudiant.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "annee";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(727, 26);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(85, 34);
            this.txtcode.TabIndex = 23;
            this.txtcode.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(113, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "promotion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "etudiant";
            // 
            // dginscription
            // 
            this.dginscription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dginscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginscription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgrefetudiant,
            this.dgpromotion,
            this.dgannee,
            this.dgdateinscription});
            this.dginscription.Location = new System.Drawing.Point(24, 333);
            this.dginscription.Name = "dginscription";
            this.dginscription.Size = new System.Drawing.Size(1055, 150);
            this.dginscription.TabIndex = 32;
            this.dginscription.DoubleClick += new System.EventHandler(this.dginscription_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "codeinscription";
            this.dgcode.HeaderText = "code";
            this.dgcode.Name = "dgcode";
            // 
            // dgrefetudiant
            // 
            this.dgrefetudiant.DataPropertyName = "refetudiant";
            this.dgrefetudiant.HeaderText = "etudiant";
            this.dgrefetudiant.Name = "dgrefetudiant";
            // 
            // dgpromotion
            // 
            this.dgpromotion.DataPropertyName = "refpromotion";
            this.dgpromotion.HeaderText = "promotion";
            this.dgpromotion.Name = "dgpromotion";
            // 
            // dgannee
            // 
            this.dgannee.DataPropertyName = "refannee";
            this.dgannee.HeaderText = "annee-AC";
            this.dgannee.Name = "dgannee";
            // 
            // dgdateinscription
            // 
            this.dgdateinscription.DataPropertyName = "Date_inscription";
            this.dgdateinscription.HeaderText = "date-indcription";
            this.dgdateinscription.Name = "dgdateinscription";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(933, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "IMPRIMER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dginscription);
            this.Name = "userInscription";
            this.Size = new System.Drawing.Size(1108, 515);
            this.Load += new System.EventHandler(this.userInscription_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dginscription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbetudiant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dginscription;
        private System.Windows.Forms.ComboBox cmbannee;
        private System.Windows.Forms.ComboBox cmbpromotion;
        private System.Windows.Forms.DateTimePicker dateinscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrefetudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpromotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgannee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdateinscription;
        private System.Windows.Forms.Button button1;
    }
}

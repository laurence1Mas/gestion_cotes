namespace gestion_cotes.userControles
{
    partial class userSms
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
            this.dgsms = new System.Windows.Forms.DataGridView();
            this.txtetudiant = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmoyenne = new System.Windows.Forms.TextBox();
            this.txtmension = new System.Windows.Forms.TextBox();
            this.txtannee = new System.Windows.Forms.TextBox();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgcodeetudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgetudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmoyennee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgannee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgsms)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgsms
            // 
            this.dgsms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgsms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcodeetudiant,
            this.dgtelephone,
            this.dgetudiant,
            this.dgmoyennee,
            this.dgannee,
            this.dgmension});
            this.dgsms.Location = new System.Drawing.Point(28, 240);
            this.dgsms.Name = "dgsms";
            this.dgsms.Size = new System.Drawing.Size(1043, 241);
            this.dgsms.TabIndex = 0;
            this.dgsms.DoubleClick += new System.EventHandler(this.dgsms_DoubleClick);
            // 
            // txtetudiant
            // 
            this.txtetudiant.Location = new System.Drawing.Point(46, 40);
            this.txtetudiant.Multiline = true;
            this.txtetudiant.Name = "txtetudiant";
            this.txtetudiant.Size = new System.Drawing.Size(259, 40);
            this.txtetudiant.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.txttelephone);
            this.groupBox1.Controls.Add(this.txtannee);
            this.groupBox1.Controls.Add(this.txtmension);
            this.groupBox1.Controls.Add(this.txtmoyenne);
            this.groupBox1.Controls.Add(this.txtetudiant);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "envoyer sms";
            // 
            // txtmoyenne
            // 
            this.txtmoyenne.Location = new System.Drawing.Point(46, 123);
            this.txtmoyenne.Multiline = true;
            this.txtmoyenne.Name = "txtmoyenne";
            this.txtmoyenne.Size = new System.Drawing.Size(259, 40);
            this.txtmoyenne.TabIndex = 2;
            // 
            // txtmension
            // 
            this.txtmension.Location = new System.Drawing.Point(345, 40);
            this.txtmension.Multiline = true;
            this.txtmension.Name = "txtmension";
            this.txtmension.Size = new System.Drawing.Size(259, 40);
            this.txtmension.TabIndex = 3;
            // 
            // txtannee
            // 
            this.txtannee.Location = new System.Drawing.Point(345, 123);
            this.txtannee.Multiline = true;
            this.txtannee.Name = "txtannee";
            this.txtannee.Size = new System.Drawing.Size(259, 40);
            this.txtannee.TabIndex = 4;
            // 
            // txttelephone
            // 
            this.txttelephone.Location = new System.Drawing.Point(630, 40);
            this.txttelephone.Multiline = true;
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(259, 40);
            this.txttelephone.TabIndex = 5;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(630, 123);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(259, 40);
            this.txtnumero.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(975, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "ENVOYER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgcodeetudiant
            // 
            this.dgcodeetudiant.DataPropertyName = "codeetudiant";
            this.dgcodeetudiant.HeaderText = "numero";
            this.dgcodeetudiant.Name = "dgcodeetudiant";
            // 
            // dgtelephone
            // 
            this.dgtelephone.DataPropertyName = "telephone";
            this.dgtelephone.HeaderText = "telephone";
            this.dgtelephone.Name = "dgtelephone";
            // 
            // dgetudiant
            // 
            this.dgetudiant.DataPropertyName = "etudiant";
            this.dgetudiant.HeaderText = "etudiant";
            this.dgetudiant.Name = "dgetudiant";
            // 
            // dgmoyennee
            // 
            this.dgmoyennee.DataPropertyName = "moyennee";
            this.dgmoyennee.HeaderText = "moyennee";
            this.dgmoyennee.Name = "dgmoyennee";
            // 
            // dgannee
            // 
            this.dgannee.DataPropertyName = "annee";
            this.dgannee.HeaderText = "anneeacademique";
            this.dgannee.Name = "dgannee";
            // 
            // dgmension
            // 
            this.dgmension.DataPropertyName = "mention";
            this.dgmension.HeaderText = "mension";
            this.dgmension.Name = "dgmension";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "moyenne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "etudiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "mension";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "annee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "numero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "id";
            // 
            // userSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgsms);
            this.Name = "userSms";
            this.Size = new System.Drawing.Size(1108, 515);
            this.Load += new System.EventHandler(this.userSms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgsms)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgsms;
        private System.Windows.Forms.TextBox txtetudiant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.TextBox txtannee;
        private System.Windows.Forms.TextBox txtmension;
        private System.Windows.Forms.TextBox txtmoyenne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcodeetudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgetudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmoyennee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgannee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmension;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

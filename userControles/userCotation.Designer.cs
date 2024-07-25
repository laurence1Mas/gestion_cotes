namespace gestion_cotes.userControles
{
    partial class userCotation
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
            this.txtmaxexamen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtexamen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmaxtp = new System.Windows.Forms.TextBox();
            this.txtmaxtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttp = new System.Windows.Forms.TextBox();
            this.txttd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcours = new System.Windows.Forms.ComboBox();
            this.cmbinscription = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgcotation = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrefinscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrefcours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmaxtp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmaxtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgexamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmaxexamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtotaux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcotation)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(712, 293);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(215, 34);
            this.txtsearch.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(616, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 39;
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
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Cotation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsupprimer);
            this.groupBox3.Controls.Add(this.btnmodifier);
            this.groupBox3.Controls.Add(this.btnajouter);
            this.groupBox3.Location = new System.Drawing.Point(885, 52);
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
            this.groupBox2.Controls.Add(this.txtmaxexamen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtexamen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtmaxtp);
            this.groupBox2.Controls.Add(this.txtmaxtd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txttp);
            this.groupBox2.Controls.Add(this.txttd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbcours);
            this.groupBox2.Controls.Add(this.cmbinscription);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcode);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(873, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "description";
            // 
            // txtmaxexamen
            // 
            this.txtmaxexamen.Location = new System.Drawing.Point(669, 141);
            this.txtmaxexamen.Multiline = true;
            this.txtmaxexamen.Name = "txtmaxexamen";
            this.txtmaxexamen.Size = new System.Drawing.Size(136, 34);
            this.txtmaxexamen.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(665, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "MAXEXAMEN";
            // 
            // txtexamen
            // 
            this.txtexamen.Location = new System.Drawing.Point(669, 70);
            this.txtexamen.Multiline = true;
            this.txtexamen.Name = "txtexamen";
            this.txtexamen.Size = new System.Drawing.Size(136, 34);
            this.txtexamen.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(665, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "EXAMEN";
            // 
            // txtmaxtp
            // 
            this.txtmaxtp.Location = new System.Drawing.Point(496, 71);
            this.txtmaxtp.Multiline = true;
            this.txtmaxtp.Name = "txtmaxtp";
            this.txtmaxtp.Size = new System.Drawing.Size(135, 34);
            this.txtmaxtp.TabIndex = 45;
            // 
            // txtmaxtd
            // 
            this.txtmaxtd.Location = new System.Drawing.Point(496, 141);
            this.txtmaxtd.Multiline = true;
            this.txtmaxtd.Name = "txtmaxtd";
            this.txtmaxtd.Size = new System.Drawing.Size(135, 34);
            this.txtmaxtd.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "MAXTD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "MAXTP";
            // 
            // txttp
            // 
            this.txttp.Location = new System.Drawing.Point(311, 66);
            this.txttp.Multiline = true;
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(141, 34);
            this.txttp.TabIndex = 41;
            // 
            // txttd
            // 
            this.txttd.Location = new System.Drawing.Point(311, 142);
            this.txttd.Multiline = true;
            this.txttd.Name = "txttd";
            this.txttd.Size = new System.Drawing.Size(141, 34);
            this.txttd.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "TD";
            // 
            // cmbcours
            // 
            this.cmbcours.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbcours.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcours.FormattingEnabled = true;
            this.cmbcours.Location = new System.Drawing.Point(33, 147);
            this.cmbcours.Name = "cmbcours";
            this.cmbcours.Size = new System.Drawing.Size(242, 29);
            this.cmbcours.TabIndex = 30;
            // 
            // cmbinscription
            // 
            this.cmbinscription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbinscription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbinscription.FormattingEnabled = true;
            this.cmbinscription.Location = new System.Drawing.Point(33, 71);
            this.cmbinscription.Name = "cmbinscription";
            this.cmbinscription.Size = new System.Drawing.Size(242, 29);
            this.cmbinscription.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "TP";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(748, 30);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(114, 34);
            this.txtcode.TabIndex = 23;
            this.txtcode.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "cours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "etudiant";
            // 
            // dgcotation
            // 
            this.dgcotation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgcotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcotation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgrefinscription,
            this.dgrefcours,
            this.dgtp,
            this.dgmaxtp,
            this.dgtd,
            this.dgmaxtd,
            this.dgexamen,
            this.dgmaxexamen,
            this.dgtotal,
            this.dgtotaux});
            this.dgcotation.Location = new System.Drawing.Point(24, 333);
            this.dgcotation.Name = "dgcotation";
            this.dgcotation.Size = new System.Drawing.Size(1055, 150);
            this.dgcotation.TabIndex = 36;
            this.dgcotation.DoubleClick += new System.EventHandler(this.dgcotation_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "codecotation";
            this.dgcode.HeaderText = "n°";
            this.dgcode.Name = "dgcode";
            // 
            // dgrefinscription
            // 
            this.dgrefinscription.DataPropertyName = "refinscription";
            this.dgrefinscription.HeaderText = "etudiant";
            this.dgrefinscription.Name = "dgrefinscription";
            // 
            // dgrefcours
            // 
            this.dgrefcours.DataPropertyName = "refcours";
            this.dgrefcours.HeaderText = "UE";
            this.dgrefcours.Name = "dgrefcours";
            // 
            // dgtp
            // 
            this.dgtp.DataPropertyName = "tp";
            this.dgtp.HeaderText = "TP";
            this.dgtp.Name = "dgtp";
            // 
            // dgmaxtp
            // 
            this.dgmaxtp.DataPropertyName = "maxtp";
            this.dgmaxtp.HeaderText = "MAXTP";
            this.dgmaxtp.Name = "dgmaxtp";
            // 
            // dgtd
            // 
            this.dgtd.DataPropertyName = "td";
            this.dgtd.HeaderText = "TD";
            this.dgtd.Name = "dgtd";
            // 
            // dgmaxtd
            // 
            this.dgmaxtd.DataPropertyName = "maxtd";
            this.dgmaxtd.HeaderText = "MAXTD";
            this.dgmaxtd.Name = "dgmaxtd";
            // 
            // dgexamen
            // 
            this.dgexamen.DataPropertyName = "exam";
            this.dgexamen.HeaderText = "EXAMEN";
            this.dgexamen.Name = "dgexamen";
            // 
            // dgmaxexamen
            // 
            this.dgmaxexamen.DataPropertyName = "maxexam";
            this.dgmaxexamen.HeaderText = "MAXEXAM";
            this.dgmaxexamen.Name = "dgmaxexamen";
            // 
            // dgtotal
            // 
            this.dgtotal.DataPropertyName = "total";
            this.dgtotal.HeaderText = "total";
            this.dgtotal.Name = "dgtotal";
            // 
            // dgtotaux
            // 
            this.dgtotaux.DataPropertyName = "totaux";
            this.dgtotaux.HeaderText = "totaux";
            this.dgtotaux.Name = "dgtotaux";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(934, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "RELEVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userCotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgcotation);
            this.Name = "userCotation";
            this.Size = new System.Drawing.Size(1108, 515);
            this.Load += new System.EventHandler(this.userCotation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcotation)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcours;
        private System.Windows.Forms.ComboBox cmbinscription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgcotation;
        private System.Windows.Forms.TextBox txttd;
        private System.Windows.Forms.TextBox txttp;
        private System.Windows.Forms.TextBox txtmaxexamen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtexamen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmaxtp;
        private System.Windows.Forms.TextBox txtmaxtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrefinscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrefcours;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmaxtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmaxtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgexamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmaxexamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtotaux;
        private System.Windows.Forms.Button button1;
    }
}

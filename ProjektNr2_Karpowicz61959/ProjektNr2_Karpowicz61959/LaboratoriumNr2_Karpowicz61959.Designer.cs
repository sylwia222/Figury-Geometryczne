namespace ProjektNr2_Karpowicz61959
{
    partial class LaboratoriumNr2_Karpowicz61959
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ckld_FiguryGeometryczne = new System.Windows.Forms.CheckedListBox();
            this.pbsRysownica = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnKolorTla = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPrzesunDoNowegoXY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbsRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj liczbę figur\r\n geometrycznych:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(65, 102);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 30);
            this.txtN.TabIndex = 1;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(12, 151);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(197, 60);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(963, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zaznacz figury geometryczne\r\ndo prezentacji (losowo wybierane)";
            // 
            // ckld_FiguryGeometryczne
            // 
            this.ckld_FiguryGeometryczne.FormattingEnabled = true;
            this.ckld_FiguryGeometryczne.Items.AddRange(new object[] {
            "Linia",
            "Elipsa",
            "Prostokąt",
            "Okrąg",
            "Koło",
            "Kwadrat",
            "Wielokąt"});
            this.ckld_FiguryGeometryczne.Location = new System.Drawing.Point(966, 83);
            this.ckld_FiguryGeometryczne.Name = "ckld_FiguryGeometryczne";
            this.ckld_FiguryGeometryczne.Size = new System.Drawing.Size(285, 179);
            this.ckld_FiguryGeometryczne.TabIndex = 4;
            this.ckld_FiguryGeometryczne.SelectedIndexChanged += new System.EventHandler(this.ckld_FiguryGeometryczne_SelectedIndexChanged);
            // 
            // pbsRysownica
            // 
            this.pbsRysownica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pbsRysownica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbsRysownica.Location = new System.Drawing.Point(234, 83);
            this.pbsRysownica.Name = "pbsRysownica";
            this.pbsRysownica.Size = new System.Drawing.Size(680, 480);
            this.pbsRysownica.TabIndex = 5;
            this.pbsRysownica.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnKolorTla
            // 
            this.btnKolorTla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolorTla.Location = new System.Drawing.Point(385, 23);
            this.btnKolorTla.Name = "btnKolorTla";
            this.btnKolorTla.Size = new System.Drawing.Size(371, 39);
            this.btnKolorTla.TabIndex = 6;
            this.btnKolorTla.Text = "Zmień kolor tła powierzchni kreślarskiej";
            this.btnKolorTla.UseVisualStyleBackColor = true;
            this.btnKolorTla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wzierniki narzędzi graficznych:\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(792, 617);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(111, 30);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(788, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zmień grubość linii";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(245, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zmień kolor linii";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(618, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Zmień styl linii";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "DashDot",
            "DashDotDot",
            "                  "});
            this.comboBox1.Location = new System.Drawing.Point(622, 617);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 27);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Zmień styl linii";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnPrzesunDoNowegoXY
            // 
            this.btnPrzesunDoNowegoXY.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzesunDoNowegoXY.Location = new System.Drawing.Point(12, 230);
            this.btnPrzesunDoNowegoXY.Name = "btnPrzesunDoNowegoXY";
            this.btnPrzesunDoNowegoXY.Size = new System.Drawing.Size(197, 109);
            this.btnPrzesunDoNowegoXY.TabIndex = 13;
            this.btnPrzesunDoNowegoXY.Text = "Przesuń wszystkie figury \r\ndo nowego położenia\r\n(wylosowane położenie)\r\n\r\n";
            this.btnPrzesunDoNowegoXY.UseVisualStyleBackColor = true;
            this.btnPrzesunDoNowegoXY.Click += new System.EventHandler(this.btnPrzesunDoNowegoXY_Click);
            // 
            // LaboratoriumNr2_Karpowicz61959
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 690);
            this.Controls.Add(this.btnPrzesunDoNowegoXY);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKolorTla);
            this.Controls.Add(this.pbsRysownica);
            this.Controls.Add(this.ckld_FiguryGeometryczne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LaboratoriumNr2_Karpowicz61959";
            this.Text = "Lab2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LaboratoriumNr2_Karpowicz61959_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbsRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ckld_FiguryGeometryczne;
        private System.Windows.Forms.PictureBox pbsRysownica;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnKolorTla;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrzesunDoNowegoXY;
    }
}
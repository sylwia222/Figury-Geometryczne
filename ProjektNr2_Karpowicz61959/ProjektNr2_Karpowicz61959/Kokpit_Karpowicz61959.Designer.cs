namespace ProjektNr2_Karpowicz61959
{
    partial class Kokpit_Karpowicz61959
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnProjekt = new System.Windows.Forms.Button();
            this.btnLaboratorium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(138, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Praktyczne poznanie paradygmatu Hermetyzacji, Dziedziczenia\r\ni Polimorfizmu na pr" +
    "zykładzie prezentacji figur geometrycznych";
            // 
            // btnProjekt
            // 
            this.btnProjekt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProjekt.Location = new System.Drawing.Point(481, 192);
            this.btnProjekt.Name = "btnProjekt";
            this.btnProjekt.Size = new System.Drawing.Size(264, 97);
            this.btnProjekt.TabIndex = 1;
            this.btnProjekt.Text = "Projekt indywidualny Nr 2\r\n(prezentacja figur geometrycznych\r\nkreślonych myszą)";
            this.btnProjekt.UseVisualStyleBackColor = true;
            this.btnProjekt.Click += new System.EventHandler(this.btnProjekt_Click);
            // 
            // btnLaboratorium
            // 
            this.btnLaboratorium.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLaboratorium.Location = new System.Drawing.Point(64, 192);
            this.btnLaboratorium.Name = "btnLaboratorium";
            this.btnLaboratorium.Size = new System.Drawing.Size(264, 97);
            this.btnLaboratorium.TabIndex = 2;
            this.btnLaboratorium.Text = "Laboratorium Nr 2\r\n(prezentacja losowo wybranych figur\r\ngeometrycznych)";
            this.btnLaboratorium.UseVisualStyleBackColor = true;
            this.btnLaboratorium.Click += new System.EventHandler(this.btnLaboratorium_Click);
            // 
            // Kokpit_Karpowicz61959
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLaboratorium);
            this.Controls.Add(this.btnProjekt);
            this.Controls.Add(this.label1);
            this.Name = "Kokpit_Karpowicz61959";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kokpit_Karpowicz61959_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProjekt;
        private System.Windows.Forms.Button btnLaboratorium;
    }
}


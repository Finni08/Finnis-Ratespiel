namespace Grundkurs2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.tbEingaben = new System.Windows.Forms.TextBox();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.lblVersuche = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.rtbEingaben = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(218, 203);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(130, 50);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Einloggen";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(12, 20);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(257, 20);
            this.lblheader.TabIndex = 1;
            this.lblheader.Text = "Errate eine Zahl zwischen 1 und 10";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEingaben
            // 
            this.tbEingaben.Location = new System.Drawing.Point(196, 269);
            this.tbEingaben.Name = "tbEingaben";
            this.tbEingaben.Size = new System.Drawing.Size(168, 20);
            this.tbEingaben.TabIndex = 2;
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErgebnis.Location = new System.Drawing.Point(238, 184);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(91, 16);
            this.lblErgebnis.TabIndex = 9;
            this.lblErgebnis.Text = "Ergebnislabel";
            // 
            // lblVersuche
            // 
            this.lblVersuche.AutoSize = true;
            this.lblVersuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersuche.Location = new System.Drawing.Point(479, 388);
            this.lblVersuche.Name = "lblVersuche";
            this.lblVersuche.Size = new System.Drawing.Size(86, 16);
            this.lblVersuche.TabIndex = 10;
            this.lblVersuche.Text = "Versuchlabel";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(215, 388);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(67, 16);
            this.lblWins.TabIndex = 11;
            this.lblWins.Text = "Winslabel";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(13, 381);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(83, 23);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Einstellungen";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(482, 17);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(83, 23);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "Hilfe";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // rtbEingaben
            // 
            this.rtbEingaben.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbEingaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rtbEingaben.Location = new System.Drawing.Point(444, 119);
            this.rtbEingaben.Name = "rtbEingaben";
            this.rtbEingaben.Size = new System.Drawing.Size(135, 170);
            this.rtbEingaben.TabIndex = 15;
            this.rtbEingaben.Text = "Vorherige Eingaben";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(591, 413);
            this.Controls.Add(this.rtbEingaben);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblVersuche);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.tbEingaben);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.btnlogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Finnis Ratespiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEingaben; 
        public System.Windows.Forms.Label lblheader;
        public System.Windows.Forms.Button btnlogin;
        public System.Windows.Forms.Label lblErgebnis;
        public System.Windows.Forms.Label lblVersuche;
        public System.Windows.Forms.Label lblWins;
        public System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Button btnHelp;
        public System.Windows.Forms.RichTextBox rtbEingaben;
    }
}


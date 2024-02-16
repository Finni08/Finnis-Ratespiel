namespace Grundkurs2
{
    public partial class Einstellungen
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
            this.btnKindergarten = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnReallyHard = new System.Windows.Forms.Button();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnKindergarten
            // 
            this.btnKindergarten.Location = new System.Drawing.Point(84, 88);
            this.btnKindergarten.Name = "btnKindergarten";
            this.btnKindergarten.Size = new System.Drawing.Size(132, 23);
            this.btnKindergarten.TabIndex = 0;
            this.btnKindergarten.Text = "Kindergarten: 1-10";
            this.btnKindergarten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKindergarten.UseVisualStyleBackColor = true;
            this.btnKindergarten.Click += new System.EventHandler(this.btnKindergarten_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(84, 117);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(132, 23);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "Einfach: 1-100";
            this.btnEasy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMiddle
            // 
            this.btnMiddle.Location = new System.Drawing.Point(84, 146);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(132, 23);
            this.btnMiddle.TabIndex = 2;
            this.btnMiddle.Text = "Mittel: 1-1000";
            this.btnMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiddle.UseVisualStyleBackColor = true;
            this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(84, 175);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(132, 23);
            this.btnHard.TabIndex = 3;
            this.btnHard.Text = "Schwer: 1-10000";
            this.btnHard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnReallyHard
            // 
            this.btnReallyHard.Location = new System.Drawing.Point(84, 204);
            this.btnReallyHard.Name = "btnReallyHard";
            this.btnReallyHard.Size = new System.Drawing.Size(132, 23);
            this.btnReallyHard.TabIndex = 4;
            this.btnReallyHard.Text = "Sehr Schwer: 1-100000";
            this.btnReallyHard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReallyHard.UseVisualStyleBackColor = true;
            this.btnReallyHard.Click += new System.EventHandler(this.btnReallyHard_Click);
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "Deutsch",
            "English",
            "français"});
            this.cbxLanguage.Location = new System.Drawing.Point(84, 233);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(132, 21);
            this.cbxLanguage.TabIndex = 5;
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(303, 333);
            this.Controls.Add(this.cbxLanguage);
            this.Controls.Add(this.btnReallyHard);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMiddle);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnKindergarten);
            this.Name = "Einstellungen";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnKindergarten;
        public System.Windows.Forms.Button btnEasy;
        public System.Windows.Forms.Button btnMiddle;
        public System.Windows.Forms.Button btnHard;
        public System.Windows.Forms.Button btnReallyHard;
        public System.Windows.Forms.ComboBox cbxLanguage;
    }
}
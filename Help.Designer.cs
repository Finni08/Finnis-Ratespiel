namespace Grundkurs2
{
    partial class Help
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
            this.tbhelp = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbhelp
            // 
            this.tbhelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhelp.Location = new System.Drawing.Point(0, -2);
            this.tbhelp.Multiline = true;
            this.tbhelp.Name = "tbhelp";
            this.tbhelp.ReadOnly = true;
            this.tbhelp.Size = new System.Drawing.Size(595, 228);
            this.tbhelp.TabIndex = 0;
            this.tbhelp.Text = "Dies ist das Offizielle Ratespiel von Finni\r\n\r\n\r\nUnterstüzer Seeloewen aka Louis9" +
    "\r\n\r\nSchaut gerne bei ihm vorbei den er hat mich erst zu zum programmieren gebrac" +
    "ht";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 223);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(595, 272);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Pachnotes: \n\n1.0\nFull game release \nwith unoptimezed code\n\n1.1\nOptimized code \n\n1" +
    ".2\nHelp text added";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 494);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbhelp);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbhelp;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
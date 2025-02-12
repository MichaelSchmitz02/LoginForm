namespace loginform
{
    partial class Form1
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
            this.txtkrIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtkrIme
            // 
            this.txtkrIme.Location = new System.Drawing.Point(151, 90);
            this.txtkrIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtkrIme.Name = "txtkrIme";
            this.txtkrIme.Size = new System.Drawing.Size(109, 20);
            this.txtkrIme.TabIndex = 0;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(151, 122);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(109, 20);
            this.txtLozinka.TabIndex = 1;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(180, 160);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(79, 25);
            this.btnPrijava.TabIndex = 2;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 298);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtkrIme);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkrIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijava;
    }
}


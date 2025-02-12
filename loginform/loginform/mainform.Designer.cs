namespace loginform
{
    partial class mainform
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
            this.btnAdminOnly = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminOnly
            // 
            this.btnAdminOnly.Location = new System.Drawing.Point(175, 125);
            this.btnAdminOnly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdminOnly.Name = "btnAdminOnly";
            this.btnAdminOnly.Size = new System.Drawing.Size(124, 34);
            this.btnAdminOnly.TabIndex = 0;
            this.btnAdminOnly.Text = "AdminOnly";
            this.btnAdminOnly.UseVisualStyleBackColor = true;
            this.btnAdminOnly.Visible = false;
            this.btnAdminOnly.Click += new System.EventHandler(this.btnAdminOnly_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(212, 52);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 13);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "label1";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnAdminOnly);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainform";
            this.Text = "mainform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminOnly;
        private System.Windows.Forms.Label lblRole;
    }
}
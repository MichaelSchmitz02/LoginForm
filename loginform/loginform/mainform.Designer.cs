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
            this.btnAdminOnly.Location = new System.Drawing.Point(262, 193);
            this.btnAdminOnly.Name = "btnAdminOnly";
            this.btnAdminOnly.Size = new System.Drawing.Size(186, 52);
            this.btnAdminOnly.TabIndex = 0;
            this.btnAdminOnly.Text = "AdminOnly";
            this.btnAdminOnly.UseVisualStyleBackColor = true;
            this.btnAdminOnly.Visible = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(262, 53);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 20);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "label1";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnAdminOnly);
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
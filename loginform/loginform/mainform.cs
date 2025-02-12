using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class mainform : Form
    {

        private bool isAdmin;
        public mainform()
        {
            InitializeComponent();
        }

        public mainform(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            ConfigureUI();
        }
        private void ConfigureUI()
        {
            if (isAdmin)
            {
                
                btnAdminOnly.Visible = true;  
                lblRole.Text = "Administrator";
            }
            else
            {
                
                btnAdminOnly.Visible = false; 
                lblRole.Text = "Korisnik";
            }
        }
    }
}

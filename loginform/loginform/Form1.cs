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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string username = txtkrIme.Text;
            string password = txtLozinka.Text;

            
            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Prijava uspješna! Dobrodošli, Administrator.");
                
                this.Hide();  
                mainform mainform = new mainform(true);  
                mainform.Show();
            }
            
            else if (username == "user" && password == "user123")
            {
                MessageBox.Show("Prijava uspješna! Dobrodošli, korisniče.");
                this.Hide();
                mainform mainForm = new mainform(false);  
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

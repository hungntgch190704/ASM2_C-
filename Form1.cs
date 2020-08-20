using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformASM
{
    public partial class CGV : Form
    {
        public CGV()
        {
            InitializeComponent();
        }

        private void CGV_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //create a new variable login
            Login login = new Login();
            //show Login form, and close this form
            login.Show();
            this.Hide();

        }

        //message box will annouce when click register button
        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function will be served soon!");
        }

        private void CGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

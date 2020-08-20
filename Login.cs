using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformASM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check if username and password are inputted or not
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                //check the account
                if (username == "user" && password == "123456")
                {
                    //close form login
                    this.Hide();
                    Identical identical = new Identical();
                    identical.Show();
                    this.Close();
                }
                //if account is not valid
                else
                {
                    MessageBox.Show("Incorrect username of password.");
                }
            }
            //if password or username are not be inputted
            else
            {
                MessageBox.Show("You must input both username and password");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}

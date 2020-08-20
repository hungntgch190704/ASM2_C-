using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinformASM
{
    public partial class Identical : Form
    {
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            Regex check_name = new Regex("^[a-zA-Z ]+$");
            string check_num = @"^\+?(?:0|84)(?:\d){9}$";
            string check_email = @"^[a-zA-Z][a-z0-9A-Z_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$";
            
            if (tbAdd.Text==""||tbEmail.Text==""||tbName.Text==""||tbNum.Text=="")
            {
                MessageBox.Show("You must input all information");
            }
            else if(check_name.IsMatch(tbName.Text) == false)
            {
                MessageBox.Show("Your name is invalid");
            }
            else if(Regex.IsMatch(tbNum.Text, check_num) == false)
            {
                MessageBox.Show("Invalid phone number");
            }
            else if(Regex.IsMatch(tbEmail.Text, check_email) == false)
            {
                MessageBox.Show("Invalid Email");
            }
            else if(tbAdd.Text.Length<5 || tbAdd.Text.Length>32)
            {
                MessageBox.Show("Invalid Address");
            }
            else
            {
                //create frmClient
                frmClient client = new frmClient();
                //call delegate
                client.Sender(tbName.Text, tbNum.Text, tbEmail.Text, tbAdd.Text);
                client.Show();
                this.Hide();
            }
        }

        public Identical()
        {
            InitializeComponent();
            
        }

        private void Identical_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

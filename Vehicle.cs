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
    public partial class Vehicle : Form
    {
        List<string> Info = new List<string>();
        decimal totalPrice = 0;
        public delegate void SendMessage(string information, string detail, decimal total);
        public SendMessage Sender;
        private void GetInfo(string information, string detail,decimal total)
        {
            Info.Add(information);
            Info.Add(detail);
            totalPrice += total;
        }
        public Vehicle()
        {
            InitializeComponent();
            Sender = new SendMessage(GetInfo);
            rbCar.Checked = false;
            rbHeli.Checked = false;
            rbOp1.Checked = false;
            rbYatch.Checked = false;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (rbOp1.Checked)
            {
                if (nudMotorbike.Value!=0)
                {
                    totalPrice += 10 * nudMotorbike.Value;
                    Info[1] += "\nVehicle: Motorbike\t" + "Amount: " + nudMotorbike.Value.ToString() + "\n";
                }
                else
                {
                    Info[1] += "";
                }
            }
            else if (rbCar.Checked)
            {
                if (nudCar.Value!=0)
                {
                    totalPrice += 20 * nudCar.Value;
                    Info[1] += "\nVehicle: Car\t" + "Amount: " + nudCar.Value.ToString() + "\n";
                }
                else
                {
                    Info[1] += "";
                }
            }
            else if(rbHeli.Checked)
            {
                if (nudHeli.Value!=0)
                {
                    totalPrice += 30 * nudHeli.Value;
                    Info[1] += "\nVehicle: Helicopter\t" + "Amount: " + nudHeli.Value.ToString() + "\n";
                }
                else
                {
                    Info[1] += "";
                }
            }
            else if (rbYatch.Checked)
            {
                if (nudYatch.Value!=0)
                {
                    totalPrice += 30 * nudYatch.Value;
                    Info[1] += "\nVehicle: Yatch\t" + "Amount: " + nudYatch.Value.ToString() + "\n";
                }
                else
                {
                    Info[1] += "";
                }
            }
            MessageBox.Show("HERE IS YOUR VERIFYING CODE: \n" + Info[0] + "\n" + Info[1] + "\n" + totalPrice +"$");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            MessageBox.Show("Thank you for experiencing CGV Booking Online! See you next time!");
            login.Show();
            this.Hide();
        }


        private void Vehicle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            nudCar.Value = 0;
            nudHeli.Value = 0;
            nudMotorbike.Value = 0;
            nudYatch.Value = 0;
            rbCar.Checked = false;
            rbHeli.Checked = false;
            rbOp1.Checked = false;
            rbYatch.Checked = false;
        }
    }
}

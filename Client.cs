using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformASM
{
    public partial class frmClient : Form
    {
        //ArrayList Now_Showing = new ArrayList();
        private static int totalNowShowing = 1000;
        private static int totalComingSoon = 1000;
        NowShowing_Film[] now_showing = new NowShowing_Film[totalNowShowing];
        ComingSoon_Film[] coming_soon = new ComingSoon_Film[totalComingSoon];
        string nameNow = "", nameSoon = "";
        string typeNow = "", typeSoon = "";
        string subtitleNow = "", subtitleSoon = "";
        string dateNow = "", dateSoon = "";
        string experienceNow = "";
        string castNow = "", castSoon = "";
        string directorNow = "", directorSoon = "";
        string distributorNow = "", distributorSoon = "";
        string synopsisNow = "", synopsisSoon = "";
        string imageNow = "", imageSoon = "";
        string information = "";
        string detail = "";
        decimal pop = 2;
        decimal drink = 1;
        decimal total = 0;
        decimal normalTicket = 5;
        decimal vipTicket = 6;
        decimal coupleTicket = 10;
        int count = 0;
        int index;
        private void lbPopcorn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbPopcorn_Click(object sender, EventArgs e)
        {

        }

        private void lbDrink_Click(object sender, EventArgs e)
        {
            
        }

        private void nudPopcorn_ValueChanged(object sender, EventArgs e)
        {
            decimal money = 0;
            //check whether user choose a product or not
            if (lbPopcorn.SelectedIndex==-1)
            {
                MessageBox.Show("You must select Popcorn first");
            }
            else //user already choose a product
            {
                //check for name of product then set the corresponding unit price
                if (lbPopcorn.SelectedItem.ToString() == "Caramel")
                    money += pop;
                else if (lbPopcorn.SelectedItem.ToString() == "Chocolate")
                    money += pop;
                else if (lbPopcorn.SelectedItem.ToString() == "Chocolate")
                    money += pop;
                else if (lbPopcorn.SelectedItem.ToString() == "None")
                    money += 0;
                    //calculate the money by this formula
                    //total_money = product_price * Product_quantity
                    money *= nudPopcorn.Value;
                total += money;
            }
        }

        private void nudDrink_ValueChanged(object sender, EventArgs e)
        {
            decimal money = 0;
            //check whether user choose a product or not
            if (lbDrink.SelectedIndex == -1)
            {
                MessageBox.Show("You must select Popcorn first");
            }
            else //user already choose a product
            {
                //check for name of product then set the corresponding unit price
                if (lbDrink.SelectedItem.ToString() == "Pepsi")
                    money += drink;
                else if (lbDrink.SelectedItem.ToString() == "Coca Cola")
                    money += drink;
                else if (lbDrink.SelectedItem.ToString() == "Fanta")
                    money += drink;
                else if (lbDrink.SelectedItem.ToString() == "None")
                    money += 0;
                //calculate the money by this formula
                //total_money = product_price * Product_quantity
                money *= nudDrink.Value;
                total += money;
            }
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("A1");
            detail += "A1 ";
            total += normalTicket;
            btnA1.Enabled = false;
            count++;
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("A2");
            detail += "A2 ";
            total += normalTicket;
            btnA2.Enabled = false;
            count++;
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("A3");
            detail += "A3 ";
            total += normalTicket;
            btnA3.Enabled = false;
            count++;
        }
        private void btnA4_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("A4");
            detail += "A4 ";
            total += normalTicket;
            btnA4.Enabled = false;
            count++;
        }
        private void btnA5_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("A5");
            detail += "A5 ";
            total += normalTicket;
            btnA5.Enabled = false;
            count++;
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("A6");
            total += normalTicket;
            detail += "A6 ";
            btnA6.Enabled = false;
            count++;
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("A7");
            detail += "A7 ";
            total += normalTicket;
            btnA7.Enabled = false;
            count++;
        }

        private void btnA8_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("A8");
            detail += "A8 ";
            total += normalTicket;
            btnA8.Enabled = false;
            count++;
        }

        private void btnA9_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("A9");
            detail += "A9 ";
            total += normalTicket;
            btnA9.Enabled = false;
            count++;
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("B1");
            detail += "B1 ";
            total += normalTicket;
            btnB1.Enabled = false;
            count++;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("B2");
            detail += "B2 ";
            total += normalTicket;
            btnB2.Enabled = false;
            count++;
        }
        private void btnB3_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("B3");
            detail += "B3 ";
            total += normalTicket;
            btnB3.Enabled = false;
            count++;
        }
        private void btnB4_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("B4");
            detail += "B4 ";
            total += normalTicket;
            btnB4.Enabled = false;
            count++;
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("B5");
            detail += "B5 ";
            total += normalTicket;
            btnB5.Enabled = false;
            count++;
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("B6");
            detail += "B6 ";
            total += normalTicket;
            btnB6.Enabled = false;
            count++;
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("B7");
            detail += "B7 ";
            total += normalTicket;
            btnB7.Enabled = false;
            count++;
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("B8");
            detail += "B8 ";
            total += normalTicket;
            btnB8.Enabled = false;
            count++;
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("B9");
            detail += "B9 ";
            total += normalTicket;
            btnB9.Enabled = false;
            count++;
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("C1");
            detail += "C1 ";
            total += normalTicket;
            btnC1.Enabled = false;
            count++;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("C2");
            detail += "C2 ";
            total += normalTicket;
            btnC2.Enabled = false;
            count++;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("C3");
            detail += "C3 ";
            total += normalTicket;
            btnC3.Enabled = false;
            count++;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("C4");
            detail += "C4 ";
            total += normalTicket;
            btnC4.Enabled = false;
            count++;
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("C5");
            detail += "C5 ";
            total += normalTicket;
            btnC5.Enabled = false;
            count++;
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("C6");
            detail += "C6 ";
            total += normalTicket;
            btnC6.Enabled = false;
            count++;
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("C7");
            detail += "C7 ";
            total += normalTicket;
            btnC7.Enabled = false;
            count++;
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("C8");
            detail += "C8 ";
            total += normalTicket;
            btnC8.Enabled = false;
            count++;
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("C9");
            detail += "C9 ";
            total += normalTicket;
            btnC9.Enabled = false;
            count++;
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("D1");
            detail += "D1 ";
            total += vipTicket;
            btnD1.Enabled = false;
            count++;
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("D2");
            detail += "D2 ";
            total += vipTicket;
            btnD2.Enabled = false;
            count++;
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("D3");
            detail += "D3 ";
            total += vipTicket;
            btnD3.Enabled = false;
            count++;
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("D4");
            detail += "D4 ";
            total += vipTicket;
            btnD4.Enabled = false;
            count++;
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("D5");
            detail += "D5 ";
            total += vipTicket;
            btnD5.Enabled = false;
            count++;
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("D6");
            detail += "D6 ";
            total += vipTicket;
            btnD6.Enabled = false;
            count++;
        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("D7 ");
            detail += "D7 ";
            total += vipTicket;
            btnD7.Enabled = false;
            count++;
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("D8");
            detail += "D8 ";
            total += vipTicket;
            btnD8.Enabled = false;
            count++;
        }

        private void btnD9_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("D9");
            detail += "D9 ";
            total += vipTicket;
            btnD9.Enabled = false;
            count++;
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("E1");
            detail += "E1 ";
            total += vipTicket;
            btnE1.Enabled = false;
            count++;
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("E2");
            detail += "E2 ";
            total += vipTicket;
            btnE2.Enabled = false;
            count++;
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("E3");
            detail += "E3 ";
            total += vipTicket;
            btnE3.Enabled = false;
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("E4");
            detail += "E4 ";
            total += vipTicket;
            btnE4.Enabled = false;
            count++;
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("E5");
            detail += "E5 ";
            total += vipTicket;
            btnE5.Enabled = false;
            count++;
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("E6");
            detail += "E6 ";
            total += vipTicket;
            btnE6.Enabled = false;
            count++;
        }

        private void btnE7_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("E7");
            detail += "E7 ";
            total += vipTicket;
            btnE7.Enabled = false;
            count++;
        }

        private void btnE8_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("E8");
            detail += "E8 ";
            total += vipTicket;
            btnE8.Enabled = false;
            count++;
        }

        private void btnE9_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("E9");
            detail += "E9 ";
            total += vipTicket;
            btnE9.Enabled = false;
            count++;
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("F1");
            detail += "F1 ";
            total += coupleTicket;
            btnF1.Enabled = false;
            count++;
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("F2");
            detail += "F2 ";
            total += coupleTicket;
            btnF2.Enabled = false;
            count++;
        }

        
        private void btnF3_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("F3");
            detail += "F3 ";
            total += coupleTicket;
            btnF3.Enabled = false;
            count++;
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("F4");
            detail += "F4 ";
            total += coupleTicket;
            btnF4.Enabled = false;
            count++;
        }


        private void btnF5_Click(object sender, EventArgs e)
        {
            lbSeat.Items.Add("F5");
            detail += "F5 ";
            total += coupleTicket;
            btnF5.Enabled = false;
            count++;
        }



        private void lbDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDrink.SelectedIndex == 0)
            {
                pbDrinks.Image = Image.FromFile("C:/Users/Asus/Downloads/Pepsi.jpg");
            }
            else if (lbDrink.SelectedIndex == 1)
            {
                pbDrinks.Image = Image.FromFile("C:/Users/Asus/Downloads/Coca.jpg");
            }
            else if (lbDrink.SelectedIndex == 2)
            {
                pbDrinks.Image = Image.FromFile("C:/Users/Asus/Downloads/Fanta.jpg");
            }
        }

        static String randomID()
        {
            String randomstring = Path.GetRandomFileName();
            randomstring = randomstring.Replace(".", string.Empty);
            return randomstring;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lbPopcorn.SelectedIndex != -1 && lbDrink.SelectedIndex != -1 && lbDate.SelectedIndex != -1 && detail != "" && lbShowTime.SelectedIndex != -1)
            {
                information = randomID() + "\n" + "Name: " + Info[0] + "\n" + "Phone Number: " + Info[1] +
                    "\n" + "Email: " + Info[2] + "\n" + "Address: " + Info[3] + "\n";
                detail += "\n" + lbPopcorn.SelectedItem.ToString() + " " + nudPopcorn.Value.ToString() + "\n" + lbDrink.SelectedItem.ToString() +
                    " " + nudDrink.Value.ToString() + "\n"
                    + lbClientFilm.SelectedItem.ToString()
                    + "\n" + lbDate.SelectedItem.ToString() + "\t" + lbShowTime.SelectedItem.ToString();
                Vehicle vehicle = new Vehicle();
                vehicle.Sender(information, detail, total);
                vehicle.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You must choose all information!");
            }
        }

        

        private void btnPurchase_Click_1(object sender, EventArgs e)
        {
           if (lbPopcorn.SelectedIndex!=-1 && lbDrink.SelectedIndex!=-1 && lbDate.SelectedIndex!=-1 && detail!="" && lbShowTime.SelectedIndex!=-1)
           {
                information = randomID() + "\n" + "Name: " + Info[0] + "\n" + "Phone Number: " + Info[1] + "\n" + "Email: " + Info[2] + "\n" + "Address: " + Info[3] + "\n";
                detail += "\n" + lbPopcorn.SelectedItem.ToString() + " " + nudPopcorn.Value.ToString() + "\n" + lbDrink.SelectedItem.ToString() +
                    " " + nudDrink.Value.ToString() + "\n"
                    + lbClientFilm.SelectedItem.ToString()
                    + "\n" + lbDate.SelectedItem.ToString() + "\t" + lbShowTime.SelectedItem.ToString();
                MessageBox.Show("HERE IS YOUR VERIFYING CODE: \n" + information + "\n" + detail + "\n" + total + "$");
                Login login = new Login();
                MessageBox.Show("Thank you for experiencing CGV Booking Online! See you next time!");
                login.Show();
                this.Hide();
            }     
           else
           {
                MessageBox.Show("You must choose all information!");
           }
        }

        private void frmClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //create a List<string> to store the passed parameter
        List<string> Info = new List<string>();
        //declare delegate
        public delegate void SendMessage(string Name, string PhoneNumber, string Email, string Address);
        public SendMessage Sender;
        //function that take the parameter
        private void GetInfo(string Name, string PhoneNumber, string Email, string Address)
        {
            Info.Add(Name);
            Info.Add(PhoneNumber);
            Info.Add(Email);
            Info.Add(Address);
        }
        public frmClient()
        {
            InitializeComponent();
            //create a pointer to GetInfo function
            Sender = new SendMessage(GetInfo);
            nameNow = "Train To Busan Presents Peninsula";
            typeNow = "18 + ONLY: Action, Horror, Thriller - 115 Minutes - Korean";
            subtitleNow = "Bahasa Melayu, Chinese, English";
            dateNow = "07/16/2020";
            experienceNow = "Classic, Indulge, Luxe, Deluxe, ONYX, Deluxe+, IMAX®, Infinity, Flexound, Plushy, Prestige";
            castNow = "Gang Dong-Won, Lee Jung-Hyun, Kwon Hae-Hyo";
            directorNow = "Yeon Sang-Ho";
            distributorNow = "GSCM";
            synopsisNow = "Jung-seok, a soldier who previously escaped the diseased wasteland, " +
                "relives the horror when assigned to a covert operation with two simple objectives: retrieve and survive. " +
                "When his team unexpectedly stumbles upon survivors, their lives will depend on whether the best—or " +
                "worst—of human nature prevails in the direst of circumstances.";
            imageNow = "C:/Users/Asus/Downloads/traintobusan2.jpg";
            now_showing[0] = new NowShowing_Film(nameNow, typeNow, subtitleNow, dateNow, experienceNow, castNow, directorNow, distributorNow, synopsisNow, imageNow);


            nameNow = "The Sonata";
            typeNow = "18+ ONLY: Mystery, Thriller - 90 Minutes - English";
            subtitleNow = "Bahasa Melayu";
            dateNow = "07/23/2020";
            experienceNow = "Classic, Indulge, Luxe, Deluxe";
            castNow = "Freya Tingley, Simon Abkarian, James Faulkner, Rutger Hauer";
            directorNow = "Andrew Desmond";
            distributorNow = "TGVP";
            synopsisNow = "After the death of her estranged father, a famous but reclusive composer, " +
                "musical prodigy Rose inherits the old mansion he had been living in. She goes there with her protective manager " +
                "and discovers an unpublished score. However, dark forces are triggered as she continues to unravel her father`s past."; ;
            imageNow = "C:/Users/Asus/Downloads/thesonata.jpg";
            now_showing[1] = new NowShowing_Film(nameNow, typeNow, subtitleNow, dateNow, experienceNow, castNow, directorNow, distributorNow, synopsisNow, imageNow);


            nameNow = "Intruder";
            typeNow = "18+ ONLY: Mystery, Thriller - 103 Minutes - Korean";
            subtitleNow = "Bahasa Melayu, Chinese, English";
            dateNow = "07/23/2020";
            experienceNow = "Classic, Indulge, Luxe, Deluxe";
            castNow = "Song Ji-Hyo, Kim Mu-Yeol, Ye Soo-Jung, Heo Joon-Seok";
            directorNow = "Sohn Won-Pyeong";
            distributorNow = "GSCM";
            synopsisNow = "25 years ago, Seo-Jin`s sister Yoo-Jin went missing and he`s been" +
                " traumatised by the incident since. Now he is a successful architect but " +
                "his life changes when one day, Yoo-Jin suddenly comes back home. Despite her" +
                " return being good news, Seo-Jin can`t help but feel doubtful about the woman who claims to be his sister.";
            imageNow = "C:/Users/Asus/Downloads/intruder.jpg";
            now_showing[2] = new NowShowing_Film(nameNow, typeNow, subtitleNow, dateNow, experienceNow, castNow, directorNow, distributorNow, synopsisNow, imageNow);


            nameNow = "Psiko-4 Mantan";
            typeNow = "18+ ONLY: Horror, Thriller - 80 Minutes - Indonesian";
            subtitleNow = "Bahasa Melayu, English";
            dateNow = "07/23/2020";
            experienceNow = "Classic";
            castNow = "Jeff Smith, Denira Wiraguna, Amanda Manopo, Ranty Maria, Melayu Nicole";
            directorNow = "Harry R Saputra";
            distributorNow = "Antenna Entertainment";
            synopsisNow = "Despite their different backgrounds, one tragedy has found Sara," +
                " Airin, Rachel and Amara, the news of their ex-lover Alex's death. The conflict escalated when " +
                "the four girls received a letter from Alex, stating that if they received the letter after her death, " +
                "one of them was a murderer. Trapped in fear, they now have to investigate and uncover who the real killer is.";
            imageNow = "C:/Users/Asus/Downloads/Psiko-4Mantan.jpg";
            now_showing[3] = new NowShowing_Film(nameNow, typeNow, subtitleNow, dateNow, experienceNow, castNow, directorNow, distributorNow, synopsisNow, imageNow);


            nameNow = "John Wick: Chapter 3 - Parabellum";
            typeNow = "18+ ONLY: Action, Thriller - 130 Minutes - English";
            subtitleNow = "Bahasa Melayu, English";
            dateNow = "05/16/2019";
            experienceNow = "Classic, Indulge";
            castNow = "Keanu Reeves, Halle Berry, Ian McShane, Ruby Rose";
            directorNow = "Chad Stahelski";
            distributorNow = "TGVP";
            synopsisNow = "Legendary hitman John Wick is on the run for two reasons: a USD14 million global contract out on his life has turned him into the target of the world`s top assassins, " +
                "and he has also broken a central rule by killing a High Table member on Continental Hotel grounds. He is given a one-hour " +
                "grace period by the Continental`s manager, Winston, to escape before his membership is revoked and he is banned from all services.";
            imageNow = "C:/Users/Asus/Downloads/Parabellum.jpg";
            now_showing[4] = new NowShowing_Film(nameNow, typeNow, subtitleNow, dateNow, experienceNow, castNow, directorNow, distributorNow, synopsisNow, imageNow);


            nameNow = "It: Chapter Two";
            typeNow = "18+ ONLY: Horror, Thriller - 170 Minutes - English";
            subtitleNow = "Bahasa Melayu, Chinese";
            dateNow = "09/05/2019";
            experienceNow = "Classic, Indulge";
            castNow = "ames McAvoy, Jessica Chastain, Jay Ryan, Bill Hader, Isaiah Mustafa, James Ransone, Andy Bean, Bill Skarsgard";
            directorNow = "Andy Muschietti";
            distributorNow = "Warner Bros";
            synopsisNow = "27 years have passed since the events of summer 1989. " +
                "The Losers` Club are all grown up and have moved out of Derry, Maine. " +
                "But a phone call brings them back to the town as the evil It has returned. " +
                "They reunite to fulfil their childhood promise of taking It down once and for all, unaware that It is now stronger and has been waiting for their return.";
            imageNow = "C:/Users/Asus/Downloads/It2.jpg";
            now_showing[5] = new NowShowing_Film(nameNow, typeNow, subtitleNow, dateNow, experienceNow, castNow, directorNow, distributorNow, synopsisNow, imageNow);

            nameSoon = "Wonder Woman 1984";
            typeSoon = "Action, Superhero";
            subtitleSoon = "Bahasa Melayu, Chinese, English";
            dateSoon = "10/01/2020";
            castSoon = "Gal Gadot, Chris Pine, Kristen Wiig, Pedro Pascal";
            directorSoon = "Patty Jenkins";
            distributorSoon = "Warner Bros";
            synopsisSoon = "During the Cold War in the 1980s, Diana Prince a.k.a. Wonder Woman comes into " +
                "conflict with the Soviet Union. She also has to square off against Cheetah, a villainess with " +
                "superhuman strength.";
            imageSoon = "C:/Users/Asus/Downloads/ww84.jpg";
            coming_soon[0] = new ComingSoon_Film(nameSoon, typeSoon, subtitleSoon, dateSoon, castSoon, directorSoon, distributorSoon, synopsisSoon, imageSoon);

            nameSoon = "Sebelum Iblis Menjemput Ayat 2";
            typeSoon = "Horror";
            subtitleSoon = "Bahasa Melayu, Chinese, English";
            dateSoon = "08/27/2020";
            castSoon = "Chelsea Islan, Baskara Mahendra, Hadijah Shahab, Widika Sidmore, Karina Salim, Arya Vasco";
            directorSoon = "Timo Tjahjanto";
            distributorSoon = "TGVP";
            synopsisSoon = "Two sisters, Alfie and Nara, are the only survivors of a demonic " +
            "terror that destroyed their family two years ago. Even as Alfie tries to live a normal " +
            "life, she is still haunted by terrifying visions. To her horror, she realises that she and " +
            "her friends are now in danger as a mysterious evil entity threatens them.";
            imageSoon = "C:/Users/Asus/Downloads/sebelum_iblis_menjemput_2.jpg";
            coming_soon[1] = new ComingSoon_Film(nameSoon, typeSoon, subtitleSoon, dateSoon, castSoon, directorSoon, distributorSoon, synopsisSoon, imageSoon);

            nameSoon = "Sakral:Keramat";
            typeSoon = "Horror";
            subtitleSoon = "Bahasa Melayu, Chinese, English";
            dateSoon = "08/23/2020";
            castSoon = " Olla Ramlan, Teuku Zacky, Makayla Rose Hilli";
            directorSoon = "Tema Patrosza";
            distributorSoon = "Antenna Entertainment";
            synopsisSoon = "Melina`s family is plagued by a mysterious entity " +
            "and more alarmingly, the people who are close to her are dying one by one." +
            " When her husband, Daniel, tries to uncover the cause behind the strange haunting " +
            "and deaths, he discovers that everything is related to their twin infant who died years" +
            " ago. Melina has never gotten over the death, while the surviving twin, Flora, has grown" +
            " up to be a sullen and mysterious 5-year-old. The more Daniel tries to unravel the mystery, " +
            "the more danger his family faces.";
            imageSoon = "C:/Users/Asus/Downloads/sakral-keramat.jpg";
            coming_soon[2] = new ComingSoon_Film(nameSoon, typeSoon, subtitleSoon, dateSoon, castSoon, directorSoon, distributorSoon, synopsisSoon, imageSoon);

            nameSoon = "Roh";
            typeSoon = "Mystery, Drama, Horror";
            subtitleSoon = "Bahasa Melayu, Chinese, English";
            dateSoon = "08/23/2020";
            castSoon = "Farah Ahmad, Mhia Farhana, Harith Haziq, Nam Ron, Junainah M. Lojong, Putri Syahadah Nurqaseh";
            directorSoon = "Emir Ezwan";
            distributorSoon = "TGVP";
            synopsisSoon = "Set in the unspecified past during wartime, a family is spooked" +
            " by the arrival of a mysterious and sinister young guest; who in the family will survive?";
            imageSoon = "C:/Users/Asus/Downloads/roh.jpg";
            coming_soon[3] = new ComingSoon_Film(nameSoon, typeSoon, subtitleSoon, dateSoon, castSoon, directorSoon, distributorSoon, synopsisSoon, imageSoon);

            nameSoon = "Candyman";
            typeSoon = "Horror";
            subtitleSoon = "Bahasa Melayu, Chinese, English";
            dateSoon = "09/24/2020";
            castSoon = "Yahya Abdul-Mateen II, Teyonah Parris, Nathan Stewart-Jarrett, Colman Domingo, Vanessa Estelle Williams, Tony Todd";
            directorSoon = "Nia DaCost";
            distributorSoon = "United International Pictures";
            synopsisSoon = "This movie serves as a sequel to the 1992 horror movie Candyman. " +
            "It is set in the same Chicago neighbourhood where the legend began, but the section where the" +
            " Cabrini-Green housing projects once stood is now gentrified. After visual artist Anthony McCoy moves " +
            "into a luxury condo there with his girlfriend, gallery director Brianna Cartwright, he soon learns about " +
            "the vengeful spirit that haunts the place. Called Candyman, he becomes fascinated by it and begins using the " +
            "macabre details behind the supernatural killer`s true story as inpiration for his new paintings. Unfortunately " +
            "for him, this leads to not only a horrifying wave of violence but also forces him to face his past which unravels his sanity.";
            imageSoon = "C:/Users/Asus/Downloads/candyman.jpg";
            coming_soon[4] = new ComingSoon_Film(nameSoon, typeSoon, subtitleSoon, dateSoon, castSoon, directorSoon, distributorSoon, synopsisSoon, imageSoon);

            nameSoon = "Fukushima 50";
            typeSoon = "Drama";
            subtitleSoon = "Bahasa Melayu, Chinese, English";
            dateSoon = "09/27/2020";
            castSoon = "Setsuro Wakamatsu";
            directorSoon = "Koichi Sato, Ken Watanabe, Hidetaka Yoshioka, Narumi Yasuda";
            distributorSoon = "GSCM";
            synopsisSoon = "Fukushima Daiichi Nuclear Power Plant is hit by a tsunami, " +
            "triggered by a magnitude 9.0 earthquake, on 11 March 2011. Risking their lives, " +
            "50 employees remain at the power plant to manage the nuclear disaster and prevent further " +
            "destruction. The movie is based on Japanese journalist Ryūshō Kadota`s non-fiction book, On the " +
            "Brink: The Inside Story of Fukushima Daiichi and will show the reality that the group of 50 workers face while inside the plant.";
            imageSoon = "C:/Users/Asus/Downloads/fuku50.jpg";
            coming_soon[5] = new ComingSoon_Film(nameSoon, typeSoon, subtitleSoon, dateSoon, castSoon, directorSoon, distributorSoon, synopsisSoon, imageSoon);

            lbPopcorn.Items.Add("Caramel");
            lbPopcorn.Items.Add("Chocolate");
            lbPopcorn.Items.Add("Mint");
            lbPopcorn.Items.Add("None");

            lbDrink.Items.Add("Pepsi");
            lbDrink.Items.Add("Cola Cola");
            lbDrink.Items.Add("Fanta");
            lbDrink.Items.Add("None");
        }

        private void rbNowShowing_CheckedChanged_1(object sender, EventArgs e)
        {
            //Clear all films in listbox first
            lbClientFilm.Items.Clear();
            //Add items to list box
            lbClientFilm.Items.Add("Train To Busan Presents Peninsula");
            lbClientFilm.Items.Add("The Sonata");
            lbClientFilm.Items.Add("Intruder");
            lbClientFilm.Items.Add("Psiko-4 Mantan");
            lbClientFilm.Items.Add("John Wick: Chapter 3 - Parabellum");
            lbClientFilm.Items.Add("It: Chapter Two");
            //Clear all days in listbox first
            lbDate.Items.Clear();
            //Add items to listbox
            lbDate.Items.Add("1-AUG");
            lbDate.Items.Add("2-AUG");
            lbDate.Items.Add("3-AUG");
            lbDate.Items.Add("4-AUG");
            lbDate.Items.Add("5-AUG");
            lbDate.Items.Add("6-AUG");
            lbDate.Items.Add("7-AUG");
            lbDate.Items.Add("8-AUG");

            //Clear all showtimes in listbox first
            lbShowTime.Items.Clear();
            //Add items to listbox
            lbShowTime.Items.Add("9:00AM");
            lbShowTime.Items.Add("11:00AM");
            lbShowTime.Items.Add("1:00PM");
            lbShowTime.Items.Add("3:00PM");
            lbShowTime.Items.Add("5:00PM");
            lbShowTime.Items.Add("7:00PM");
            lbShowTime.Items.Add("9:00PM");
            lbShowTime.Items.Add("11:00PM");

            
        }
        

        private void rbComingSoon_CheckedChanged_1(object sender, EventArgs e)
        {
            //Clear all films in listbox first
            lbClientFilm.Items.Clear();
            //Add items to list box
            lbClientFilm.Items.Add("Wonder Woman 1984");
            lbClientFilm.Items.Add("Sebelum Iblis Menjemput Ayat 2");
            lbClientFilm.Items.Add("Sakral:Keramat");
            lbClientFilm.Items.Add("Roh");
            lbClientFilm.Items.Add("Candyman");
            lbClientFilm.Items.Add("Fukushima 50");

            //Clear all days in listbox first
            lbDate.Items.Clear();
            //Add items to listbox
            lbDate.Items.Add("1-DEC");
            lbDate.Items.Add("2-DEC");
            lbDate.Items.Add("3-DEC");
            lbDate.Items.Add("4-DEC");
            lbDate.Items.Add("5-DEC");
            lbDate.Items.Add("6-DEC");
            lbDate.Items.Add("7-DEC");
            lbDate.Items.Add("8-DEC");

            //Clear all showtimes in listbox first
            lbShowTime.Items.Clear();
            //Add items to listbox
            lbShowTime.Items.Add("9:00AM");
            lbShowTime.Items.Add("11:00AM");
            lbShowTime.Items.Add("1:00PM");
            lbShowTime.Items.Add("3:00PM");
            lbShowTime.Items.Add("5:00PM");
            lbShowTime.Items.Add("7:00PM");
            lbShowTime.Items.Add("9:00PM");
            lbShowTime.Items.Add("11:00PM");
        }

        private void lbClientFilm_DoubleClick(object sender, EventArgs e)
        {
            if (rbNowShowing.Checked)
            {
                try
                {
                    index = lbClientFilm.SelectedIndex;
                    tbFilm.Text = now_showing[index].Name;
                    tbCast.Text = now_showing[index].Cast;
                    tbDirector.Text = now_showing[index].Director;
                    tbDistributor.Text = now_showing[index].Distributor;
                    tbEx.Text = now_showing[index].Experience;
                    tbSub.Text = now_showing[index].Subtitle;
                    tbType.Text = now_showing[index].Type;
                    dtpDate.Value = DateTime.Parse(now_showing[index].Date);
                    rtbSynopsis.Text = now_showing[index].Synopsis;
                    pbFilm.Image = Image.FromFile(now_showing[index].Image);
                    tbFilm.Enabled = false;
                    tbCast.Enabled = false;
                    tbDirector.Enabled = false;
                    tbDistributor.Enabled = false;
                    tbEx.Enabled = false;
                    tbSub.Enabled = false;
                    tbType.Enabled = false;
                    dtpDate.Enabled = false;
                    rtbSynopsis.Enabled = false;
                }
                catch (Exception)
                {

                }
            }
            else if (rbComingSoon.Checked)
            {
                try
                {
                    index = lbClientFilm.SelectedIndex;
                    tbFilm.Text = coming_soon[index].Name;
                    tbCast.Text = coming_soon[index].Cast;
                    tbDirector.Text = coming_soon[index].Director;
                    tbDistributor.Text = coming_soon[index].Distributor;
                    tbSub.Text = coming_soon[index].Subtitle;
                    tbType.Text = coming_soon[index].Type;
                    dtpDate.Value = DateTime.Parse(coming_soon[index].Date);
                    rtbSynopsis.Text = coming_soon[index].Synopsis;
                    pbFilm.Image = Image.FromFile(coming_soon[index].Image);
                    tbFilm.Enabled = false;
                    tbCast.Enabled = false;
                    tbDirector.Enabled = false;
                    tbDistributor.Enabled = false;
                    tbEx.Enabled = false;
                    tbSub.Enabled = false;
                    tbType.Enabled = false;
                    dtpDate.Enabled = false;
                    rtbSynopsis.Enabled = false;
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

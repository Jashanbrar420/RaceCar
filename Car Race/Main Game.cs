using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Race
{
    public partial class Form1 : Form
    {
        Guys[] Bet_Obj = new Guys[3];//calling the object of other class
        Racers[] Racer_obj = new Racers[4];

        string name1 = "John";
        string name2 = "Sam";//here u can put the name of pople who are betting
        string name3 = "Sarah";

        public Form1()
        {
            InitializeComponent();

            Bet_Obj[0] = new Guys()
            {
                bettor = name1,
                Racer_RB = BetGuy1,
                Racer_lb = Racer1,
                Cash = 50,
                bets = null
            };

            Bet_Obj[1] = new Guys()
            {
                bettor = name2,
                Racer_RB = BetGuy2,
                Racer_lb = Racer2,
                Cash = 50,
                bets = null
            };

            Bet_Obj[2] = new Guys()
            {
                bettor = name3,
                Racer_RB = BetGuy3,
                Racer_lb = Racer3,
                Cash = 50,
                bets = null
            };

            Racer_obj[0] = new Racers()
            {
                MyPictureBox = pictureBox1,
                tracklenght = pictureBox5.Width
            };
            Racer_obj[1] = new Racers()
            {
                MyPictureBox = pictureBox2,
                tracklenght = pictureBox5.Width
            };
            Racer_obj[2] = new Racers()
            {
                MyPictureBox = pictureBox3,
                tracklenght = pictureBox5.Width
            };
            Racer_obj[3] = new Racers()
            { MyPictureBox = pictureBox4,
                tracklenght = pictureBox5.Width
            };

            label7.Text = "Minimum bet is " + betUPdown.Minimum + " bucks";

            for (int t = 0; t <= 2; t++)//this the for loop for updating lables
            {
                Bet_Obj[t].Racer_lable();
            }
            for (int t = 0; t <= 3; t++)
            {
                Racer_obj[t].Racerstart();
            }

            label9.Text = name1;
            label7.Text = "Minimum bet is " + betUPdown.Minimum;
        }

        private void radioGuy1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = name1;
        }

        private void radioGuy2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = name2;
        }

        private void radioGuy3_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = name3;
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            if (BetGuy1.Checked)
            {
                Bet_Obj[0].betMake((int)betUPdown.Value, (int)RacerUpdown.Value);
                Bet_Obj[0].Racer_lable();
            }
            else if (BetGuy2.Checked)
            {
                Bet_Obj[1].betMake((int)betUPdown.Value, (int)RacerUpdown.Value);
                Bet_Obj[1].Racer_lable();
            }
            else if (BetGuy3.Checked)
            {
                Bet_Obj[2].betMake((int)betUPdown.Value, (int)RacerUpdown.Value);
                Bet_Obj[2].Racer_lable();
            }
        }

        private void buttonRace_Click(object sender, EventArgs e)
        {
            Gobtn.Enabled = false;
            timer1.Start();//this starts the timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Racer_obj.Length; i++)//this is a for loop
            {
                if (Racer_obj[i].Engine())
                {
                    i += 1;
                    timer1.Stop();
                    MessageBox.Show("And the first position goes To #" + i, "test");//this is meesgae pop up for the winner
                    for (int ii = 0; ii < Bet_Obj.Length; ii++)
                    {
                        Bet_Obj[ii].Winner(i);
                        Bet_Obj[ii].ClearBet();
                        Bet_Obj[ii].Racer_lable();
                    }
                    for (int n = 0; n < Racer_obj.Length; n++) { Racer_obj[n].nextracepos(); }
                    Gobtn.Enabled = true;
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Parent = pictureBox5;
            pictureBox2.Parent = pictureBox5;
            pictureBox3.Parent = pictureBox5;
            pictureBox4.Parent = pictureBox5;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

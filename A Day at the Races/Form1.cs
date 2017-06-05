using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public partial class Form1 : Form
    {

        Guy[] guy = new Guy[3];
        Greyhound[] dogs = new Greyhound[4];
        public Random randomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            guy[0] = new Guy()
            {
                name = "Joe",
                cash = 50,
                myRadioButton = joeRadioButton,
                myBet = null,
                myLabel = joeBetLabel
            };

            guy[1] = new Guy()
            {
                name = "Bob",
                cash = 75,
                myRadioButton = bobRadioButton,
                myBet = null,
                myLabel = bobBetLabel
            };

            guy[2] = new Guy()
            {
                name = "Al",
                cash = 45,
                myRadioButton = alRadioButton,
                myBet = null,
                myLabel = alBetLabel
            };

            for (int i = 0; i < guy.Length; i++)
            {
                guy[i].updateLabels();
            }

            dogs[0] = new Greyhound()
            {
                MyPictureBox = dog1,
                startingPostition = dog1.Left,
                raceTrackLength = raceTrack.Width - dog1.Width,
                randomizer = randomizer
            };
            dogs[1] = new Greyhound()
            {
                MyPictureBox = dog2,
                startingPostition = dog2.Left,
                raceTrackLength = raceTrack.Width - dog2.Width,
                randomizer = randomizer
            };
            dogs[2] = new Greyhound()
            {
                MyPictureBox = dog3,
                startingPostition = dog3.Left,
                raceTrackLength = raceTrack.Width - dog3.Width,
                randomizer = randomizer
            };
            dogs[3] = new Greyhound()
            {
                MyPictureBox = dog4,
                startingPostition = dog4.Left,
                raceTrackLength = raceTrack.Width - dog4.Width,
                randomizer = randomizer
            };

            minimumBetLabel.Text = "Minimum Bet: " + betAmount.Minimum;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                if (dogs[i].Run())
                {

                    timer1.Stop();
                    int winner = i + 1;

                    MessageBox.Show("Dog #" + winner + " won the race!");

                    for (int j = 0; j < guy.Length; j++)
                    {
                        guy[j].collect(winner);
                        guy[j].clearBet();
                        guy[j].updateLabels();
                    }

                    for (int k = 0; k < dogs.Length; k++)
                    {
                        dogs[k].takeStartingPostition();
                        groupBox1.Enabled = true;
                        
                    }
                        break;
                }
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            joeRadioButton.Text = guy[0].name +" has " + guy[0].cash + " bucks";
        }

        private void race_Click(object sender, EventArgs e)
        {
            if (guy[0].myBet == null || guy[1].myBet == null || guy[2].myBet == null)
            {
                MessageBox.Show("Everyone must place a bet");
            }

            if (guy[0].myBet != null && guy[1].myBet != null && guy[2].myBet != null)
            {
                groupBox1.Enabled = false;
                timer1.Start();
            }
            
        }

        private void bets_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                guy[0].placeBet((int)betAmount.Value, (int)dogNumberToBet.Value);
                joeBetLabel.Text = guy[0].myBet.getDescription();
            }
            if (bobRadioButton.Checked)
            {
                guy[1].placeBet((int)betAmount.Value, (int)dogNumberToBet.Value);
                bobBetLabel.Text = guy[1].myBet.getDescription();
            }
            if (alRadioButton.Checked)
            {
                guy[2].placeBet((int)betAmount.Value, (int)dogNumberToBet.Value);
                alBetLabel.Text = guy[2].myBet.getDescription();
            }
        }
    }
}

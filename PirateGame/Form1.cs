using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PirateGame
{
    
    public partial class pirateVoyage : Form
    {
        int page;

        Random randGen = new Random();
        new SoundPlayer introSound = new SoundPlayer(Properties.Resources.intro);
        new SoundPlayer shipSound = new SoundPlayer(Properties.Resources.ship);
        new SoundPlayer victorySound = new SoundPlayer(Properties.Resources.victory);
        new SoundPlayer deathSound = new SoundPlayer(Properties.Resources.death);
        new SoundPlayer fightSound = new SoundPlayer(Properties.Resources.fights);

        public pirateVoyage()
        {
            InitializeComponent();

            option1.Visible = false;
            option2.Visible = false;
            option3.Visible = false;

            introSound.PlayLooping();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            option1.Visible = true;
            option2.Visible = true;
            introSound.Stop();

            page = 1;

            DisplayPage();
        }
        private void option1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 20;
            }
            else
            {
                page = 99;
            }
            DisplayPage();
        }       
        private void option2_Click(object sender, EventArgs e)
        {
            int randGenValue = randGen.Next(1, 11);
            
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 2)
            {
                if (randGenValue > 6)
                {
                    page = 4;
                }
                else
                {
                    page = 5;
                }
            }
            else if (page == 7)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 9)
            {
                page = 7;
            }
            else
            {
                page = 1;
            }
            DisplayPage();
        }
        private void option3_Click(object sender, EventArgs e)
        {
            if (page == 3)
            {
                page = 8;
            }
            DisplayPage();
        }
        private void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are a pirate with a 10 man crew. Your goal is to become rich.\nWhat do you do?";
                    option1.Text = "Fight pirates";
                    option2.Text = "Explore";
                    pictureBox.BackgroundImage = (Properties.Resources.pirate_symbol);
                    shipSound.PlayLooping();
                    break;
                case 2:
                    outputLabel.Text = "You encounter a pirate crew of 15 men.\nDo you fight?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    pictureBox.BackgroundImage = (Properties.Resources.pirate_crew);
                    fightSound.PlayLooping();
                    break;
                case 3:
                    option3.Visible = true;
                    outputLabel.Text = "You come across a habited island.\nWhat do you do?";
                    option1.Text = "Peacefully Visit";
                    option2.Text = "Raid";
                    option3.Text = "Keep exploring";
                    pictureBox.BackgroundImage = (Properties.Resources.Island);
                    shipSound.PlayLooping();
                    break;
                case 4:
                    outputLabel.Text = "You kill them and steal their riches.\nYou are now very rich.\nPlay again?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    pictureBox.BackgroundImage = (Properties.Resources.Rich_image);
                    victorySound.PlayLooping();
                    break;
                case 5:
                    outputLabel.Text = "You get demolished by the enemies.\nPlay again?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    pictureBox.BackgroundImage = (Properties.Resources.DeathImage);
                    deathSound.PlayLooping();
                    break;
                case 6:
                    outputLabel.Text = "The villagers were Kung Fu masters and they kill you.\nPlay again?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    option3.Visible = false;
                    pictureBox.BackgroundImage = (Properties.Resources.DeathImage);
                    deathSound.PlayLooping();
                    break;
                case 7:
                    outputLabel.Text = "You come across an casino.\nDo you enter?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Visible = false;
                    pictureBox.BackgroundImage = (Properties.Resources.Casino);
                    break;
                case 8:
                    outputLabel.Text = "You never step foot on that island and leave.\nIt's been a while and you are low on supplies.";
                    option1.Text = "Fish";
                    option2.Text = "Phone marines";
                    option3.Visible = false;
                    pictureBox.BackgroundImage = (Properties.Resources.pirate_ship);
                    shipSound.PlayLooping();
                    break;
                case 9:
                    outputLabel.Text = "You get some more food.\nYou come across another island.\nWhat do you do?";
                    option1.Text = "Keep exploring";
                    option2.Text = "Visit";
                    pictureBox.BackgroundImage = (Properties.Resources.pirate_ship);
                    shipSound.PlayLooping();
                    break;
                case 10:
                    outputLabel.Text = "You can't find land then you run out of food and starve to death.\nPlay again?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    pictureBox.BackgroundImage = (Properties.Resources.DeathImage);
                    deathSound.PlayLooping();
                    break;
                case 11:
                    outputLabel.Text = "The marines save you and throw you in jail where you\nrot for the rest of your life.\nPlay again?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    pictureBox.BackgroundImage = (Properties.Resources.DeathImage);
                    deathSound.PlayLooping();
                    break;
                case 12:
                    outputLabel.Text = "You gamble and become dirt poor.\nPlay again?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    pictureBox.BackgroundImage = (Properties.Resources.DeathImage);
                    deathSound.PlayLooping();
                    break;
                case 13:
                    outputLabel.Text = "You somehow find yourself at an auction.\nThere is a painting for $1000.\nDo you buy it?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    pictureBox.BackgroundImage = (Properties.Resources.Casino);
                    break;
                case 14:
                    outputLabel.Text = "You later find out that the painting is worth quite a lot and\nsell it to become rich.";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    pictureBox.BackgroundImage = (Properties.Resources.Rich_image);
                    victorySound.PlayLooping();
                    break;
                case 15:
                    outputLabel.Text = "You explore the island more, looking for supplies.\nA massive gang robs you.\nWhat do you do?";
                    option1.Text = "Fight";
                    option2.Text = "Run";
                    pictureBox.BackgroundImage = (Properties.Resources.Gang);
                    break;
                case 16:
                    outputLabel.Text = "You lose a couple of men but get your money back.\nDo you follow the gang back to their hideout?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    pictureBox.BackgroundImage = (Properties.Resources.Gang);
                    fightSound.PlayLooping();
                    break;
                case 17:
                    outputLabel.Text = "You are now dirt poor.\nPlay again? ";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    pictureBox.BackgroundImage = (Properties.Resources.Gang);
                    deathSound.PlayLooping();
                    break;
                case 18:
                    outputLabel.Text = "You notice that they have lots of money laying around.\nDo you try and rob them?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    pictureBox.BackgroundImage = (Properties.Resources.Gang);
                    fightSound.PlayLooping();
                    break;
                case 19:
                    outputLabel.Text = "You do nothing with your life, you are now old and not rich.\nPlay again?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    pictureBox.BackgroundImage = (Properties.Resources.DeathImage);
                    deathSound.PlayLooping();
                    break;
                case 20:
                    outputLabel.Text = "You are the only one who survives and you become rich.\nPlay again?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    pictureBox.BackgroundImage = (Properties.Resources.Rich_image);
                    victorySound.PlayLooping();
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing!";
                    option1.Text = "";
                    option2.Text = "";

                    option1.Visible = false;
                    option2.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
            }
        }
    }
}


//Created by Sam Wyatt and Doyle Blacklock
//To create a text based adventure game
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

namespace Adventure_Game_Summative
{
    public partial class Form1 : Form
    {
        string name;
        int scene = 0;
        Random randNum = new Random();

        SoundPlayer themeSong = new SoundPlayer(Properties.Resources._320553__griffon_designs__dirty_grind);
        public Form1()
        {
            InitializeComponent();

            redButtonPicture.Visible = false;
            yellowButtonPicture.Visible = false;
            blueButtonPicture.Visible = false;
            firstChoiceLabel.Visible = false;
            secondChoiceLabel.Visible = false;
            thirdChoiceLabel.Visible = false;
        }
        private void beginButton_Click(object sender, EventArgs e)
        {
            name = nameInput.Text;

            Graphics formGraphics = this.CreateGraphics();
            Font bigFont = new Font("Consolas", 25, FontStyle.Bold);
            Font smallFont = new Font("Consolas", 10, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen whitePen = new Pen(Color.White, 2);
            Point[] shape = { new Point(100, 360), new Point(260, 360), new Point(260, 140), new Point(100, 140), new Point(100, 360) };
            formGraphics.DrawPolygon(whitePen, shape);

            formGraphics.DrawString("R.I.P", bigFont, drawBrush, 125, 150);
            formGraphics.DrawString(name, bigFont, drawBrush, 140, 180);
            formGraphics.DrawString("Died of:", smallFont, drawBrush, 100, 220);




            name = nameInput.Text;

            if (nameInput.Text == "")
            {
                titleLabel.Text = "Welcome adventurer, what is your name?\nPlease enter your name.";
            }
            else
            {
                themeSong.PlayLooping();

                nameInput.Visible = false;
                firstButtonLabel.Visible = false;
                beginButton.Visible = false;

                beginButton.Enabled = false;

              //  redButtonPicture.Visible = true;
            //    yellowButtonPicture.Visible = true;
           //     blueButtonPicture.Visible = true;
           //     firstChoiceLabel.Visible = true;
           //     secondChoiceLabel.Visible = true;
          //      thirdChoiceLabel.Visible = true;

                titleLabel.Text = name + " looks at his phone. It reads: November 1, 12:00 AM. " + name + " looks around himself and barely makes out an abandoned lab at Central. What should " + name + " do?";
                firstChoiceLabel.Text = "Check the front door";
                secondChoiceLabel.Text = "Check the back door";
                thirdChoiceLabel.Text = "Investigate the lab";
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            SoundPlayer billNye = new SoundPlayer(Properties.Resources.Bill_Nye__The_Science_Guy__Original_Intro___);

            int deathChance = randNum.Next(1, 101);
            int windowChance = randNum.Next(1, 101);

            if (e.KeyCode == Keys.R)
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 5)
                {
                    scene = 6;
                }
                else if (scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 13;
                }
                else if (scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 14)
                {
                    scene = 16;
                }
                else if (scene == 17 && deathChance <= 50)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 19;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 23;
                }
                else if (scene == 23)
                {
                    scene = 25;
                }
                else if (scene == 6)
                {
                    scene = 0;
                }
                else if (scene == 3)
                {
                    scene = 0;
                }
                else if (scene == 4)
                {
                    scene = 0;
                }
                else if (scene == 8)
                {
                    scene = 0;
                }
                else if (scene == 11)
                {
                    scene = 0;
                }
                else if (scene == 12)
                {
                    scene = 0;
                }
                else if (scene == 13)
                {
                    scene = 0;
                }
                else if (scene == 15)
                {
                    scene = 0;
                }
                else if (scene == 19)
                {
                    scene = 0;
                }
                else if (scene == 21)
                {
                    scene = 0;
                }
                else if (scene == 25)
                {
                    scene = 0;
                }
                else if (scene == 18)
                {
                    scene = 0;
                }
                else if (scene == 26)
                {
                    scene = 0;
                }
                else if (scene == 27)
                {
                    scene = 0;
                }
                else if (scene == 28)
                {
                    scene = 0;
                }
            }

            else if (e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 9)
                {
                    scene = 14;
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 2)
                {
                    scene = 20;
                }
                else if (scene == 17 && deathChance <= 70)
                {
                    scene = 21;
                }
                else if (scene == 17)
                {
                    scene = 22;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 23;
                }
                else if (scene == 23 && windowChance <= 70 && deathChance <= 50)
                {
                    scene = 26;
                }
                else if (scene == 23 && windowChance > 75)
                {
                    scene = 27;
                }
                else if (scene == 23 && deathChance > 50)
                {
                    scene = 28;
                }
                else if (scene == 6)
                {
                    Application.Exit();
                }
                else if (scene == 3)
                {
                    Application.Exit();
                }
                else if (scene == 4)
                {
                    Application.Exit();
                }
                else if (scene == 8)
                {
                    Application.Exit();
                }
                else if (scene == 11)
                {
                    Application.Exit();
                }
                else if (scene == 12)
                {
                    Application.Exit();
                }
                else if (scene == 13)
                {
                    Application.Exit();
                }
                else if (scene == 15)
                {
                    Application.Exit();
                }
                else if (scene == 19)
                {
                    Application.Exit();
                }
                else if (scene == 21)
                {
                    Application.Exit();
                }
                else if (scene == 25)
                {
                    Application.Exit();
                }
                else if (scene == 18)
                {
                    Application.Exit();
                }
                else if (scene == 26)
                {
                    Application.Exit();
                }
                else if (scene == 27)
                {
                    Application.Exit();
                }
                else if (scene == 28)
                {
                    Application.Exit();
                }
            }

            else if (e.KeyCode == Keys.Y)
            {
                if (scene == 0)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    scene = 24;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
            }

            switch (scene)
            {
                case 0:
                    titleLabel.Text = name + " looks at his phone. It reads: November 1, 12:00 AM." + name + "looks around himself and barely makes out an abandoned lab at Central. What should" + name + "do?";
                    firstChoiceLabel.Text = "Check the front door";
                    secondChoiceLabel.Text = "Check the back door";
                    thirdChoiceLabel.Text = "Investigate the lab";
                    break;
                case 1:
                    titleLabel.Text = "The door is unlocked, " + name + " heres an eerie rustle behind them. What should " + name + " do?";
                    firstChoiceLabel.Text = "Run away from the mysterious noise";
                    secondChoiceLabel.Text = "Turn around and investigate";
                    thirdChoiceLabel.Text = "";
                    break;
                case 2:
                    themeSong.Stop();
                    billNye.PlayLooping();

                    titleLabel.Text = "The door is unlocked, " + name + " hears the Bill Nye theme song behind them. Should. " + name;
                    firstChoiceLabel.Text = "Sing along";
                    secondChoiceLabel.Text = "See what is going on";
                    thirdChoiceLabel.Text = "";
                    break;
                case 3:
                    billNye.Stop();
                    themeSong.PlayLooping();

                    titleLabel.Text = name + " was jamming too hard and got killed by the monster. If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 4:
                    titleLabel.Text = name + " is caught by the monster and slaughtered. If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 5:
                    titleLabel.Text = name + " sees a figure in the darkness and shuts the door then runs down the stairs to the second floor. Should" + name + "enter the library or continue running down the stairs?.";
                    firstChoiceLabel.Text = "Continue running down the stairs";
                    secondChoiceLabel.Text = "Enter the Library";
                    thirdChoiceLabel.Text = "";
                    break;
                case 6:
                    titleLabel.Text = name + " is caught by the monster and killed. If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 7:
                    titleLabel.Text = name + " enters the library and barricades the door with a table. " + name + "Realizes that there are onky two exits. Which exit should" + name + " take?";
                    firstChoiceLabel.Text = "Left door";
                    secondChoiceLabel.Text = "Right door";
                    thirdChoiceLabel.Text = "";
                    break;
                case 8:
                    titleLabel.Text = name + " is caught by the monster and killed. If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 9:
                    titleLabel.Text = "The door is unlocked and " + name + "runs down the stairs to the first floor. Should " + name + "go into the cafeteria or attempt to escape through the back doors.";
                    firstChoiceLabel.Text = "Cafeteria";
                    secondChoiceLabel.Text = "Back doors";
                    thirdChoiceLabel.Text = "";
                    break;
                case 10:
                    titleLabel.Text = name + " enters the cafeteria and sees that the exits are blocked. What should " + name + " do?";
                    firstChoiceLabel.Text = "Pray for your life";
                    secondChoiceLabel.Text = "Break the window";
                    thirdChoiceLabel.Text = "Fight";
                    break;
                case 11:
                    titleLabel.Text = "The monster throws a chair at " + name + " and knocks them out. " + name + " doesn't know what happened next... If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 12:
                    titleLabel.Text = "The glass is too thick to break and the monster kills " + name + " If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 13:
                    titleLabel.Text = "The monster laughs at " + name + "'s attempt to survive. The monster kills " + name + "If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 14:
                    titleLabel.Text = "The back doors are locked. What should  " + name + " do?";
                    firstChoiceLabel.Text = "Fight the monster";
                    secondChoiceLabel.Text = "Look for another exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 15:
                    titleLabel.Text = name + " is caught by the monster and killed. If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 16:
                    titleLabel.Text = name + " fights the monster... coming soon.";
                    firstChoiceLabel.Visible = false;
                    secondChoiceLabel.Visible = false;
                    thirdChoiceLabel.Visible = false;
                    redButtonPicture.Visible = false;
                    blueButtonPicture.Visible = false;
                    yellowButtonPicture.Visible = false;

                    Refresh();
                    Thread.Sleep(1000);

                    Application.Exit();
                    break;
                case 17:
                    titleLabel.Text = name + " finds three test tubes, which one should " + name + " investigate?";
                    firstChoiceLabel.Text = "Green test tube";
                    secondChoiceLabel.Text = "Yellow test tube";
                    thirdChoiceLabel.Text = "Colourless test tube";
                    break;
                case 18:
                    titleLabel.Text = name + " picks up and unstoppers the test tube and is overtaken by a strange desire to drink the contents " + name + " begins to feel a mysterious change. " + name + "suddenly turns into a large green monster and easily escapes the school. You win! If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 19:
                    titleLabel.Text = name + " picks up and unstoppers the test tube and is overtaken by a strange desire to drink the contents " + name + " begins to feel a mysterious change. " + name + " suddenly loses conciousness and has no recollection of what happens next...If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 20:
                    titleLabel.Text = name + " sees a random student jamming out to the bill nye theme song. Should " + name;
                    firstChoiceLabel.Text = "Try to get some information";
                    secondChoiceLabel.Text = "Run down the stairs";
                    thirdChoiceLabel.Text = "";
                    break;
                case 21:
                    titleLabel.Text = name + " unstoppers the test tube and the test tube emits a gas which kills you. If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 22:
                    titleLabel.Text = name + " unstoppers the test tube and the test tube emits a gas which is harmless. What should" + name + " do?";
                    firstChoiceLabel.Text = "Check the front door";
                    secondChoiceLabel.Text = "Check the back door";
                    thirdChoiceLabel.Text = "";
                    break;
                case 23:
                    titleLabel.Text = name + " checks the door and the door is locked. Just to be certain " + name + " checks the other door and it is also locked. What should " + name + "do?";
                    firstChoiceLabel.Text = "Wait until morning";
                    secondChoiceLabel.Text = "Attempt to break the window and escape";
                    thirdChoiceLabel.Text = "";
                    break;
                case 24:
                    titleLabel.Text = name + " unstoppers the test tube and it turns out to be just water. What should " + name + "do?";
                    firstChoiceLabel.Text = "Check the front door";
                    secondChoiceLabel.Text = "Check the back door";
                    thirdChoiceLabel.Text = "";
                    break;
                case 25:
                    titleLabel.Text = name + " survives the night but is found in the morning and suspended on the spot. You win!...kinda. If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 26:
                    titleLabel.Text = name + " breaks the window and survives the jump. " + name + " escapes the school. You win! If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 27:
                    titleLabel.Text = name + " fails to break the window. " + name + " is forced to stay the night. " + name + " survives the night but is found in the morning and suspended on the spot. You win!...kinda. If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 28:
                    titleLabel.Text = name + " breaks the window but doesn't surivie the jump. You lose! If you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
            }
        }
    }
}

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

namespace Adventure_Game_Summative
{
    public partial class Form1 : Form
    {
        string name;
        int scene = 0;
        Random randNum = new Random();

        public Form1()
        {
            InitializeComponent();

            middlePictureBox.Visible = false;
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

            if (nameInput.Text == "")
            {
                titleLabel.Text = "Welcome adventurer, what is your name?\nPlease enter your name.";
            }
            else
            {
                nameInput.Visible = false;
                firstButtonLabel.Visible = false;
                beginButton.Visible = false;

                beginButton.Enabled = false;

                middlePictureBox.Visible = true;
                redButtonPicture.Visible = true;
                yellowButtonPicture.Visible = true;
                blueButtonPicture.Visible = true;
                firstChoiceLabel.Visible = true;
                secondChoiceLabel.Visible = true;
                thirdChoiceLabel.Visible = true;

                titleLabel.Text = name + " looks at his phone. It reads: November 1, 12:00 AM. " + name + " looks around himself and barely makes out an abandoned lab at Central. What should " + name + " do?";
                firstChoiceLabel.Text = "Check the front door";
                secondChoiceLabel.Text = "Check the back door";
                thirdChoiceLabel.Text = "Investigate the lab";
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

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
            }

            else if (e.KeyCode == Keys.Y)
            {
                if (scene == 10)
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
                    titleLabel.Text = "The door is unlocked, " + name + " hears the Bill Nye theme song behind them. Do you want to.";
                    firstChoiceLabel.Text = "Sing along";
                    secondChoiceLabel.Text = "See what is going on";
                    thirdChoiceLabel.Text = "";
                    break;
                case 3:
                    titleLabel.Text = name + " was jamming too hard and got killed by the monster.\nIf you want to restart press R. If you want to exit press B.";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 4:
                    titleLabel.Text = name + " gggis caught by the monster and slaughtered.\nIf you want to restart press R. If you want to exit press B.";
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
                    titleLabel.Text = name + " hhhhhis caught by the monster and killed.\nIf you want to restart press R. If you want to exit press B.";
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
                    titleLabel.Text = name + "fffff is caught by the monster and killed.\nIf you want to restart press R. If you want to exit press B.";
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
                    titleLabel.Text = "The monster throws a chair at " + name + " and knocks them out. " + name + " doesn't know what happened next...";
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 12:
                    titleLabel.Text = "The glass is too thick to break and the monster kills " + name;
                    firstChoiceLabel.Text = "Restart";
                    secondChoiceLabel.Text = "Exit";
                    thirdChoiceLabel.Text = "";
                    break;
                case 13:
                    titleLabel.Text = "The monster laughs at " + name + "'s attempt to survive. The monster kills you.";
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
                    titleLabel.Text = name + " is caught by the monster and killed.\nIf you want to restart press R. If you want to exit press B.";
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
                    break;
            }
        }


    }
}

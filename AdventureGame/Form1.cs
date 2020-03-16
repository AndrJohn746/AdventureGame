/// created by : Andrew Johnson
/// date       : 03/14/20
/// description: A basic text adventure game engine

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

namespace AdventureGame
{
    public partial class Form1 : Form
    {

        int scene = 0;

        readonly Random RANDGEN = new Random();


        public Form1()
        {
            InitializeComponent();
        }


       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if blue button pressed
            if (e.KeyCode == Keys.B)
            {
                //if (scene == x) {scene = y;}
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 18; }
                else if (scene == 3) { scene = 1; }
            }

            //if yellow button pressed
            else if (e.KeyCode == Keys.N)
            {
                //if (scene == x) {scene = y;}
                if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 18) { scene = 3; }
            }

            //if red button pressed
            else if (e.KeyCode == Keys.M)
            {
                //if (scene == x) {scene = y;}
                if (scene == 0) { scene = 99; }
                else if (scene == 1) { scene = 2; }
                else if (scene == 3) { scene = 99; }
            }


            //decides what scene will play
            switch (scene)
            {
                /*
                    outputLabel.Text = "";
                    imageBox.Image = Properties.Resources.scene_x;
                    blueButton.Text = "";
                    yellowButton.Text = "";
                    redButton.Text = "";
                 */
                case 0:
                    outputLabel.Text = "Welcome to Wario Dating Simulator, currently in build v1.0.0!";
                    imageBox.Image = Properties.Resources.scene_0;
                    blueButton.Text = "Play Game";
                    yellowButton.Text = "";
                    redButton.Text = "Exit Game";
                    break;
                case 1:
                    outputLabel.Text = "Wario is picking you up for your date in 10 minutes! What will you wear?";
                    imageBox.Image = Properties.Resources.scene_1;
                    blueButton.Text = "Your sleek, red dress";
                    yellowButton.Text = "Your dirty clothes you haven't changed out of this week";
                    redButton.Text = "A yellow shirt with purple suspenders";
                    break;
                case 2:
                    outputLabel.Text = "Wario arrives and sees how you've dressed.";
                    outputLabel.Text += "\n\nWario is too embarrassed you are 'twinning' with him, and he dumps you on the spot.";
                    imageBox.Image = Properties.Resources.scene_2;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "Game over! \n\nWould you like to play again?";
                    imageBox.Image = Properties.Resources.scene_3;
                    blueButton.Text = "Yes";
                    yellowButton.Text = "";
                    redButton.Text = "No";
                    break;
                case 18:
                    outputLabel.Text = "You put on the dress and you wait for Wario.";
                    outputLabel.Text += "\n\nIt's now been a week since the supposed 'date' and Wario still hasn't arrived. You realize you've been stood up, and die of a heartbreak. ";
                    imageBox.Image = Properties.Resources.scene_18;
                    blueButton.Text = "";
                    yellowButton.Text = "Accept your fate";
                    redButton.Text = "";
                    break;
                case 99: //Exit the environment
                    Environment.Exit(1);
                    break;
                default:
                    outputLabel.Text = "Welcome to Wario Dating Simulator, currently in build v1.0.0!";
                    imageBox.Image = Properties.Resources.scene_0;
                    blueButton.Text = "Play Game";
                    yellowButton.Text = "";
                    redButton.Text = "Exit Game";
                    break;
            }
        }
    }
}

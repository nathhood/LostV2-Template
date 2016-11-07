/// created by : 
/// date       : 
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
//test
namespace LostV2
{
    public partial class Form1 : Form
    {
        int scene = 0;  // tracks what part of the game the user is at

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "You're lost in a forest. Do you want to go North or South?";
            redLabel.Text = "North";
            blueLabel.Text = "South";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.R)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }

            }
                if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "You're lost in a forest. Do you want to go North or South?";
                    redLabel.Text = "North";
                    blueLabel.Text = "South";
                    break;
                case 1:
                    outputLabel.Text = "You come to a lake. Would you like to take a drink?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "You fall in a pit and die.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "The water is stagnent. Yo die of chlorea.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You see a horse in the water. o you try and ride?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You tame the horse and ride to safety. You win!!!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "You die of loneliness as the horse runs away.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                default:
                    break;
            }
        }
    }

}

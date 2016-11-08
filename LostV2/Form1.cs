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

        Random randGen = new Random();// create a random number generator 
        int scene = 0;  // tracks what part of the game the user is at

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "You find yourself in the last round of a CS:GO match. Which side are you on?";
            redLabel.Text = "Terrorist";
            blueLabel.Text = "Counter-Terrorist";
            greenLabel.Text = "";
            awpPic.Visible = false;
            akPic.Visible = false;
            m4pic.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 10;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 4;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }

            }
            if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 9;
                }
                else if (scene == 2)
                {
                    scene = 5;
                }
                else if (scene == 3)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    scene = 8;
                }
                else if (scene == 10)
                {
                    //get random number for the variable
                    int percentValue = randGen.Next(1, 11);
                    //30% chance to win the round
                    if (percentValue >= 4)
                    {
                        scene = 12;
                    }
                    else if (percentValue <= 3)
                    {
                        scene = 13;
                    }
                }
            }
            if (e.KeyCode == Keys.Space)       //green button press
            {
                if (scene == 1)
                {
                    scene = 14;
                }
                else if (scene == 4||scene == 6||scene  == 7|| scene == 8||scene == 9||scene == 11||scene == 12||scene == 13||scene == 14)
                {
                    scene = 0;
                }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "You find yourself in the last round of a CS:GO match. Which side are you on?";
                    redLabel.Text = "Terrorist";
                    blueLabel.Text = "Counter-Terrorist";
                    greenLabel.Text = "";
                    teamPickPic.Visible = true;
                    awpPic.Visible = false;
                    akPic.Visible = false;
                    m4pic.Visible = false;
                    break;
                case 1:
                    outputLabel.Text = "You have no money to buy an awp. You get an M4 and armor. Do you go B site or Lower Tunnels.";
                    redLabel.Text = "B Site";
                    blueLabel.Text = "Lower Tunnels";
                    greenLabel.Text = "CAT";
                    teamPickPic.Visible = false;
                    m4pic.Visible = true;
                    break;
                case 2:
                    outputLabel.Text = "You can choose an AWP or AK with armor";
                    redLabel.Text = "AWP";
                    blueLabel.Text = "AK and Armor";
                    greenLabel.Text = "";
                    teamPickPic.Visible = false;
                    awpPic.Visible = true;
                    akPic.Visible = true;

                    break;
                case 3:
                    outputLabel.Text = "Do you rush mid, or go long to get the pick";
                    redLabel.Text = "Rush Mid";
                    blueLabel.Text = "Pick Long";
                    greenLabel.Text = "";
                    awpPic.Visible = false;
                    akPic.Visible = false;
                    break;
                case 4:
                    outputLabel.Text = "You get picked off by an awper you die. Your team losses";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Restart";
                    break;
                case 5:
                    outputLabel.Text = "Your team can rush B or go CAT. Where do you go?";
                    redLabel.Text = "Rush B";
                    blueLabel.Text = "Go CAT";
                    greenLabel.Text = "";
                    awpPic.Visible = false;
                    akPic.Visible = false;
                    break;
                case 6:
                    outputLabel.Text = "You pick off an enemy peeking the doors. You continue to go long  with your team and get the bomb  down, you win.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Restart";
                    break;
                case 7:
                    outputLabel.Text = "You rush B and get bomb plant. The Counter Terrorists can not retake the site to defuse. You win";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Restart";
                    break;
                case 8:
                    outputLabel.Text = "Your team gets spotted by a CT in mid and you get shot. Your team dies when they continue to push CAT and you loose";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Restart";
                    break;
                case 9:
                    outputLabel.Text = "There is a Terrorist mid and you get taken out by him when you peak doors. You die and your team cannot hold them back. You loose.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Restart";
                    break;
                case 10:
                    outputLabel.Text = "You are on B site and see enemy players rushing out. Do you stay to kill them or leave to retake.";
                    redLabel.Text = "Run";
                    blueLabel.Text = "Stay";
                    greenLabel.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "You left too late. Someone peaks B doors and head shots you running mid. You die and your team cannot retake the site without you. You lose.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Restart";
                    break;
                case 12:
                    outputLabel.Text = "You get taken out without killing anybody. Your team cant retake without you. You lose.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Restart";
                    break;
                case 13:
                    outputLabel.Text = "You get an ACE, killing the entire Terrorist team. You win the match for the team!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Restart";
                    break;
                case 14:
                    outputLabel.Text = "The Terrorists push CAT and take you out. They continue to the open A Site, plant the bomb and win the match. You loose.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    greenLabel.Text = "Restart";
                    break;
                default:
                    break;
            }
        }
    }
}
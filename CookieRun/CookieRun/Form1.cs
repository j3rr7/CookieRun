using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieRun
{
    public partial class Form1 : Form
    {
        Graphics g;
        int timer = 3;
        int refreshTickPlayer = 45; //Refresh Rate Player Animation

        Cookies player = new Cookies();

        public Form1()
        {
            InitializeComponent();
        }
        




        private void Form1_Load(object sender, EventArgs e)
        {
            picPlayer.Visible = false;

            this.GerakPlayerTimer.Interval = this.refreshTickPlayer; //Constraint interval player gerak

            //Timer Start
            //=====================
            this.ValidationTimer.Start();
            this.CooldownTimer.Start();
            this.GerakPlayerTimer.Start();
            //=====================

        }





        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            //Draw cooldown if nessesary
            //=====================
            int center_x = (this.Width / 2) - 90; //trick to center the text x
            int center_y = (this.Height / 2) - 90; //trick to center the text y
            if (timer > 0)
            {
                g.DrawString(this.timer.ToString(), new Font("Verdana", 100f), new SolidBrush(Color.DarkCyan), new Point(center_x, center_y));
            }
            //=====================


            Rectangle r = new Rectangle(picPlayer.Location, new Size(60, 90));
            g.FillRectangle(new SolidBrush(Color.Red), r);
        }





        //Event validate every few Second
        //=====================
        private void ValidationTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        //=====================





        //Timer for cooldown as same as player wont move until cooldown is over
        //=====================
        private void CooldownTimer_Tick(object sender, EventArgs e)
        {
            if (this.timer > 0)
            {
                this.timer -= 1;
                
            }
            else
            {
                player.Status = 1; // Change Player status
                this.CooldownTimer.Stop();
            }
        }
        //=====================





        //Run gerak player
        //=====================
        int counter_gerak = 1;
        private void GerakPlayerTimer_Tick(object sender, EventArgs e)
        {
            //IF the return Image is valid assign it to parent if not counter back to 1 (assumed every player animation name start with 1)
            //--------------------
            if (player.getAnimation(counter_gerak) != null)
            {
                this.picPlayer.Image = player.getAnimation(counter_gerak);
                counter_gerak += 1;
            }
            else
            {
                counter_gerak = 1;
            }
            //--------------------
        }
        //=====================




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //KEYCODE SPACE , W ,and Up arrow
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                if (player.Status == 1)//Check if player is running
                {
                    playerJumping();//DEPRECATED
                    player.Status = 2;
                }
            }

            //KEYCODE for speed is doubled (just dor debugging process - please delete later)
            if (e.KeyCode == Keys.D)
            {
                if (player.Status == 1)//if player is running
                {
                    player.Status = 99;//run boost
                    this.GerakPlayerTimer.Interval = 20;//change
                }
            }

            //KEYCODE for sliding
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down || e.KeyCode == Keys.LShiftKey)
            {
                if (player.Status == 1) //if player is running
                {
                    player.Status = 3; //sliding
                }
            }
        }





        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //KEYCODE SPACE , W ,and Up arrow
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                if (player.Status == 2) //Check if player is still jumping
                {
                    playerJumping();//DEPRECATED
                    player.Status = 1;
                }
            }

            //KEYCODE for speed is doubled (just dor debugging process - please delete later)
            if (e.KeyCode == Keys.D)
            {
                if (player.Status == 99)//if player is runboost
                {
                    player.Status = 1;//restore state to running
                    this.GerakPlayerTimer.Interval = refreshTickPlayer;//restore 
                }
            }

            //KEYCODE for sliding
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down || e.KeyCode == Keys.LShiftKey)
            {
                if (player.Status == 3) //if player is sliding
                {
                    player.Status = 1; //restore state to running
                }
            }
        }





        //[ToDo do the dynamic animation of jumping and sliding]
        //COBA COBA
        bool isJumping = false;
        public void playerJumping()
        {
            isJumping = !isJumping;
            if (isJumping)
            {
                picPlayer.Location = new Point(picPlayer.Location.X, picPlayer.Location.Y - 30);
            }
            else
            {
                picPlayer.Location = new Point(picPlayer.Location.X, picPlayer.Location.Y + 30);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 't')
            {
                picPlayer.Visible = !picPlayer.Visible;
            }
        }
    }
}

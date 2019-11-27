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

namespace CookieRun
{
    public partial class Form1 : Form
    {
        Graphics g;

        int timer = 3;

        int refreshTickPlayer = 60; //Refresh Rate Player Animation

        Cookies player = new Cookies();

        //JUMP INITIALIZATION
        //==================
        const int ground_height = 290;
        const int jump_height = 100;
        bool isMaxHeightJump = false;
        bool isJumping = false;
        //==================


        //BACKGROUND
        List<int> posisiBackground = new List<int>();
        Image backgroundImg;
        bool isStarted = false;


        //SOUND AND MUSIC
        System.Media.SoundPlayer mm_music = new System.Media.SoundPlayer(Properties.Resources.SoundBgm_Lobby_epN01);
        System.Media.SoundPlayer bg_music;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = true;

            picPlayer.BackColor = Color.Transparent;    // <- set color to transparent

            //Constraint interval player gerak
            this.GerakPlayerTimer.Interval = this.refreshTickPlayer;

            //Timer Start
            //=====================
            this.ValidationTimer.Start();
            //=====================

            //Background
            //=====================
            backgroundImg = CookieRun.Properties.Resources.background;
            posisiBackground.Add(1);    //posisi background kiri x
            posisiBackground.Add(800);  //posisi background kanan x
            //=====================

            mm_music.PlayLooping();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            //Draw Background
            //=====================
            if (isStarted)
            {
                for (int i = 0; i < posisiBackground.Count; i++)
                {
                    g.DrawImage(backgroundImg, posisiBackground[i], 0, 800, 450); // gambar , x , y , w , h 800 450
                }
            }
            //=====================

            //Draw cooldown if nessesary
            //=====================
            int center_x = (this.Width / 2) - 90;   //trick to center the text x
            int center_y = (this.Height / 2) - 90;  //trick to center the text y
            if (timer > 0)
            {
                g.DrawString(this.timer.ToString(), new Font("Verdana", 100f), new SolidBrush(Color.DarkCyan), new Point(center_x, center_y));
            }
            //=====================

            //Draw hitbox Player
            //=====================
            if (player.Status != 3)
            {
                Rectangle r = new Rectangle(new Point(picPlayer.Location.X + 40, picPlayer.Location.Y + 60), new Size(50, 60));
                g.DrawRectangle(new Pen(Color.Red, 2), r);
            }
            else
            {
                Rectangle r = new Rectangle(new Point(picPlayer.Location.X + 40, picPlayer.Location.Y + 90), new Size(60, 30));
                g.DrawRectangle(new Pen(Color.Red, 2), r);
            }
            //=====================
        }

        private void gerakBackground_Tick(object sender, EventArgs e)
        {
            //Gerak Background
            for (int i = 0; i < 2; i++)
            {
                posisiBackground[i] -= 5; //atur kecepataan player
                if (posisiBackground[i] <= -800)
                {
                    posisiBackground[i] += (800 * 2) - 4; //kirim gambar habis ke kanan
                }
            }
        }

        //Event validate every few Second
        private void ValidationTimer_Tick(object sender, EventArgs e)
        {
            CekJump();
            Invalidate();
        }

        //Timer for cooldown as same as player wont move until cooldown is over
        private void CooldownTimer_Tick(object sender, EventArgs e)
        {
            if (this.timer > 0)
            {
                this.timer -= 1;
            }
            else
            {
                player.Status = 1; // Change Player status
                this.gerakBackground.Start();//Start gerak background setelah cooldown selesai
                this.CooldownTimer.Stop();
            }
        }

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
            Thread.Sleep(10);
        }
        //=====================


//--\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
//      [  J U M P  ]
        private void CekJump()
        {
            if (isJumping)
            {
                player.Status = 2; //jump
                if (!isMaxHeightJump)
                {
                    picPlayer.Location = new Point(picPlayer.Location.X, picPlayer.Location.Y - 2);
                    if (picPlayer.Location.Y < (ground_height - jump_height))
                    {
                        isMaxHeightJump = !isMaxHeightJump;
                    }
                }
                else
                {
                    picPlayer.Location = new Point(picPlayer.Location.X, picPlayer.Location.Y + 2);
                    if (picPlayer.Location.Y >= ground_height)
                    {
                        isMaxHeightJump = !isMaxHeightJump;
                        player.Status = 1;
                        isJumping = false;
                    }
                }
            }
        }
//      [  J U M P  ]
//--\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\



//[  K E Y  E V E N T  ] GAME
//--\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            isStarted = !isStarted;

            mm_music.Stop();
            bg_music.PlayLooping();

            this.CooldownTimer.Start();
            this.GerakPlayerTimer.Start();
            MainMenuPanel.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                if (!isJumping)
                {
                    isJumping = true;
                }
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                if (!isJumping)
                {
                    player.Status = 3;
                }
            }
            if (e.KeyCode == Keys.P)
            {
                if (player.Jenis == 0)
                {
                    player.Jenis = 1;
                }
                else if (player.Jenis == 1)
                {
                    player.Jenis = 0;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                player.Status = 1;
            }
        }

//[  K E Y  E V E N T  ] GAME
//--\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\



    }
}

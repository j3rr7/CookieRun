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
        //SHOP COOKIE
        List<shop> gambarIdleShop = new List<shop>();
        List<int> locInfo = new List<int>();
        //==================
        //SHOP PET

        //===================
        //BACKGROUND
        List<int> posisiBackground = new List<int>();
        Image backgroundImg;
        Image backgroundImg2;
        bool isStarted = false;

        Player play = new Player();

        //SOUND AND MUSIC
        System.Media.SoundPlayer mm_music = new System.Media.SoundPlayer(Properties.Resources.SoundBgm_Lobby_epN01);
        System.Media.SoundPlayer bg_music = new System.Media.SoundPlayer(Properties.Resources.Bgm_spring_event_ep01);
        public Form1()
        {
            InitializeComponent();
            label2.BackColor = Color.FromArgb(49, 166, 189);
            

            picPlayer.SendToBack();

            gambarIdleShop.Add(new shop("brave", pictureBox1, "What a determined Cookie! Defying his destiny, he escaped from the Witch's grasp and paved the way for others to follow. Energy upgrades will make him stronger.",162,0));
            gambarIdleShop.Add(new shop("angel", pictureBox2, "Angel Cookie is trying to master the art of flying but can't rise higher than a teeny tiny bit above the ground just yet! Angel Cookie's favorite animals are penguins, ostriches, and baby chicks.Can you guess why ? Shiny golden curls are the source of the Cookie's special Magnetic Aura, which attracts all Coins and Jellies nearby. Yum!", 356,10000));
            gambarIdleShop.Add(new shop("hero", pictureBox3, "While the other Cookies escaped the hot oven one by one, this Cookie remained inside, lost in his research. He was brilliant enough to finally succeed in building an ultimate escaping machine, the 'Caramel Syrup Suit'. The suit is optimized for escape with a rechargeable Candy Engine as its core source of energy.",555,0));
            gambarIdleShop.Add(new shop("zombie", pictureBox5, "Zombie Cookie was thoroughly underbaked and slopped carelessly with strawberry jam and melted chocolate. But you see, the key ingredient for Zombie Cookie is a pinch of zombie cells to the dough. And no need to worry about getting your own zombie cells! ",748,20000));


            gambarIdleShop[1].picture.Invalidate();

            gambarIdleShop[3].picture.Invalidate();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = true;
            picPlayer.BackColor = Color.Transparent;    // <- set color to transparent

            //MainMenuPanel.BringToFront();

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

        private void timerShop_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                gambarIdleShop[i].ubahgambar();
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
            //-------------------- delay
            Thread.Sleep(10);
        }
        //=====================


//--\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
//      [  J U M P  ]
        private void CekJump()
        {
            if (isJumping==true)
            {
                player.Status = 2; //jump
                if (isMaxHeightJump==false)
                {
                    picPlayer.Location = new Point(picPlayer.Location.X, picPlayer.Location.Y - 2);
                    if (picPlayer.Location.Y < (ground_height - jump_height))
                    {
                        isMaxHeightJump =true;
                    }
                }
                else
                {
                    picPlayer.Location = new Point(picPlayer.Location.X, picPlayer.Location.Y + 2);
                    if (picPlayer.Location.Y >= ground_height)
                    {
                        isMaxHeightJump = false;
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
            bg_music.PlayLooping(); //error

            this.CooldownTimer.Start();
            this.GerakPlayerTimer.Start();
            MainMenuPanel.Dispose();
            panelShop.Dispose();
            petShop.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                if (isJumping==false)
                {
                    isJumping = true;
                }
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                if (isJumping == false)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelShop.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainMenuPanel.BringToFront();
        }
        private void beli_cookie(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;// kalo mau ganti harga, ganti tag dari button
            try
            {
                int harga = Convert.ToInt32(pb.Tag);
                if (harga <= play.Coin)
                {
                    play.Coin -= harga;
                    pb.Tag = "Sudah Dibeli";
                    pb.BackgroundImage = Properties.Resources.button;
                    MessageBox.Show(play.Coin + "");
                    pb.Invalidate();
                }
                else
                {
                    MessageBox.Show("Uang Tidak Cukup");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("pilih cookie");
                player.JenisCookie = pb.Name;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelShop.BringToFront();
        }

        private void btnBackPet_Click(object sender, EventArgs e)
        {
            petShop.BringToFront();
        }

        private void panelShop_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelShop_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            Rectangle mouse = new Rectangle(x,y,1,1);

            for (int i = 0; i < gambarIdleShop.Count; i++)
            {
                Rectangle rect = new Rectangle(gambarIdleShop[i].X, 92, 25, 25);
                if (mouse.IntersectsWith(rect))
                {
                    string judul = gambarIdleShop[i].gambar.Substring(0, 1).ToUpper() + gambarIdleShop[i].gambar.Substring(1)+" Cookie";
                    MessageBox.Show(gambarIdleShop[i].deskripsi, judul);
                }
            }

        }

        private void btnBackCookie_Click(object sender, EventArgs e)
        {
            panelShop.BringToFront();
         
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MainMenuPanel.BringToFront();
        }



        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void zombie_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Graphics g = e.Graphics;
            if(pb.Tag!= "Sudah Dibeli")
            {
                g.DrawString(pb.Tag + "", new Font("Arial", 12, FontStyle.Regular), new SolidBrush(Color.White), 45, 15);
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void petShop_MouseDown(object sender, MouseEventArgs e)
        {

        }



        //[  K E Y  E V E N T  ] GAME
        //--\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\



    }
}

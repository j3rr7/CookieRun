namespace CookieRun
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ValidationTimer = new System.Windows.Forms.Timer(this.components);
            this.CooldownTimer = new System.Windows.Forms.Timer(this.components);
            this.GerakPlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.gerakBackground = new System.Windows.Forms.Timer(this.components);
            this.timerShop = new System.Windows.Forms.Timer(this.components);
            this.panelShop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBackPet = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zombie = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.angel = new System.Windows.Forms.PictureBox();
            this.brave = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.petShop = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBackCookie = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.MainMenuPanel.SuspendLayout();
            this.petShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackCookie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // ValidationTimer
            // 
            this.ValidationTimer.Interval = 10;
            this.ValidationTimer.Tick += new System.EventHandler(this.ValidationTimer_Tick);
            // 
            // CooldownTimer
            // 
            this.CooldownTimer.Interval = 1000;
            this.CooldownTimer.Tick += new System.EventHandler(this.CooldownTimer_Tick);
            // 
            // GerakPlayerTimer
            // 
            this.GerakPlayerTimer.Tick += new System.EventHandler(this.GerakPlayerTimer_Tick);
            // 
            // gerakBackground
            // 
            this.gerakBackground.Interval = 30;
            this.gerakBackground.Tick += new System.EventHandler(this.gerakBackground_Tick);
            // 
            // timerShop
            // 
            this.timerShop.Enabled = true;
            this.timerShop.Interval = 250;
            this.timerShop.Tick += new System.EventHandler(this.timerShop_Tick);
            // 
            // panelShop
            // 
            this.panelShop.BackgroundImage = global::CookieRun.Properties.Resources.bgShop;
            this.panelShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShop.Controls.Add(this.pictureBox1);
            this.panelShop.Controls.Add(this.label16);
            this.panelShop.Controls.Add(this.label15);
            this.panelShop.Controls.Add(this.label14);
            this.panelShop.Controls.Add(this.label13);
            this.panelShop.Controls.Add(this.label12);
            this.panelShop.Controls.Add(this.label11);
            this.panelShop.Controls.Add(this.label10);
            this.panelShop.Controls.Add(this.label9);
            this.panelShop.Controls.Add(this.label8);
            this.panelShop.Controls.Add(this.label7);
            this.panelShop.Controls.Add(this.label6);
            this.panelShop.Controls.Add(this.label5);
            this.panelShop.Controls.Add(this.btnBackPet);
            this.panelShop.Controls.Add(this.label3);
            this.panelShop.Controls.Add(this.zombie);
            this.panelShop.Controls.Add(this.hero);
            this.panelShop.Controls.Add(this.angel);
            this.panelShop.Controls.Add(this.brave);
            this.panelShop.Controls.Add(this.pictureBox5);
            this.panelShop.Controls.Add(this.pictureBox4);
            this.panelShop.Controls.Add(this.pictureBox3);
            this.panelShop.Controls.Add(this.pictureBox2);
            this.panelShop.Controls.Add(this.label2);
            this.panelShop.Location = new System.Drawing.Point(12, 12);
            this.panelShop.Name = "panelShop";
            this.panelShop.Size = new System.Drawing.Size(776, 425);
            this.panelShop.TabIndex = 4;
            this.panelShop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelShop_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CookieRun.Properties.Resources.brave_shop;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 117);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(639, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(443, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(673, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "104";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(630, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Receives 1x with 25 Energy";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = " Hero Mode Lv.4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "187";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "158";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Magnetic Aura Lv.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "140";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Braver";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "1";
            // 
            // btnBackPet
            // 
            this.btnBackPet.BackColor = System.Drawing.Color.Transparent;
            this.btnBackPet.BackgroundImage = global::CookieRun.Properties.Resources.buttonPet;
            this.btnBackPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackPet.Location = new System.Drawing.Point(32, 9);
            this.btnBackPet.Name = "btnBackPet";
            this.btnBackPet.Size = new System.Drawing.Size(134, 44);
            this.btnBackPet.TabIndex = 16;
            this.btnBackPet.TabStop = false;
            this.btnBackPet.Click += new System.EventHandler(this.btnBackPet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(437, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "COOMING SOON";
            // 
            // zombie
            // 
            this.zombie.BackColor = System.Drawing.Color.Transparent;
            this.zombie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zombie.BackgroundImage")));
            this.zombie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zombie.Location = new System.Drawing.Point(620, 360);
            this.zombie.Name = "zombie";
            this.zombie.Size = new System.Drawing.Size(116, 48);
            this.zombie.TabIndex = 12;
            this.zombie.TabStop = false;
            this.zombie.Tag = "20000";
            this.zombie.Click += new System.EventHandler(this.beli_cookie);
            this.zombie.Paint += new System.Windows.Forms.PaintEventHandler(this.zombie_Paint);
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.Transparent;
            this.hero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hero.BackgroundImage")));
            this.hero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hero.Location = new System.Drawing.Point(441, 360);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(116, 48);
            this.hero.TabIndex = 11;
            this.hero.TabStop = false;
            this.hero.Tag = "0";
            this.hero.Click += new System.EventHandler(this.beli_cookie);
            // 
            // angel
            // 
            this.angel.BackColor = System.Drawing.Color.Transparent;
            this.angel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("angel.BackgroundImage")));
            this.angel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.angel.Location = new System.Drawing.Point(243, 360);
            this.angel.Name = "angel";
            this.angel.Size = new System.Drawing.Size(116, 48);
            this.angel.TabIndex = 10;
            this.angel.TabStop = false;
            this.angel.Tag = "10000";
            this.angel.Click += new System.EventHandler(this.beli_cookie);
            this.angel.Paint += new System.Windows.Forms.PaintEventHandler(this.zombie_Paint);
            // 
            // brave
            // 
            this.brave.BackColor = System.Drawing.Color.Transparent;
            this.brave.BackgroundImage = global::CookieRun.Properties.Resources.button;
            this.brave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brave.Location = new System.Drawing.Point(53, 360);
            this.brave.Name = "brave";
            this.brave.Size = new System.Drawing.Size(116, 48);
            this.brave.TabIndex = 9;
            this.brave.TabStop = false;
            this.brave.Tag = "0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::CookieRun.Properties.Resources.Zombie_Cookie;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(633, 141);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(116, 117);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::CookieRun.Properties.Resources.exit;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(700, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 44);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::CookieRun.Properties.Resources.Hero_Cookie;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(455, 141);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 117);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::CookieRun.Properties.Resources.angel_shop;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(243, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 117);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(317, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "COOKIE SHOP";
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(76, 290);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(120, 120);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImage = global::CookieRun.Properties.Resources.bgawal;
            this.MainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuPanel.Controls.Add(this.buttonExit);
            this.MainMenuPanel.Controls.Add(this.buttonShop);
            this.MainMenuPanel.Controls.Add(this.buttonPlay);
            this.MainMenuPanel.Location = new System.Drawing.Point(12, 12);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(776, 425);
            this.MainMenuPanel.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Maroon;
            this.buttonExit.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(311, 267);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(155, 74);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonShop
            // 
            this.buttonShop.BackColor = System.Drawing.Color.Maroon;
            this.buttonShop.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShop.Location = new System.Drawing.Point(311, 175);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(155, 74);
            this.buttonShop.TabIndex = 1;
            this.buttonShop.Text = "Shop";
            this.buttonShop.UseVisualStyleBackColor = false;
            this.buttonShop.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Maroon;
            this.buttonPlay.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlay.Location = new System.Drawing.Point(314, 81);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(155, 74);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // petShop
            // 
            this.petShop.BackgroundImage = global::CookieRun.Properties.Resources.bgShop;
            this.petShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.petShop.Controls.Add(this.label24);
            this.petShop.Controls.Add(this.label23);
            this.petShop.Controls.Add(this.label22);
            this.petShop.Controls.Add(this.label21);
            this.petShop.Controls.Add(this.label20);
            this.petShop.Controls.Add(this.label19);
            this.petShop.Controls.Add(this.label18);
            this.petShop.Controls.Add(this.label17);
            this.petShop.Controls.Add(this.btnBackCookie);
            this.petShop.Controls.Add(this.label1);
            this.petShop.Controls.Add(this.pictureBox6);
            this.petShop.Controls.Add(this.pictureBox7);
            this.petShop.Controls.Add(this.pictureBox8);
            this.petShop.Controls.Add(this.pictureBox9);
            this.petShop.Controls.Add(this.pictureBox10);
            this.petShop.Controls.Add(this.pictureBox11);
            this.petShop.Controls.Add(this.pictureBox12);
            this.petShop.Controls.Add(this.pictureBox13);
            this.petShop.Controls.Add(this.pictureBox14);
            this.petShop.Controls.Add(this.label4);
            this.petShop.Location = new System.Drawing.Point(12, 12);
            this.petShop.Name = "petShop";
            this.petShop.Size = new System.Drawing.Size(776, 425);
            this.petShop.TabIndex = 16;
            this.petShop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.petShop_MouseDown);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(630, 324);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 26);
            this.label24.TabIndex = 25;
            this.label24.Text = "Recovers 10.0% Energy\r\nafter collision";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(432, 321);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(125, 26);
            this.label23.TabIndex = 24;
            this.label23.Text = "Jellyco Missiles every 22 \r\nsec+170 pts for all Jellies";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(637, 267);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 18);
            this.label22.TabIndex = 23;
            this.label22.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(443, 266);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 18);
            this.label21.TabIndex = 22;
            this.label21.Text = "1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(247, 266);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 18);
            this.label20.TabIndex = 21;
            this.label20.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(247, 324);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 26);
            this.label19.TabIndex = 20;
            this.label19.Text = "Revives both Cookies \r\nwith 29 && 11 Energy";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 321);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 26);
            this.label18.TabIndex = 19;
            this.label18.Text = "Creates Yellow Bear Jellies\r\n every 3.7 sec";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(54, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 18);
            this.label17.TabIndex = 18;
            this.label17.Text = "1";
            // 
            // btnBackCookie
            // 
            this.btnBackCookie.BackColor = System.Drawing.Color.Transparent;
            this.btnBackCookie.BackgroundImage = global::CookieRun.Properties.Resources.buttonCookie;
            this.btnBackCookie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackCookie.Location = new System.Drawing.Point(29, 3);
            this.btnBackCookie.Name = "btnBackCookie";
            this.btnBackCookie.Size = new System.Drawing.Size(134, 44);
            this.btnBackCookie.TabIndex = 17;
            this.btnBackCookie.TabStop = false;
            this.btnBackCookie.Click += new System.EventHandler(this.btnBackCookie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(437, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "COOMING SOON";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(620, 360);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(116, 48);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "2000";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox7.Location = new System.Drawing.Point(441, 360);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(116, 48);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "0";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(243, 360);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(116, 48);
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "1000";
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::CookieRun.Properties.Resources.button;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(53, 360);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(116, 48);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "0";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::CookieRun.Properties.Resources.Zombie_Cookie;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(633, 141);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(116, 117);
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::CookieRun.Properties.Resources.exit;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(700, 7);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(70, 44);
            this.pictureBox11.TabIndex = 7;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImage = global::CookieRun.Properties.Resources.Hero_Cookie;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(455, 141);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(90, 117);
            this.pictureBox12.TabIndex = 6;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.BackgroundImage = global::CookieRun.Properties.Resources.angel_shop;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(243, 141);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(116, 117);
            this.pictureBox13.TabIndex = 5;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImage = global::CookieRun.Properties.Resources.brave_shop;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(47, 141);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(116, 117);
            this.pictureBox14.TabIndex = 4;
            this.pictureBox14.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(317, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "PET SHOP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 443);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.petShop);
            this.Controls.Add(this.panelShop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panelShop.ResumeLayout(false);
            this.panelShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.MainMenuPanel.ResumeLayout(false);
            this.petShop.ResumeLayout(false);
            this.petShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackCookie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ValidationTimer;
        private System.Windows.Forms.Timer CooldownTimer;
        private System.Windows.Forms.Timer GerakPlayerTimer;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Timer gerakBackground;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Panel panelShop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox zombie;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.PictureBox angel;
        private System.Windows.Forms.PictureBox brave;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerShop;
        private System.Windows.Forms.Panel petShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnBackPet;
        private System.Windows.Forms.PictureBox btnBackCookie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
    }
}


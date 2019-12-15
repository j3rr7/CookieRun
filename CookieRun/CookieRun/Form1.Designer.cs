﻿namespace CookieRun
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
            this.ValidationTimer = new System.Windows.Forms.Timer(this.components);
            this.CooldownTimer = new System.Windows.Forms.Timer(this.components);
            this.GerakPlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.gerakBackground = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.MainMenuPanel.SuspendLayout();
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
            // picPlayer
            // 
            this.picPlayer.Location = new System.Drawing.Point(101, 357);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(160, 148);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImage = global::CookieRun.Properties.Resources.bgawal;
            this.MainMenuPanel.Controls.Add(this.button2);
            this.MainMenuPanel.Controls.Add(this.button1);
            this.MainMenuPanel.Controls.Add(this.buttonPlay);
            this.MainMenuPanel.Location = new System.Drawing.Point(16, 15);
            this.MainMenuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(1035, 523);
            this.MainMenuPanel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(415, 329);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 91);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(415, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "Shop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Maroon;
            this.buttonPlay.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlay.Location = new System.Drawing.Point(419, 100);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(207, 91);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // gerakBackground
            // 
            this.gerakBackground.Interval = 30;
            this.gerakBackground.Tick += new System.EventHandler(this.gerakBackground_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 545);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.MainMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ValidationTimer;
        private System.Windows.Forms.Timer CooldownTimer;
        private System.Windows.Forms.Timer GerakPlayerTimer;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Timer gerakBackground;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}


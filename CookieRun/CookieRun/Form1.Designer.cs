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
            this.ValidationTimer = new System.Windows.Forms.Timer(this.components);
            this.CooldownTimer = new System.Windows.Forms.Timer(this.components);
            this.GerakPlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
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
            this.picPlayer.Location = new System.Drawing.Point(76, 290);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(120, 120);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.buttonPlay);
            this.MainMenuPanel.Location = new System.Drawing.Point(12, 12);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(776, 425);
            this.MainMenuPanel.TabIndex = 1;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(694, 387);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // gerakBackground
            // 
            this.gerakBackground.Interval = 30;
            this.gerakBackground.Tick += new System.EventHandler(this.gerakBackground_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 443);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}


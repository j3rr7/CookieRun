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
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
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
            this.GerakPlayerTimer.Interval = 45;
            this.GerakPlayerTimer.Tick += new System.EventHandler(this.GerakPlayerTimer_Tick);
            // 
            // picPlayer
            // 
            this.picPlayer.Location = new System.Drawing.Point(12, 348);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(90, 90);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ValidationTimer;
        private System.Windows.Forms.Timer CooldownTimer;
        private System.Windows.Forms.Timer GerakPlayerTimer;
        private System.Windows.Forms.PictureBox picPlayer;
    }
}


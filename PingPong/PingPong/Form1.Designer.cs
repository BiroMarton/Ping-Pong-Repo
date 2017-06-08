namespace PingPong
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
            this.PlayArea = new System.Windows.Forms.Panel();
            this.pad = new System.Windows.Forms.PictureBox();
            this.GameOver2 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.victory4 = new System.Windows.Forms.PictureBox();
            this.victory3 = new System.Windows.Forms.PictureBox();
            this.victory2 = new System.Windows.Forms.PictureBox();
            this.DiffVal = new System.Windows.Forms.Label();
            this.Diff = new System.Windows.Forms.Label();
            this.victory = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.victory5 = new System.Windows.Forms.PictureBox();
            this.GameOverPic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayArea
            // 
            this.PlayArea.AutoSize = true;
            this.PlayArea.BackColor = System.Drawing.Color.Transparent;
            this.PlayArea.Controls.Add(this.pad);
            this.PlayArea.Controls.Add(this.GameOver2);
            this.PlayArea.Controls.Add(this.Number);
            this.PlayArea.Controls.Add(this.Pause);
            this.PlayArea.Controls.Add(this.GameOver);
            this.PlayArea.Controls.Add(this.ball);
            this.PlayArea.Controls.Add(this.victory4);
            this.PlayArea.Controls.Add(this.victory3);
            this.PlayArea.Controls.Add(this.victory2);
            this.PlayArea.Controls.Add(this.DiffVal);
            this.PlayArea.Controls.Add(this.Diff);
            this.PlayArea.Controls.Add(this.victory);
            this.PlayArea.Controls.Add(this.Score);
            this.PlayArea.Controls.Add(this.victory5);
            this.PlayArea.Controls.Add(this.GameOverPic);
            this.PlayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayArea.Enabled = false;
            this.PlayArea.Location = new System.Drawing.Point(0, 0);
            this.PlayArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayArea.Name = "PlayArea";
            this.PlayArea.Size = new System.Drawing.Size(1583, 842);
            this.PlayArea.TabIndex = 0;
            this.PlayArea.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayArea_Paint);
            // 
            // pad
            // 
            this.pad.BackColor = System.Drawing.Color.Transparent;
            this.pad.Image = ((System.Drawing.Image)(resources.GetObject("pad.Image")));
            this.pad.Location = new System.Drawing.Point(477, 422);
            this.pad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pad.Name = "pad";
            this.pad.Size = new System.Drawing.Size(325, 30);
            this.pad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pad.TabIndex = 0;
            this.pad.TabStop = false;
            // 
            // GameOver2
            // 
            this.GameOver2.AutoSize = true;
            this.GameOver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOver2.Location = new System.Drawing.Point(531, 34);
            this.GameOver2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameOver2.Name = "GameOver2";
            this.GameOver2.Size = new System.Drawing.Size(899, 69);
            this.GameOver2.TabIndex = 14;
            this.GameOver2.Text = "Press Esc to exit or F1 to restart!";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number.Location = new System.Drawing.Point(155, 11);
            this.Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(39, 42);
            this.Number.TabIndex = 3;
            this.Number.Text = "0";
            // 
            // Pause
            // 
            this.Pause.AutoSize = true;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pause.Location = new System.Drawing.Point(64, 114);
            this.Pause.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(404, 69);
            this.Pause.TabIndex = 4;
            this.Pause.Text = "Game paused";
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOver.Location = new System.Drawing.Point(168, 470);
            this.GameOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(458, 42);
            this.GameOver.TabIndex = 5;
            this.GameOver.Text = "Game Over! Your score is:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.InitialImage = ((System.Drawing.Image)(resources.GetObject("ball.InitialImage")));
            this.ball.Location = new System.Drawing.Point(218, 207);
            this.ball.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(46, 46);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // victory4
            // 
            this.victory4.Image = ((System.Drawing.Image)(resources.GetObject("victory4.Image")));
            this.victory4.Location = new System.Drawing.Point(955, 130);
            this.victory4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.victory4.Name = "victory4";
            this.victory4.Size = new System.Drawing.Size(369, 475);
            this.victory4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.victory4.TabIndex = 13;
            this.victory4.TabStop = false;
            // 
            // victory3
            // 
            this.victory3.Image = ((System.Drawing.Image)(resources.GetObject("victory3.Image")));
            this.victory3.Location = new System.Drawing.Point(0, 274);
            this.victory3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.victory3.Name = "victory3";
            this.victory3.Size = new System.Drawing.Size(325, 346);
            this.victory3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.victory3.TabIndex = 12;
            this.victory3.TabStop = false;
            // 
            // victory2
            // 
            this.victory2.Image = ((System.Drawing.Image)(resources.GetObject("victory2.Image")));
            this.victory2.Location = new System.Drawing.Point(531, 2);
            this.victory2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.victory2.Name = "victory2";
            this.victory2.Size = new System.Drawing.Size(309, 251);
            this.victory2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.victory2.TabIndex = 11;
            this.victory2.TabStop = false;
            // 
            // DiffVal
            // 
            this.DiffVal.AutoSize = true;
            this.DiffVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiffVal.Location = new System.Drawing.Point(211, 55);
            this.DiffVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiffVal.Name = "DiffVal";
            this.DiffVal.Size = new System.Drawing.Size(39, 42);
            this.DiffVal.TabIndex = 10;
            this.DiffVal.Text = "0";
            // 
            // Diff
            // 
            this.Diff.AutoSize = true;
            this.Diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Diff.Location = new System.Drawing.Point(4, 55);
            this.Diff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(219, 42);
            this.Diff.TabIndex = 9;
            this.Diff.Text = "Ball Speed: ";
            // 
            // victory
            // 
            this.victory.Image = ((System.Drawing.Image)(resources.GetObject("victory.Image")));
            this.victory.Location = new System.Drawing.Point(955, 252);
            this.victory.Margin = new System.Windows.Forms.Padding(4);
            this.victory.Name = "victory";
            this.victory.Size = new System.Drawing.Size(628, 354);
            this.victory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.victory.TabIndex = 7;
            this.victory.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score.Location = new System.Drawing.Point(4, 11);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(136, 42);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score :";
            // 
            // victory5
            // 
            this.victory5.Image = ((System.Drawing.Image)(resources.GetObject("victory5.Image")));
            this.victory5.Location = new System.Drawing.Point(477, 309);
            this.victory5.Name = "victory5";
            this.victory5.Size = new System.Drawing.Size(462, 297);
            this.victory5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.victory5.TabIndex = 15;
            this.victory5.TabStop = false;
            // 
            // GameOverPic
            // 
            this.GameOverPic.Image = ((System.Drawing.Image)(resources.GetObject("GameOverPic.Image")));
            this.GameOverPic.Location = new System.Drawing.Point(185, 2);
            this.GameOverPic.Name = "GameOverPic";
            this.GameOverPic.Size = new System.Drawing.Size(1070, 670);
            this.GameOverPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameOverPic.TabIndex = 16;
            this.GameOverPic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1583, 842);
            this.Controls.Add(this.PlayArea);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PlayArea.ResumeLayout(false);
            this.PlayArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.victory5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PlayArea;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox pad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Pause;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.PictureBox victory;
        private System.Windows.Forms.Label DiffVal;
        private System.Windows.Forms.Label Diff;
        private System.Windows.Forms.PictureBox victory2;
        private System.Windows.Forms.PictureBox victory3;
        private System.Windows.Forms.PictureBox victory4;
        private System.Windows.Forms.Label GameOver2;
        private System.Windows.Forms.PictureBox victory5;
        private System.Windows.Forms.PictureBox GameOverPic;
    }
}


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
            this.victory = new System.Windows.Forms.PictureBox();
            this.GameOver = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.pad = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Diff = new System.Windows.Forms.Label();
            this.DiffVal = new System.Windows.Forms.Label();
            this.PlayArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.victory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayArea
            // 
            this.PlayArea.AutoSize = true;
            this.PlayArea.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayArea.Controls.Add(this.DiffVal);
            this.PlayArea.Controls.Add(this.Diff);
            this.PlayArea.Controls.Add(this.victory);
            this.PlayArea.Controls.Add(this.GameOver);
            this.PlayArea.Controls.Add(this.Pause);
            this.PlayArea.Controls.Add(this.Number);
            this.PlayArea.Controls.Add(this.Score);
            this.PlayArea.Controls.Add(this.ball);
            this.PlayArea.Controls.Add(this.pad);
            this.PlayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayArea.Enabled = false;
            this.PlayArea.Location = new System.Drawing.Point(0, 0);
            this.PlayArea.Margin = new System.Windows.Forms.Padding(2);
            this.PlayArea.Name = "PlayArea";
            this.PlayArea.Size = new System.Drawing.Size(1187, 684);
            this.PlayArea.TabIndex = 0;
            // 
            // victory
            // 
            this.victory.Image = ((System.Drawing.Image)(resources.GetObject("victory.Image")));
            this.victory.Location = new System.Drawing.Point(716, 45);
            this.victory.Name = "victory";
            this.victory.Size = new System.Drawing.Size(471, 448);
            this.victory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.victory.TabIndex = 7;
            this.victory.TabStop = false;
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOver.Location = new System.Drawing.Point(126, 382);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(363, 33);
            this.GameOver.TabIndex = 5;
            this.GameOver.Text = "Game Over! Your score is:";
            // 
            // Pause
            // 
            this.Pause.AutoSize = true;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pause.Location = new System.Drawing.Point(48, 93);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(327, 55);
            this.Pause.TabIndex = 4;
            this.Pause.Text = "Game paused";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number.Location = new System.Drawing.Point(116, 9);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(31, 33);
            this.Number.TabIndex = 3;
            this.Number.Text = "0";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score.Location = new System.Drawing.Point(3, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(107, 33);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score :";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.DarkGreen;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ball.Location = new System.Drawing.Point(197, 172);
            this.ball.Margin = new System.Windows.Forms.Padding(2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // pad
            // 
            this.pad.BackColor = System.Drawing.SystemColors.Desktop;
            this.pad.Location = new System.Drawing.Point(153, 327);
            this.pad.Margin = new System.Windows.Forms.Padding(2);
            this.pad.Name = "pad";
            this.pad.Size = new System.Drawing.Size(242, 24);
            this.pad.TabIndex = 0;
            this.pad.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Diff
            // 
            this.Diff.AutoSize = true;
            this.Diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Diff.Location = new System.Drawing.Point(3, 45);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(171, 33);
            this.Diff.TabIndex = 9;
            this.Diff.Text = "Ball Speed: ";
            // 
            // DiffVal
            // 
            this.DiffVal.AutoSize = true;
            this.DiffVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DiffVal.Location = new System.Drawing.Point(158, 45);
            this.DiffVal.Name = "DiffVal";
            this.DiffVal.Size = new System.Drawing.Size(31, 33);
            this.DiffVal.TabIndex = 10;
            this.DiffVal.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1187, 684);
            this.Controls.Add(this.PlayArea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PlayArea.ResumeLayout(false);
            this.PlayArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.victory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad)).EndInit();
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
    }
}


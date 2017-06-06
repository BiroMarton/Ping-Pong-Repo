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
            this.PlayArea = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.PictureBox();
            this.pad = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayArea
            // 
            this.PlayArea.AutoSize = true;
            this.PlayArea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PlayArea.Controls.Add(this.ball);
            this.PlayArea.Controls.Add(this.pad);
            this.PlayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayArea.Location = new System.Drawing.Point(0, 0);
            this.PlayArea.Name = "PlayArea";
            this.PlayArea.Size = new System.Drawing.Size(545, 445);
            this.PlayArea.TabIndex = 0;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Snow;
            this.ball.Location = new System.Drawing.Point(222, 153);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // pad
            // 
            this.pad.BackColor = System.Drawing.SystemColors.Desktop;
            this.pad.Location = new System.Drawing.Point(204, 403);
            this.pad.Name = "pad";
            this.pad.Size = new System.Drawing.Size(150, 30);
            this.pad.TabIndex = 0;
            this.pad.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(545, 445);
            this.Controls.Add(this.PlayArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PlayArea.ResumeLayout(false);
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
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form

    {
        public int speed_top = 3;
        public int speed_left = 3;
        public int points = 0;
 

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;

            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            pad.Top = PlayArea.Bottom -(PlayArea.Bottom/10);
            Pause.Left = (PlayArea.Width / 2) - (Pause.Width / 2);
            Pause.Top = (PlayArea.Height/2) - (Pause.Height/2);
            GameOver.Left = (PlayArea.Width / 2) - (GameOver.Width / 2);
            GameOver.Top = (PlayArea.Height / 2) - (GameOver.Height / 2);
            GameOver.Visible = false;

            Pause.Visible = false;
            victory.Visible = false;
            victory.Left = PlayArea.Width - victory.Width;

         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pad.Left = Cursor.Position.X - (pad.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bottom >= pad.Top && ball.Bottom <= pad.Bottom && ball.Left >= pad.Left && ball.Right <= pad.Right)
            {

                if (points < 8) {
                    speed_left += 2;
                    speed_top += 2;
                    DiffVal.Text = Math.Abs(speed_top).ToString();
                }

                if (points == 10 || points == 25) {
                    pad.Width -= 50;
                }


          

                speed_top= -speed_top;
                points += 1;
                Number.Text = points.ToString();
            }

            if (ball.Left <= PlayArea.Left || ball.Right >= PlayArea.Right)
            {
                speed_left = -speed_left;
            }

            if (ball.Top <= PlayArea.Top)
            {
                speed_top = -speed_top;
            }

            if (ball.Bottom >= PlayArea.Bottom)
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
                Score.Visible = false;
                Number.Left = (PlayArea.Width / 2) + (GameOver.Width/2);
                Number.Top = GameOver.Top;
                ball.Visible = false;
            }

          

            if (points >= 5) {
                victory.Visible = true;

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = !(timer1.Enabled);
                Pause.Visible = !(Pause.Visible);
            }

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }


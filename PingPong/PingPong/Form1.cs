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
        public int speed = 5;
        public int points = 0;
        public int difficulty = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            pad.Top = PlayArea.Bottom -(PlayArea.Bottom/10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pad.Left = Cursor.Position.X - (pad.Width / 2);

            ball.Left += speed;
            ball.Top += speed;

            if (ball.Bottom >= pad.Top && ball.Bottom <= pad.Bottom && ball.Left >= pad.Left && ball.Right <= pad.Right)
            {
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
            }
            
            }
        }
    }


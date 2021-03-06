﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;

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

            ball.Left = 100;
            ball.Top = 100;
            pad.Width = 325;
            Number.Top = Score.Top;
            Number.Left = Score.Left + Score.Width;
            pad.Top = PlayArea.Bottom -(PlayArea.Bottom/10);
            Pause.Left = (PlayArea.Width / 2) - (Pause.Width / 2);
            Pause.Top = (PlayArea.Height/2) - (Pause.Height/2);
            GameOver.Left = (PlayArea.Width / 2) - (GameOver.Width / 2);
            GameOver.Top = (PlayArea.Height / 2) - (GameOver.Height / 2);
            GameOver2.Left = (PlayArea.Width / 2) - (GameOver2.Width / 2);
            GameOverPic.Left = (PlayArea.Width / 2) - (GameOverPic.Width / 2);
            GameOverPic.Top = (PlayArea.Height / 2) - (GameOverPic.Height / 2);
            GameOver.Visible = false;
            GameOver2.Visible = false;
            DiffVal.Text = Math.Abs(speed_top).ToString();
            Pause.Visible = false;
            victory.Visible = false;
            victory.Left = PlayArea.Width - victory.Width;
            victory2.Visible = false;
            victory3.Visible = false;
            victory4.Visible = false;
            victory5.Visible = false;
            GameOverPic.Visible = false;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pad.Left = Cursor.Position.X - (pad.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bottom >= pad.Top && ball.Bottom <= pad.Bottom && ball.Left >= pad.Left && ball.Right <= pad.Right)
            {

                if (points < 12) {
                    speed_left += 1;
                    speed_top += 1;


                    DiffVal.Text = Math.Abs(speed_top).ToString();
                }


                if (ball.Right >= (pad.Right - 50))
                {
                    speed_left += 2;
                    
                }

                if (ball.Left <= (pad.Left + 50))
                {
                    speed_left -= 2;
                    
                }
                

                speed_top = -speed_top;
                points += 1;
                Number.Text = points.ToString();

                if (points == 10 || points == 25 || points == 40 || points == 70)
                {
                    pad.Width -= 50;
                }

                if (points == 50 || points == 99)
                {
                    if (speed_top > 0)
                    {
                        speed_top += 5;
                    }
                    else
                    {
                        speed_top -= 5;

                    }
                    
                    DiffVal.Text = Math.Abs(speed_top).ToString();
                }
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
                points = 0;
                victory.Visible = false;
                victory2.Visible = false;
                victory3.Visible = false;
                victory4.Visible = false;
                victory5.Visible = false;
                timer1.Enabled = false;
                GameOver.Visible = true;
                GameOver2.Visible = true;
                GameOverPic.Visible = true;
                Score.Visible = false;
                Number.Left = (PlayArea.Width / 2) + (GameOver.Width/2);
                Number.Top = GameOver.Top;
                ball.Visible = false;
            }

          

            if (points == 5) {
                victory.Visible = true;

            }

            if (points == 10)
            {
                victory2.Visible = true;
            }

            if (points == 15)
            {
                victory3.Visible = true;
            }

            if (points == 20)
            {
                victory4.Visible = true;
            }
            if (points == 25)
            {
                victory5.Visible = true;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Space && GameOver.Visible == false)
            {
                timer1.Enabled = !(timer1.Enabled);
                Pause.Visible = !(Pause.Visible);
            }

            if(e.KeyCode == Keys.F1 && GameOver.Visible == true){

                Pause.Visible = false;
                victory.Visible = false;
                victory2.Visible = false;
                victory3.Visible = false;
                victory4.Visible = false;
                victory5.Visible = false;
                GameOverPic.Visible = false;
                Score.Visible = true;
                pad.Width = 325;
                Number.Top = Score.Top;
                Number.Left = Score.Left + Score.Width;
                ball.Visible = true;
                GameOver.Visible = false;
                GameOver2.Visible = false;
                ball.Left = 100;
                ball.Top = 100;
                speed_left = 3;
                speed_top = 3;
                Number.Text = points.ToString();
                DiffVal.Text = Math.Abs(speed_top).ToString();
                timer1.Enabled = true;


            }

        }

        private void PlayArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    }




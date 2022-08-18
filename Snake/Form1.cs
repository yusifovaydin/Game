using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Kure> Ilan = new List<Kure>();
        private Kure yem = new Kure();

        int maxWidth;
        int maxHeight;

        int sxore;
        int highSxore;

        int sn, dq, st, art;
        bool slvxt;
       


        Random rand = new Random();

        bool goSol, goSag, goYux, goAsh;


        public Form1()
        {
            InitializeComponent();
            new Qurashdir();
        }

        private void score_Click(object sender, EventArgs e)
        {

        }

        private void Asagi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Qurashdir.directions != "right")
            {
                goSol = true;
            }

            if (e.KeyCode == Keys.Right && Qurashdir.directions != "left")
            {
                goSag = true;
            }

            if (e.KeyCode == Keys.Up && Qurashdir.directions != "down")
            {
                goYux = true;
            }
            if (e.KeyCode == Keys.Down && Qurashdir.directions != "up")
            {
                goAsh = true;
            }

        }

        private void Yuxari(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goSol = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goSag = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goYux = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goAsh = false;
            }

        }

        private void oyunBasla(object sender, EventArgs e)
        {
            RestartGame();
            ResetTime();
            slvxt = true;

        }

        public void SnapShot(object sender, EventArgs e)
        {
            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Ilan Oyunu Screen Snap";
            dialog.DefaultExt = "png";
            dialog.Filter = " PNG Image File | *.png";
            dialog.ValidateNames = true;

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                int witdh = Convert.ToInt32(picCanvas.Width);   
                int heigth = Convert.ToInt32(picCanvas.Height); 
                Bitmap bmp = new Bitmap(witdh, heigth);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, witdh, heigth));
                bmp.Save(dialog.FileName, ImageFormat.Png);
            }
        }

        private void oyunvaxti(object sender, EventArgs e)
        {
            if (goSol)
            {
                Qurashdir.directions = "left";
            }
            if (goSag)
            {
                Qurashdir.directions = "right";
            }
            if (goAsh)
            {
                Qurashdir.directions = "down";
            }
            if (goYux)
            {
                Qurashdir.directions = "up";
            }

            for ( int i = Ilan.Count-1; i>= 0; i--)
            {
                if (i == 0)
                {
                    switch (Qurashdir.directions)
                    {
                        case "left":
                            Ilan[i].X--;
                            break;
                        case "right":
                            Ilan[i].X++;
                            break;
                        case "down":
                            Ilan[i].Y++;
                            break;
                        case "up":
                            Ilan[i].Y--;
                            break;
                    }

                    if (Ilan[i].X < 0)
                    {
                        Ilan[i].X = maxWidth;
                    }
                    if (Ilan[i].X > maxWidth)
                    {
                        Ilan[i].X = 0;
                    }
                    if (Ilan[i].Y < 0)
                    {
                        Ilan[i].Y = maxHeight;
                    }
                    if (Ilan[i].Y > maxHeight)
                    {
                        Ilan[i].Y = 0;
                    }

                    if (Ilan[i].X == yem.X && Ilan[i].Y == yem.Y)
                    {
                        YeOni();
                    }

                    for ( int j = 1; j < Ilan.Count; j++ )
                    {
                        if(Ilan[i].X == Ilan[j].X && Ilan[i].Y == Ilan[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    Ilan[i].X = Ilan[i - 1].X;
                    Ilan[i].Y = Ilan[i - 1].Y;
                }

            }

            picCanvas.Invalidate();

            if (slvxt)
            {
                sn++;
                if(sn == 60)
                {
                    dq++;
                    sn = 0;
                    if(dq >= 60)
                    {
                        st++;
                        dq = 0;
                    }
                }
            }

            vaxtiartir();


        }

        private void vaxtiartir()
        {
            saat.Text = String.Format("{0:00}", st);
            deq.Text = String.Format("{0:00}", dq);
            san.Text = String.Format("{0:00}", sn);
        }

    

        private void UpdatePictureBoxGraphic(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;

            for(int i = 0; i < Ilan.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkBlue;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Ilan[i].X * Qurashdir.Witdh,
                    Ilan[i].Y * Qurashdir.Height,
                    Qurashdir.Witdh, Qurashdir.Height
                    )); 

            }

            canvas.FillEllipse(Brushes.Red, new Rectangle
                    (
                    yem.X * Qurashdir.Witdh,
                    yem.Y * Qurashdir.Height,
                    Qurashdir.Witdh, Qurashdir.Height
                    ));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();
            slvxt = false;
        }

        private void RestartGame()
        {
            
            maxWidth = picCanvas.Width / Qurashdir.Witdh - 1;
            maxHeight = picCanvas.Height / Qurashdir.Height - 1;

            Ilan.Clear();

            baslaButton.Enabled = false;
            snapButton.Enabled = false;
            sxore = 0;
            txtScore.Text = "Score: " + sxore;

            Kure head = new Kure { X = 10, Y = 5 };
            Ilan.Add(head);

            for( int i = 0; i < 8; i++)
            {
                Kure body = new Kure();
                Ilan.Add(body);
            }

            yem = new Kure {X = rand.Next(2,maxWidth), Y=rand.Next(2,maxHeight)};

            gameTimer.Start();

            saat.ForeColor = Color.Black;
            deq.ForeColor = Color.Black;
            san.ForeColor = Color.Black;

        }

        private void YeOni()
        {
            sxore += 1;
            txtScore.Text = "Score: " + sxore;
            Kure body = new Kure
            {
                X = Ilan[Ilan.Count - 1].X,
                Y = Ilan[Ilan.Count - 1].Y
            };

            Ilan.Add(body);

            yem = new Kure { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void GameOver()
        {
           
            gameTimer.Stop();
            baslaButton.Enabled = true;
            snapButton.Enabled = true;

            saat.ForeColor = Color.DarkRed;
            deq.ForeColor = Color.DarkRed;
            san.ForeColor = Color.DarkRed;

            if (sxore > highSxore)
            {
                highTScore.Visible = true;
                highSxore = sxore;
                highTScore.Text = "High Score:" + sxore;
                highTScore.ForeColor = Color.Maroon;
                highTScore.TextAlign = ContentAlignment.MiddleCenter;

                hgsaat.Visible = true;
                hgdeq.Visible = true;
                hgsan.Visible = true;
                noq1.Visible = true;
                noq2.Visible = true;

                hgsaat.Text = String.Format("{0:00}", st);
                hgdeq.Text = String.Format("{0:00}", dq);
                hgsan.Text = String.Format("{0:00}", sn); ;
            }
        }

        private void ResetTime()
        {
            sn = 0;
            dq = 0;
            st = 0;
        }
    }
}

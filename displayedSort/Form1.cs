using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace displayedSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int i = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 10, y = 0;
            for (int i = 1; i<= 10; i++)
            {
                Controls["PictureBox" + i].Location = new Point(x, y);
                Controls["PictureBox" + i].Width = 9;
                Controls["PictureBox" + i].BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                Controls["PictureBox" + i].Height = r.Next(10, 300);
                x += 10;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            Control min = Controls["PictureBox" + i];

            for (int j = i; j <= 10; j++)
            {
                if (min.Height > Controls["PictureBox" + j].Height)
                {
                    int temp1 = Controls["PictureBox" + j].Height;
                    Controls["PictureBox" + j].Height = min.Height;
                    min.Height = temp1;

                    Color temp2 = Controls["PictureBox" + j].BackColor;
                    Controls["PictureBox" + j].BackColor = min.BackColor;
                    min.BackColor = temp2;

                }
            }
            
            if (i <= 10)
            {
                i++;
                timer1.Start();
            }
            
        }
    }
}

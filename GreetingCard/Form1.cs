///Constellation Greeting Card
///Made by Kiran Wotherspoon
///What ever date i submit this

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //page turning sound effect
            SoundPlayer player = new SoundPlayer(Properties.Resources.pageFlip);
            player.Play();
            Thread.Sleep(250);
            
            //make labels disappear
            titleLabel.Visible = false;
            nameLabel.Visible = false;

            //set up for graphics
            Graphics insideCard = this.CreateGraphics();
            insideCard.Clear(Color.Black);
            Pen starPen = new Pen(Color.Gold, 3);
            SolidBrush starBrush = new SolidBrush(Color.White);
            SolidBrush wordBrush = new SolidBrush(Color.MidnightBlue);

            //draw strings
            Font titleFont = new Font("Verdana", 20, FontStyle.Bold);
            Font bodyFont = new Font("Cambria", 12, FontStyle.Regular);
            insideCard.DrawString("The Leo Constellation", titleFont, wordBrush, 10, 10);

            //draw constellation
            insideCard.DrawLine(starPen, 455, 25, 505, 75); //draw lines
            insideCard.DrawLine(starPen, 455, 25, 345, 145);
            insideCard.DrawLine(starPen, 345, 145, 365, 205);
            insideCard.DrawLine(starPen, 365, 205, 145, 265);
            insideCard.DrawLine(starPen, 145, 265, 75, 400);
            insideCard.DrawLine(starPen, 75, 400, 185, 345);
            insideCard.DrawLine(starPen, 185, 345, 515, 295);
            insideCard.DrawLine(starPen, 515, 295, 465, 235);
            insideCard.DrawLine(starPen, 465, 235, 365, 205);
            insideCard.FillEllipse(starBrush, 450, 20, 10, 10); //draw stars
            insideCard.FillEllipse(starBrush, 500, 70, 10, 10);
            insideCard.FillEllipse(starBrush, 340, 140, 10, 10);
            insideCard.FillEllipse(starBrush, 360, 200, 10, 10);
            insideCard.FillEllipse(starBrush, 140, 260, 10, 10);
            insideCard.FillEllipse(starBrush, 70, 395, 10, 10);
            insideCard.FillEllipse(starBrush, 180, 340, 10, 10);
            insideCard.FillEllipse(starBrush, 460, 230, 10, 10);
            insideCard.FillEllipse(starBrush, 510, 290, 10, 10);

            //draw paragraph about constellation
            wordBrush.Color = (Color.Blue);

        }
    }
}

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
            SoundPlayer opening = new SoundPlayer(Properties.Resources.pageFlip);
            opening.Play();
            Thread.Sleep(250); //sync sound and visuals
            
            //make labels disappear
            titleLabel.Visible = false;
            nameLabel.Visible = false;

            //set up for graphics
            Graphics insideCard = this.CreateGraphics();
            insideCard.Clear(Color.Black);
            Pen starPen = new Pen(Color.Gold, 3);
            SolidBrush starBrush = new SolidBrush(Color.White);
            SolidBrush wordBrush1 = new SolidBrush(Color.MidnightBlue);
            SolidBrush wordBrush2 = new SolidBrush(Color.SteelBlue);

            //draw title string
            Font titleFont = new Font("Verdana", 20, FontStyle.Bold);
            insideCard.DrawString("The Leo Constellation", titleFont, wordBrush1, 10, 10);

            //draw stars one by one while playing sparkle sound
            SoundPlayer sparkle = new SoundPlayer(Properties.Resources.sparkleNoise);
            Thread.Sleep(750);
            sparkle.Play();
            insideCard.FillEllipse(starBrush, 500, 70, 10, 10);
            Thread.Sleep(750);
            sparkle.Play();
            insideCard.FillEllipse(starBrush, 450, 20, 10, 10);
            Thread.Sleep(750);
            sparkle.Play();
            insideCard.FillEllipse(starBrush, 340, 140, 10, 10);
            Thread.Sleep(750);
            sparkle.Play();
            insideCard.FillEllipse(starBrush, 360, 200, 10, 10);
            Thread.Sleep(750);
            sparkle.Play();
            insideCard.FillEllipse(starBrush, 140, 260, 10, 10);
            insideCard.FillEllipse(starBrush, 460, 230, 10, 10);
            Thread.Sleep(750);
            sparkle.Play();
            insideCard.FillEllipse(starBrush, 510, 290, 10, 10);
            insideCard.FillEllipse(starBrush, 70, 395, 10, 10);
            Thread.Sleep(750);
            sparkle.Play();
            insideCard.FillEllipse(starBrush, 180, 340, 10, 10);
            Thread.Sleep(750);

            //draw lines connecting stars
            insideCard.DrawLine(starPen, 455, 25, 505, 75);
            insideCard.DrawLine(starPen, 455, 25, 345, 145);
            insideCard.DrawLine(starPen, 345, 145, 365, 205);
            insideCard.DrawLine(starPen, 365, 205, 145, 265);
            insideCard.DrawLine(starPen, 145, 265, 75, 400);
            insideCard.DrawLine(starPen, 75, 400, 185, 345);
            insideCard.DrawLine(starPen, 185, 345, 515, 295);
            insideCard.DrawLine(starPen, 515, 295, 465, 235);
            insideCard.DrawLine(starPen, 465, 235, 365, 205);

            //draw stars over lines
            insideCard.FillEllipse(starBrush, 450, 20, 10, 10);
            insideCard.FillEllipse(starBrush, 500, 70, 10, 10);
            insideCard.FillEllipse(starBrush, 340, 140, 10, 10);
            insideCard.FillEllipse(starBrush, 360, 200, 10, 10);
            insideCard.FillEllipse(starBrush, 140, 260, 10, 10);
            insideCard.FillEllipse(starBrush, 70, 395, 10, 10);
            insideCard.FillEllipse(starBrush, 180, 340, 10, 10);
            insideCard.FillEllipse(starBrush, 460, 230, 10, 10);
            insideCard.FillEllipse(starBrush, 510, 290, 10, 10);
            Thread.Sleep(1000);

            //set up for paragraph
            Font bodyFont = new Font("Cambria", 12, FontStyle.Regular);
            wordBrush1.Color = (Color.DarkSlateBlue);
            SoundPlayer writing = new SoundPlayer(Properties.Resources.writingSound); 
            writing.Play();
            Thread.Sleep(100);

            //draw paragraph on constellation
            insideCard.DrawString("Leo is a zodiac constellation.", bodyFont, wordBrush1, 5, 405);
            Thread.Sleep(500);
            insideCard.DrawString("It's name is latin for lion, and is represented by the Greek monster the Nemean Lion.", bodyFont, wordBrush2, 5, 425);
            Thread.Sleep(500);
            insideCard.DrawString("The lion was known for terrorizing citizens and it's impenetrable hide.", bodyFont, wordBrush1, 5, 445);
            Thread.Sleep(500);
            insideCard.DrawString("The Nemean Lion was killed during the first of Heracles's 12 labours.", bodyFont, wordBrush2, 5, 465);
            Thread.Sleep(500);
            insideCard.DrawString("Leo is easily recognizable as it has many bright stars and a distinct shape.", bodyFont, wordBrush1, 5, 485);
            Thread.Sleep(500);
            insideCard.DrawString("The lion's mane and shoulders form a sub-group of stars called The Sickle.", bodyFont, wordBrush2, 5, 505);
            Thread.Sleep(500);
            insideCard.DrawString("Leo was one of the first recognized constellations with evidence from Mesopotamia.", bodyFont, wordBrush1, 5, 525);
            Thread.Sleep(500);
            insideCard.DrawString("Meteors that appear to come from th direction of Leo are called Leonids.", bodyFont, wordBrush2, 5, 545);
            Thread.Sleep(500);
            insideCard.DrawString("The Leonids peak during the month of November.", bodyFont, wordBrush1, 5, 565);
        }
    }
}

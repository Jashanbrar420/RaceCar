using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Car_Race
{
    class Racers
    {
        public int Startline;
        public int tracklenght;
        public PictureBox MyPictureBox = null;
        public int Positions = 0;
        

        public bool Engine()//this method makes the car moves
        {
            Random Spin = new Random();
            int DisCovered = Spin.Next(0,5);
            Point loc = MyPictureBox.Location;
            loc.X += DisCovered;
            MyPictureBox.Location = loc;
            if (loc.X >= tracklenght)
            {
                return true;
            }
            else
            {   
                return false;
            }
        }

        public void Racerstart()//this method start the race
        {
            Point start = MyPictureBox.Location;
            Startline = start.X;
        }

        public void nextracepos()
        {
            Point p = MyPictureBox.Location;
            p.X = this.Startline;
            MyPictureBox.Location = p;
        }
    }
}

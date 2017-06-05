using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public class Greyhound
    {

        public int startingPostition; //where picture box starts
        public int raceTrackLength; //how long the racetrack is
        public PictureBox MyPictureBox = null; //picturebox object
        public int Location = 0; //location on racetrack
        public Random randomizer; //instance of random

        public bool Run()
        {

            Location += randomizer.Next(1,8);
            MyPictureBox.Left = startingPostition + Location;

            if (MyPictureBox.Right > raceTrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void takeStartingPostition()
        {
            Location = 0;
            MyPictureBox.Left = startingPostition;
        }

    }
}

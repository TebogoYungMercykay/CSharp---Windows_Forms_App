using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf164_HW_assignment
{
     public class Tamagotchi
    {
        //Data member
        private string mName;
        private string mAuthor;
        private string mGenre;
        private double mCost;
        private static int tSleep = 30;
        private static int HighSCore = 0;
        private DateTime mDate;

       //
       public Tamagotchi()
        { }


        public Tamagotchi( string Name, string Author, string Genre, DateTime Date,  double cost)
        {
            mName = Name;
            mAuthor = Author;
            mDate = Date;
            mCost = cost;
        }
        public string Name { get => mName; set => mName = value; }
        public int High { get =>HighSCore; set => HighSCore = value; }
        public int mSleep {get =>tSleep; set => tSleep = value; }
        public string Author { get => mAuthor; set => mAuthor = value; }
        public string Genre { get => mGenre; set => mGenre = value; }
        public DateTime Date  { get => mDate; set => mDate = value; }
        public double Cost { get => mCost; set => mCost = value; }

    }
}

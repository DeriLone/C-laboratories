using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1
{
    class Visitor
    {
        public bool RodeOnCoaster;
        public bool ShotOnRange;
        public bool RoomOfFear;
        public bool MirrorRoom;
        public bool Popcorn;
        public bool FerrisWheel;

        public Visitor()
        {
            RodeOnCoaster = false;
            ShotOnRange = false;
            RoomOfFear = false;
            MirrorRoom = false;
            Popcorn = false;
            FerrisWheel = false;
        }


        public void Info()
        {
            Console.WriteLine(
                $"Rode a roller coaster \t\t\t-- {RodeOnCoaster}\n" +
                $"Shot in the dash \t\t\t-- {ShotOnRange}\n" +
                $"Went to the room of fear \t\t-- {RoomOfFear}\n" +
                $"Went to the room of curved mirrors \t-- {MirrorRoom}\n" +
                $"Ate popcorn \t\t\t\t-- {Popcorn}" +
                $"\nRode on the ferris wheel \t\t-- {FerrisWheel}\n");
        }
    }
}

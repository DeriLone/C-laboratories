using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1
{
    class ParkEntertainment
    {
        public static void RodeOnCoaster(Visitor Obj)
        {
            Obj.RodeOnCoaster = true;
        }
        public static void ShotOnRange(Visitor Obj)
        {
            Obj.ShotOnRange = true;
        }
        public static void RoomOfFear(Visitor Obj)
        {
            Obj.RoomOfFear = true;
        }
        public static void MirrorRoom(Visitor Obj)
        {
            Obj.MirrorRoom = true;
        }
        public static void Popcorn(Visitor Obj)
        {
            Obj.Popcorn = true;
        }
        public static void FerrisWheel(Visitor Obj)
        {
            Obj.FerrisWheel = true;
        }
    }
}

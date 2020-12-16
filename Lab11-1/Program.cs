using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1
{
    delegate void Service(Visitor Obj);

    class Program
    {
        static void Main(string[] args)
        {
            Visitor customer = new Visitor();

            Service serv = ParkEntertainment.RodeOnCoaster;
            serv(customer);
            Service serv1 = ParkEntertainment.ShotOnRange;
            serv1(customer);
            Service serv2 = ParkEntertainment.RoomOfFear;
            serv2(customer);
            Service serv3 = ParkEntertainment.MirrorRoom;
            serv3(customer);
            Service serv4 = ParkEntertainment.Popcorn;
            serv4(customer);
            Service serv5 = ParkEntertainment.FerrisWheel;
            serv5(customer);

            customer.Info();

            Console.ReadLine();
        }
    }
}

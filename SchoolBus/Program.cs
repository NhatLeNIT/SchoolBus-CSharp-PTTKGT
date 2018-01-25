using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolBus
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStation station = new GetStation();
            station.GetStationData();
            Console.WriteLine("===================================");
            GetBus bus = new GetBus();
            bus.GetBusData();
            Console.ReadKey();
        }
    }
}

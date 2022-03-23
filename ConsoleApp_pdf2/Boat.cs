using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_pdf2
{
    internal class Boat :  Vehicle
    {
        public int Weight { get; set; }

        public Boat()
        {
            DistType = Distance.nm;
            Console.WriteLine("New Boat");
        }

        public override void Move(int nm)
        {
            //base.Move(km * 1000);
            Console.WriteLine(nm + " " + DistType + " parcourus");
        }

    }
}

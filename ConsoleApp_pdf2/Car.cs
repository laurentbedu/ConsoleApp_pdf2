using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_pdf2
{
    internal class Car : Vehicle
    {
        public string Model { get; set; } = "";

        public Car()
        {
            DistType = Distance.km;
            Console.WriteLine("New Car");
        }

        public override void Move(int km)
        {
            //base.Move(km * 1000);
            Console.WriteLine(km + " " + DistType + " parcourus");
        } 
    }
}

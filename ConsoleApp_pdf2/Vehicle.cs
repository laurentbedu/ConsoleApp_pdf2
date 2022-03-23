using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_pdf2
{
    internal class Vehicle
    {
        //attributs ou champs
        private string color;
        private string brand;


        //propriétés ou accesseurs (get/set)
        public string Color { get => color; set => color = value; }
        public string Brand { get => brand; }

        public Distance DistType { get; set; }

        //ctor
        public Vehicle()
        {
            DistType = Distance.m;
            Console.WriteLine("New Vehicle");
        }

        public Vehicle(string brand) : this()
        {
            this.brand = brand;
        }

        public Vehicle(string color, string brand) : this()
        {
            this.color = color;
            this.brand = brand;
        }

        //méthodes
        public string GetDescription()
        {
            string result = "Brand : " + this.brand + " Color : " + this.color;
            Console.WriteLine(result);
            return result;
        }

        //private protected internal public
        //https://www.geeksforgeeks.org/access-modifiers-in-c-sharp/

        public virtual void Move(int m)
        {
            Console.WriteLine(m + " " + DistType + " parcourus");
        }

        
    }

    public enum Distance
    {
        m, km, nm
    }


}

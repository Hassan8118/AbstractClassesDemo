using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } 
        public string Make { get; set; } = "Default value";
        public string Model { get; set; } = "Default value";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine("Default Virtual Drive Method");
        }
    }
}

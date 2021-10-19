using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Data_FileHandling
{
    class Hierarchical_demo
    {
    }

    class Car
    {
        public string Engine_Type { get; set; }

        public int Waranty { get; set; }

        public string name {get; set;}

        public void TopSpeed()
        {

        }

    }

    class Maruthi : Car
    {
        public void Car_Message()
        {
            Console.WriteLine("maruthi speed is very high");

        }

    }

        class Hyundai : Car
    {
        public void Car_Display() { }
    }

    class Honda : Car
    {
        public void Display() { }
    }

    class KIA : Car
    {
        public void Dispplay() { }
      

            }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Data_FileHandling
{
    class Demo_Inheritance
    {
        public void Display()
        {
            System.Console.WriteLine("HI Im parent class Method");
        }
            
    }

    class ChildClass : Demo_Inheritance
    {
        public void Child_Display()
        {
            base.Display();
            System.Console.WriteLine("HI Im child class Method");
            Console.WriteLine("child class Invoked");



        }
    }
}

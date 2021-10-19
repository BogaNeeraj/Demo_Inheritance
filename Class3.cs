using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Demo_Data_FileHandling
{
    class Demo_Inheritence
    {
    }
    interface Speak
    {
        public void speak();
        public void message()
        {
            System.Console.WriteLine("Inheritance1 method");
        }
    }
    interface Food
    {
        public void Food();
    }
    class Animal : Speak, Food
    {
        public void speak()
        {
            System.Console.WriteLine("declaration of interface method in class");
        }
        public void Food()
        {
            System.Console.WriteLine("Interface2 method");
        }
    }
}


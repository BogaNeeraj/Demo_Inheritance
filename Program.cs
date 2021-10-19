using System;

namespace Demo_Data_FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementig Different type of Inheritance");

            ChildClass Obj1 = new ChildClass();
            Obj1.Display();
            Obj1.Child_Display();

            Car Dealer1 = new Car();
            Dealer1.TopSpeed();

            Maruthi swift = new Maruthi();
            swift.Engine_Type = "manual";
            swift.name = "swift Desire tour";
            swift.Waranty = 5;
            Console.WriteLine("features od swift:\n {0}\n{1}\n{2}", swift.Engine_Type, swift.name, swift.Waranty);

            Hyundai HondaCity = new Hyundai();
            HondaCity.TopSpeed();
            HondaCity.Engine_Type = "Automatic";
            HondaCity.Waranty = 7;
            Console.WriteLine("features od swift:\n {0}\n{1}\n{2}", HondaCity.name, HondaCity.Engine_Type, HondaCity.Waranty);

            KIA baseModel = new KIA();
            baseModel.Engine_Type = "Aautomatic";
            baseModel.TopSpeed();
            baseModel.name = "SUV";
            baseModel.Waranty = 10;
            Console.WriteLine("Features of KIA:\n Engine type :{0}\n Car name: {1} waranty :{2}", baseModel.name, baseModel.Engine_Type, baseModel.Waranty);
            System.Console.WriteLine("Multiple Inheritance using Interfaces\n");
            Animal a = new Animal();
            a.speak();
            a.Food();
            Speak s = a;
            s.message();

        }
    }
}

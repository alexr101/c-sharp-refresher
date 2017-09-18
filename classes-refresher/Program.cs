using System;

namespace classesrefresher
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car car = new Car("Red");
            Car car2 = new Car("Blue");

            string color = car.Describe();
            Console.WriteLine(color);

            Overloading overloader = new Overloading();
            overloader.Plus(1, 2);
            overloader.Plus(2, 4, 5);

            StaticVsInstanceMethods staticTest = new StaticVsInstanceMethods();

            StaticVsInstanceMethods.StaticMethod();
            staticTest.InstanceMethod();

        }
    }
}



using System;
namespace classesrefresher
{
    public class StaticVsInstanceMethods
    {
        public StaticVsInstanceMethods()
        {
        }

        public static void StaticMethod()
        {
            Console.WriteLine("No class instantiation needed");
        }

        public void InstanceMethod()
        {
            Console.WriteLine("You need to instantiate the class to access");
        }
    }
}

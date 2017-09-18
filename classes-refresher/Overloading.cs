using System;
namespace classesrefresher
{
    public class Overloading
    {
        public Overloading()
        {
        }

        public int Plus(int num1, int num2) 
        {
            return Plus(num1, num2, 0);
        }

        public int Plus(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


    }
}

using System;
namespace classesrefresher
{
    public class Car
    {
        private string color;

        public Car(string color)
        {
            this.color = color;
        }

        public string Describe()
        {
            return "This car is " + color;
        }

        public string Color
        {
            get { return color; }
            set {
                if (value == "Red")
                    color = value;
                else
                    Console.WriteLine("Not Red");
            }
        }

        // Destructor
        -Car() {
            Console.WriteLine("I've just been garbage collected :(");
        }
    }
}

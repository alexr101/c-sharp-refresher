﻿using System;
namespace classesrefresher
{
    public class bcCore
    {
        public bcCore()
        {
			Car car = new Car("Red");
			Car car2 = new Car("Blue");

			string color = car.Describe();
			Console.WriteLine(color);
        }
    }
}

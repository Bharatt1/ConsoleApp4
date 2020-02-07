using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Car
    {
        public string color = "red";
        static void Main(string[] args)
         { 
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}

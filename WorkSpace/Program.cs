using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OOP;

namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.ChangeSpeed(15);
            Console.WriteLine(c.speed);
        }

    }

}

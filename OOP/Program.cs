using System;

namespace OOP
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

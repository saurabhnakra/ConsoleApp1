using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Rubber duck does not quack, it squeaks");
        }

        public override void Display()
        {
            Console.WriteLine("This duck looks like a rubber duck");
        }
    }
}

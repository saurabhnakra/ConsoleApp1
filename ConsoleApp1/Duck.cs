using System;

namespace ConsoleApp1
{
    abstract class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Duck quacks");
        }

        void Swim()
        {
            Console.WriteLine("Duck swims");
        }

        public abstract void Display();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Duck a = new MallardDuck();
            a.Display();
        }
    }
}

using System;
namespace Pattern.Strategy
{
    public class Quackable : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Waaaaaaaaaaaaaaaaaaaaah!!!");
        }
    }
}

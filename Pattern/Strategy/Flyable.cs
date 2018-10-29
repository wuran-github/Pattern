using System;
namespace Pattern.Strategy
{
    public class Flyable : IFlyBehavior
    {
        public void Fly()
        {
           Console.WriteLine("I belive I can fly!");
        }
    }
}

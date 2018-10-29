using System;
namespace Pattern.Strategy
{
    public class Unflyable : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Sorry, I can't fly");
        }
    }
}

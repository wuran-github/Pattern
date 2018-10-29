using System;
namespace Pattern.Strategy
{
    public class Unquackable:IQuackBehavior
    {
        public void Quack(){
            Console.WriteLine("Sorry, i can say anything!");
        }
    }
}

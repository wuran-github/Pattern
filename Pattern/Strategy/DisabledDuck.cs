using System;
namespace Pattern.Strategy
{
    public class DisabledDuck:Duck
    {
        public DisabledDuck(){
            this.SetFlyBehavior(new Flyable());
            this.SetIQuackBehavior(new Quackable());
        }
    }
}

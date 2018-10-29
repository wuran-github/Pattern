using System;
namespace Pattern.Strategy
{
    public class EnabledDuck:Duck
    {
         public EnabledDuck(){
            this.SetFlyBehavior(new Unflyable());
            this.SetIQuackBehavior(new Unquackable());
        }
    }
}

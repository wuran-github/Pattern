using System;
namespace Pattern.Strategy
{
    //声明为抽象
    public abstract class Duck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        
        //首先是依赖注入
        public void SetFlyBehavior(IFlyBehavior fly){
            flyBehavior=fly;
        }

        public void SetIQuackBehavior(IQuackBehavior quack){
            quackBehavior=quack;
        }
        //下面就是把方法委托给行为类
        public void PerformFly(){
            flyBehavior.Fly();
        }
        public void PerformQuack(){
            quackBehavior.Quack();
        }

        //测试方法
        public void Print(){
            PerformFly();
            PerformQuack();
        }
    }
}

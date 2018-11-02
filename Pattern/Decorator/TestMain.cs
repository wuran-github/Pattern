using myPattern;
using System;
namespace Pattern.Decorator
{
    public class TestMain : ITestMain
    {
        public void Begin()
        {
            IEntity charactor=new Charactor();
            
            //开始装备
            //weapon
            charactor=new Sword(charactor);

            //prop
            charactor=new Poison(charactor);

            Console.WriteLine("当前成功率:{0}",charactor.GetSuccessRate());
            Console.WriteLine("当前人物：{0}",charactor.GetDesc());
        }
    }
}

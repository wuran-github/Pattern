using System;
using myPattern;
namespace Pattern.Factory
{
    public class TestMain : ITestMain
    {
        public void Begin()
        {
            //简单工厂
            Charactor c=new Charactor();
            StaticQuestFactory staticQuestFactory=new StaticQuestFactory();
            c.Quest=staticQuestFactory.GetQuestInstance(0);
            c.Print();
            c.Quest=staticQuestFactory.GetQuestInstance(1);
            c.Print();
            
        }
    }
}

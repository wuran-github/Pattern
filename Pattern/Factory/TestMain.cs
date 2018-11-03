using System;
using myPattern;
namespace Pattern.Factory
{
    public class TestMain : ITestMain
    {
        public void Begin()
        {

            //StaticFactory();
            Factory();
            AbstractFactory();


        }

        void StaticFactory()
        {
            //简单工厂
            Charactor c = new Charactor();
            StaticQuestFactory staticQuestFactory = new StaticQuestFactory();
            c.Quest = staticQuestFactory.GetQuestInstance(0);
            c.Print();
            c.Quest = staticQuestFactory.GetQuestInstance(1);
            c.Print();
        }
        void Factory()
        {
            Charactor c = new Charactor();
            //工厂方法
            IQuestFactory questFactory = new KillGoblinFactory();
            c.Quest = questFactory.GetQuestInstance();
            c.Print();
            questFactory = new DeliverGoodsFactory();
            c.Quest = questFactory.GetQuestInstance();
            c.Print();

            questFactory = new SearchRingFactory();
            c.Quest = questFactory.GetQuestInstance();
            c.Print();
        }

        void AbstractFactory()
        {

        }
    }
}

using System;
using myPattern;
using Pattern;
namespace Pattern.Factory
{
    public class TestMain : ITestMain
    {
        public void Begin()
        {

            //StaticFactory();
            // Factory();
            UseAbstractFactory();


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

        void UseAbstractFactory()
        {
            AbstractFactory.Charactor c = new AbstractFactory.Charactor();
            AbstractFactory.IEquipmentFactory changGe=new AbstractFactory.ChangGeFactory();
            AbstractFactory.IEquipmentFactory chunYang=new AbstractFactory.ChunYangFactory();

            AbstractFactory.IQuestFactory questFactory=new AbstractFactory.KillGoblinFactory();
            c.Quest=questFactory.GetQuestInstance(chunYang);
            c.Print();
            
            questFactory=new AbstractFactory.DeliverGoodsFactory();
            c.Quest=questFactory.GetQuestInstance(changGe);
            c.Print();

             questFactory=new AbstractFactory.SearchRingFactory();
            c.Quest=questFactory.GetQuestInstance(changGe);
            c.Print();

        }
    }
}

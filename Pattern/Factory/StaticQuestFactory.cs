using System;
namespace Pattern.Factory
{
    public class StaticQuestFactory
    {
        public IQuest GetQuestInstance(int i){
            switch(i){
                case 0:
                return new KillGoblin();
                case 1:
                return new DeliverGoods();
                default:
                return null;
            }
        }
    }
}

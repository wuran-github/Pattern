using System;
namespace Pattern.Factory
{
    public class DeliverGoodsFactory : IQuestFactory
    {
        public IQuest GetQuestInstance()
        {
            return new DeliverGoods();
        }
    }
}

using System;
using Pattern.Factory;
namespace Pattern.AbstractFactory
{
    public class DeliverGoodsFactory : IQuestFactory
    {
        public IQuest GetQuestInstance()
        {
            return new DeliverGoods();
        }
    }
}

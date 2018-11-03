using System;
namespace Pattern.AbstractFactory
{
    public class DeliverGoodsFactory : IQuestFactory
    {
        public IQuest GetQuestInstance(IEquipmentFactory equipmentFactory)
        {
            return new DeliverGoods(){
                EquipmentFactory=equipmentFactory,
            };
        }
    }
}

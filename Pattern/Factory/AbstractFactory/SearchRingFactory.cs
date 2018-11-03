using System;
namespace Pattern.AbstractFactory
{
    public class SearchRingFactory : IQuestFactory
    {
        public IQuest GetQuestInstance(IEquipmentFactory equipmentFactory)
        {
            return new SearchRing(){
                EquipmentFactory=equipmentFactory,
            };
        }
    }
}

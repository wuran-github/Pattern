using System;
namespace Pattern.AbstractFactory
{
    public class KillGoblinFactory : IQuestFactory
    {
        public IQuest GetQuestInstance(IEquipmentFactory equipmentFactory)
        {
            return new KillGoblin(){
                EquipmentFactory=equipmentFactory,
            };
        }
    }
}

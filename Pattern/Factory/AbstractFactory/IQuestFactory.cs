using System;

namespace Pattern.AbstractFactory
{
    public interface IQuestFactory
    {
        IQuest GetQuestInstance(IEquipmentFactory equipmentFactory);
    }
}

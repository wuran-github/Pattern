using System;

namespace Pattern.AbstractFactory
{
    public interface IQuest
    {
        string Name{get;set;}

        int SuccessRate{get;set;}

        IEquipmentFactory EquipmentFactory {get;set;}
        //只是测试，就用这么一个方法
        void PrintQuestName();

        //使用装备
        void UseEquipment();
    }
}

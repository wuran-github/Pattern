using System;
namespace Pattern.AbstractFactory
{
    public abstract class Quest : IQuest
    {
        public string Name { get; set; }
        public int SuccessRate { get; set; }
        public IEquipmentFactory EquipmentFactory {get;set;}
        private IItem item;
        private IWeapon weapon;

        public void PrintQuestName()
        {
            UseEquipment();
            Console.WriteLine("当前武器：{0},当前物品：{1}",weapon.Name,item.Name);
            Console.WriteLine("任务名称:{0},成功率:{1}%",Name,SuccessRate);
        }

        public void UseEquipment()
        {
            item=EquipmentFactory.CreateItem();
            weapon=EquipmentFactory.CreateWeapon();
        }
    }
}

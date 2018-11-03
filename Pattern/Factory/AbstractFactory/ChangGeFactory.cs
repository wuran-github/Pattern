using System;

namespace Pattern.AbstractFactory
{
    public class ChangGeFactory:IEquipmentFactory
    {
        public ChangGeFactory()
        {
        }

        public IItem CreateItem()
        {
            return new QinOil();
        }

        public IWeapon CreateWeapon()
        {
            return new GuQin();
        }
    }
}
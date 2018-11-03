using System;

namespace Pattern.AbstractFactory
{
    public class ChunYangFactory:IEquipmentFactory
    {
        public ChunYangFactory()
        {
        }

        public IItem CreateItem()
        {
            return new DaoFu();
        }

        public IWeapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
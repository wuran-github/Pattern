using System;

namespace Pattern.AbstractFactory
{
    public interface IEquipmentFactory
    {
        IWeapon CreateWeapon();
        IItem CreateItem();
    }
}
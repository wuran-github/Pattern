using System;

namespace Pattern.AbstractFactory
{
    public class Sword : IWeapon
    {
        public string Name { get; set; }

        public Sword()
        {
            Name = "剑";
        }
        public void Print()
        {

        }
    }
}
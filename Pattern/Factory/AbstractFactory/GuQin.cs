using System;

namespace Pattern.AbstractFactory
{
    public class GuQin : IWeapon
    {
        public GuQin()
        {
            Name="古琴";
        }

        public string Name { get; set; }

        public void Print()
        {
           
        }
    }
}
using System;

namespace Pattern.AbstractFactory
{
    public class QinOil : IItem
    {
        public QinOil()
        {
            Name = "琴油";
        }

        public string Name { get; set; }

        public void Print()
        {

        }
    }
}
using System;

namespace Pattern.AbstractFactory
{
    public class DaoFu:IItem
    {
        public DaoFu()
        {
            Name="道符";
        }

        public string Name { get ; set ; }

        public void Print()
        {
           
        }
    }
}
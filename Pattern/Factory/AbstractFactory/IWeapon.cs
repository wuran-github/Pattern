using System;

namespace Pattern.AbstractFactory
{
    public interface IWeapon
    {
        string Name{get;set;}
        void Print();
    }
}
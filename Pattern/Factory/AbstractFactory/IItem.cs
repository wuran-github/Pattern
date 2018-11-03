using System;

namespace Pattern.AbstractFactory
{
    public interface IItem
    {
        string Name{get;set;}
        void Print();
    }
}
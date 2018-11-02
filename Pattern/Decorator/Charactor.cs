using System;
namespace Pattern.Decorator
{
    public class Charactor : IEntity
    {
        public decimal SuccessRate{get;set;}
        public string Name{get;set;}
        public Charactor(){
            Name="冒险家";
            SuccessRate=0.5m;
        }
        public string GetDesc(){
            return Name;
        }
        public decimal GetSuccessRate()
        {
            return SuccessRate;
        }
    }
}

using System;
namespace Pattern.Decorator
{
    public abstract class Weapon : IRoleDecorator
    {
        protected IEntity entity;
        public decimal SuccessRate{get;set;}
        public Weapon(IEntity entity){
            SetEntity(entity);
        }
        public abstract void SetEntity(IEntity entity);
        public abstract string GetDesc();
        public abstract decimal GetSuccessRate();
    }
}

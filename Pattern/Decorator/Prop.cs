using System;
namespace Pattern.Decorator
{
    public abstract class Prop:IRoleDecorator
    {
         protected IEntity entity;
        public decimal SuccessRate{get;set;}
        public Prop(IEntity entity){
            SetEntity(entity);
        }
        public abstract void SetEntity(IEntity entity);
        public abstract string GetDesc();
        public abstract decimal GetSuccessRate();
    }
}

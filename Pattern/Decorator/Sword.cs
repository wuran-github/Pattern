using System;
namespace Pattern.Decorator
{
    public class Sword : Weapon
    {
        public Sword(IEntity entity) : base(entity)
        {
            SuccessRate=0.4m;
        }

        public Sword(IEntity entity,decimal s):this(entity)
        {
            
            SuccessRate=s;
        }

        public override string GetDesc()
        {
            return entity.GetDesc()+" 剑";
        }

        public override decimal GetSuccessRate()
        {
            return entity.GetSuccessRate()*(1+SuccessRate);
        }

        public override void SetEntity(IEntity entity)
        {
            this.entity=entity;
        }
    }
}

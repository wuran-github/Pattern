using System;
namespace Pattern.Decorator
{
    public class Poison:Prop
    {
        public Poison(IEntity entity) : base(entity)
        {
            SuccessRate=0.2m;
        }

        public Poison(IEntity entity,decimal s):this(entity)
        {
            
            SuccessRate=s;
        }

        public override string GetDesc()
        {
            return entity.GetDesc()+" 毒药";
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

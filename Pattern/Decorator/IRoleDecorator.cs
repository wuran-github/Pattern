using System;
namespace Pattern.Decorator
{
    public interface IRoleDecorator : IEntity
    {
  
        void SetEntity(IEntity entity);
    }
}

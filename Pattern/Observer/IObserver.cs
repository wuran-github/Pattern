using System;

namespace Pattern.Observer
{
    public interface IObserver
    {
        void Update(ISubject subject,Object arg);
    }
}
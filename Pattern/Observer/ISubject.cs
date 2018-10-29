using System;

namespace Pattern.Observer
{
    public interface ISubject
    {
        bool RegisterObserver(IObserver ob);
        bool RemoveObserver(IObserver ob);

        void NotifyObserver();
    }
}
using System;

namespace Pattern.Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver ob);
        void RemoveObserver(IObserver ob);

        void NotifyObserver(Object arg);

        //用来判断是否Update，有必要
        bool IsChanged();
    }
}
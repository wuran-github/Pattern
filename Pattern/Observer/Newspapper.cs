using System;
using System.Collections.Generic;

namespace Pattern.Observer
{
    public class Newspapper : ISubject
    {
        bool changed=true;
        List<IObserver> observers = null;

        //
        public string Title{get;set;}
        public DateTime Date{get;set;}
        public string Content{get;set;}
        //
        public Newspapper()
        {
            observers = new List<IObserver>();
            changed=true;
            Title="测试标题";
            Date=DateTime.Now;
            Content="测试内容";
        }
        public bool IsChanged()
        {
            return changed;
        }

        public void NotifyObserver(object arg)
        {
            if (IsChanged())
            {
                //这是一种，如果在update的时候会删除需要调用另一种
                foreach (var ob in observers)
                {
                    ob.Update(this, arg);
                }

                //第二种
                //复制一个新的
                // var newObs=new List<IObserver>(observers);
                // foreach (var ob in newObs)
                // {
                //     //这样从subject中remove的时候就不会影响index导致出错了
                //     ob.Update(this,arg);
                // }
            }
        }

        public void RegisterObserver(IObserver ob)
        {
            if(!observers.Contains(ob)){
                observers.Add(ob);
            }
        }

        public void RemoveObserver(IObserver ob)
        {
            if(observers.Contains(ob)){
                observers.Remove(ob);
            }
        }
    }
}

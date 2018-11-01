using System;
using myPattern;
namespace Pattern.Observer
{
    public class TestMain : ITestMain
    {
        public void Begin()
        {
            ISubject newspapper=new Newspapper();
            IObserver observer=new Person();
            newspapper.RegisterObserver(observer);
            newspapper.NotifyObserver(null);
        }
    }
}

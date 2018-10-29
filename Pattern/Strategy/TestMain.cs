using System;
using myPattern;

namespace Pattern.Strategy
{
    public class TestMain:ITestMain
    {
        public void Begin(){
            DisabledDuck disabledDuck=new DisabledDuck();
            EnabledDuck enabledDuck=new EnabledDuck();
            disabledDuck.Print();
            enabledDuck.Print();
        }
    }
}

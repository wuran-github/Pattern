using System;

namespace myPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestMain main;

            main=new Pattern.Strategy.TestMain();
            main.Begin();
        }
    }
}

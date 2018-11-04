﻿using System;

namespace myPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestMain main;


            //strategy pattern
            // main=new Pattern.Strategy.TestMain();

            // //Observer pattern
            // main=new Pattern.Observer.TestMain();

            // //Decorator Pattern
            // main=new Pattern.Decorator.TestMain();

            // Factory Pattren
            // main=new Pattern.Factory.TestMain();

            //Command Pattern
            main=new Pattern.Command.TestMain();
            main.Begin();
            
        }
    }
}

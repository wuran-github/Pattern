using System;
namespace Pattern.Command
{
    public class Television
    {
        public void Open(){
            Console.WriteLine("多摩！我是电视！开电视！");
        }
        public void Close(){
            Console.WriteLine("关电视了，别看了");
        }
    }
}

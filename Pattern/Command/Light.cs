using System;
namespace Pattern.Command
{
    //看情况把，有时候需要加一个设备的接口啥的
    public class Light
    {
        public void Open(){
            Console.WriteLine("开灯咯！");
        }
        public void Close(){
            Console.WriteLine("关灯啦！");
        }
    }
}

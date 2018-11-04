using System;
using myPattern;
namespace Pattern.Command
{
    public class TestMain : ITestMain
    {
        public void Begin()
        {
            RemoteControl remoteControl=new RemoteControl();
            Light light=new Light();
            Television television=new Television();

            LightOnCommand lightOnCommand=new LightOnCommand(light);
            LightOffCommand lightOffCommand=new LightOffCommand(light);
            
            TVOnCommand tVOnCommand=new TVOnCommand(television);
            TVOffCommand tVOffCommand=new TVOffCommand(television);

            //注册到invoker中

            remoteControl.SetOnCommand(DeviceType.Light,lightOnCommand);
            remoteControl.SetOffCommand(DeviceType.Light,lightOffCommand);
            remoteControl.SetOnCommand(DeviceType.Television,tVOnCommand);
            remoteControl.SetOffCommand(DeviceType.Television,tVOffCommand);

            //开灯咯
            remoteControl.On(DeviceType.Light);
            remoteControl.On(DeviceType.Television);

            //关灯咯
            remoteControl.Off(DeviceType.Light);
            remoteControl.Off(DeviceType.Television);
        }
    }
}

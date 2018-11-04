using System;
using System.Collections.Generic;

namespace Pattern.Command
{
    public class RemoteControl
    {
        //遥控式用数组，毕竟是1234的位置嘛
        //这种的话应该是智能式的，智能式是根据类型来判断！
        Dictionary<DeviceType,ICommand> onCommand;
        Dictionary<DeviceType,ICommand> offCommand;

        public RemoteControl(){
            onCommand=new Dictionary<DeviceType, ICommand>();
            offCommand=new Dictionary<DeviceType, ICommand>();
        }
        public void SetOnCommand(DeviceType type,ICommand command){
            onCommand.Add(type,command);
        }

        public void SetOffCommand(DeviceType type,ICommand command){
            offCommand.Add(type,command);
        }

        public void On(DeviceType type){
            onCommand[type].Execute();
        }

        public void Off(DeviceType type){
            offCommand[type].Execute();
        }



    }
}

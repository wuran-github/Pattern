using System;
namespace Pattern.Command
{
    public class LightOffCommand : ICommand
    {
       private Light light;
        public LightOffCommand(Light light){
            this.light=light;
        }
        public void Execute()
        {
            light.Close();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}

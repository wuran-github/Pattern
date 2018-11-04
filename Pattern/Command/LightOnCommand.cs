using System;
namespace Pattern.Command
{
    public class LightOnCommand : ICommand
    {
        private Light light;
        public LightOnCommand(Light light){
            this.light=light;
        }
        public void Execute()
        {
            light.Open();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}

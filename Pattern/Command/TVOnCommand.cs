using System;
namespace Pattern.Command
{
    public class TVOnCommand:ICommand
    {
         private Television TV;
        public TVOnCommand(Television TV){
            this.TV=TV;
        }
        public void Execute()
        {
            TV.Open();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}

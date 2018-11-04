using System;
namespace Pattern.Command
{
    public class TVOffCommand : ICommand
    {
        private Television TV;
        public TVOffCommand(Television TV){
            this.TV=TV;
        }
        public void Execute()
        {
            TV.Close();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}

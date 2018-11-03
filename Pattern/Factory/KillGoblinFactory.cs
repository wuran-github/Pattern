using System;
namespace Pattern.Factory
{
    public class KillGoblinFactory : IQuestFactory
    {
        public IQuest GetQuestInstance()
        {
            return new KillGoblin();
        }
    }
}

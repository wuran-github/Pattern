using System;
using Pattern.Factory;
namespace Pattern.AbstractFactory
{
    public class KillGoblinFactory : IQuestFactory
    {
        public IQuest GetQuestInstance()
        {
            return new KillGoblin();
        }
    }
}

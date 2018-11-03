using System;

namespace Pattern.Factory
{
    public interface IQuestFactory
    {
        IQuest GetQuestInstance();
    }
}

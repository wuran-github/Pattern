using System;
namespace Pattern.Factory
{
    public class SearchRingFactory : IQuestFactory
    {
        public IQuest GetQuestInstance()
        {
            return new SearchRing();
        }
    }
}

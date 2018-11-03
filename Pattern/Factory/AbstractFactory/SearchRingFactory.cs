using System;
using Pattern.Factory;
namespace Pattern.AbstractFactory
{
    public class SearchRingFactory : IQuestFactory
    {
        public IQuest GetQuestInstance()
        {
            return new SearchRing();
        }
    }
}

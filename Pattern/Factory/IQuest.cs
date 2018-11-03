using System;

namespace Pattern.Factory
{
    public interface IQuest
    {
        string Name{get;set;}

        int SuccessRate{get;set;}
        //只是测试，就用这么一个方法
        void PrintQuestName();
    }
}

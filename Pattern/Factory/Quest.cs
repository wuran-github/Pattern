using System;
namespace Pattern.Factory
{
    public abstract class Quest : IQuest
    {
        public string Name { get; set; }
        public int SuccessRate { get; set; }

        public void PrintQuestName()
        {
            Console.WriteLine("任务名称:{0},成功率:{1}%",Name,SuccessRate);
        }
    }
}

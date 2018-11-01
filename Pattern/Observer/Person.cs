using System;
namespace Pattern.Observer
{
    public class Person : IObserver
    {
        string Name{get;set;}
        public Person(){
            Name="读报人";
        }
        public void Update(ISubject subject, object arg)
        {
            var news=subject as Newspapper;
            if(news!=null){
                Print(news);
            }
        }
        void Print(Newspapper news){
            Console.WriteLine("{0} 读报了！",this.Name);
            Console.WriteLine("今日报纸头条：{0} ！",news.Title);
            Console.WriteLine("日期：{0} ",news.Date.ToString("yyyy-MM-dd"));
            Console.WriteLine("内容：{0} ",news.Content);
        }
    }
}

using System;
namespace Pattern.Factory
{
    public class Charactor
    {
        //属性注入
        public IQuest _quest;
        public IQuest Quest{
            get{
                return _quest;
            }
            set{
                this._quest=value;
            }
        }

        public Charactor(){

        }
        public void Print(){
            Quest.PrintQuestName();
        }
    }
}

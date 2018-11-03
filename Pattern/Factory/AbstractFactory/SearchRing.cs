using System;
using Pattern.Factory;
namespace Pattern.AbstractFactory
{
    public class SearchRing : Quest
    {

        public SearchRing(){
            Name="寻找丢失的戒指";
            SuccessRate=40;
        }
    }
}

using System;
namespace Pattern.AbstractFactory
{
    public class DeliverGoods:Quest
    {
        public DeliverGoods(){
            this.Name="送货";
            this.SuccessRate=95;
        }
    }
}

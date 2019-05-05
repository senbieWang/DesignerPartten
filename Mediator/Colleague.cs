using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Colleague
    {
        protected Mediator Mediator;
        protected string Name { get; set; }
        public Colleague(string name, Mediator mediator)
        {
            Name = name;
            Mediator = mediator;
        }
    }

    //房主
    public class ColleagueA : Colleague
    {
        public ColleagueA(string name, Mediator mediator) : base(name, mediator) { }
        
        //发布消息
        public void PushMessage(string message)
        {
            Mediator.pushMessage(message,this);
        }

        //接收消息
        public void GetMessage(string message)
        {
            Console.WriteLine("房主："+Name + ",获取信息："+message);
        }
    }

    //租房者
    public class ColleagueB : Colleague
    {
        public ColleagueB(string name, Mediator mediator) : base(name, mediator) { }
        
        //发布消息
        public void PushMessage(string message)
        {
            Mediator.pushMessage(message, this);
        }

        //接收消息
        public void GetMessage(string message)
        {
            Console.WriteLine("租房者:" + Name + ",获得信息：" + message);
        }

    }
}

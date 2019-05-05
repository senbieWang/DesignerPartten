using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            //一个房主、一个租房者、一个中介机构
            ConcertorMediator mediator = new ConcertorMediator();

            //房主和租房者只需要知道中介机构即可
            ColleagueA colleagueA = new ColleagueA("张三",mediator);
            ColleagueB colleagueB = new ColleagueB("李四", mediator);

            //中介结构要知道房主和租房者
            mediator.colleagueA = colleagueA;   //房主
            mediator.colleagueB = colleagueB;   //租房者

            colleagueB.PushMessage(" 听说你那里有三室的房主出租.....");
            colleagueA.PushMessage(" 是的!请问你需要租吗?");

        }
    }
}

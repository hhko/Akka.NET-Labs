﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Akka.Actor;

namespace HowTo_04_SendMessagesToTheParent
{
    public class ExampleChildActor1 : ReceiveActor
    {
        public static Props Props()
        {
            return Akka.Actor.Props.Create(() => new ExampleChildActor1());
        }

        public ExampleChildActor1()
        {
            Console.WriteLine(
                string.Format("{0:000} {1,-30}",
                    Thread.CurrentThread.ManagedThreadId,
                    "ExampleChildActor1"));

            //
            // 부모 Actor에게 메시지 보내기
            //
            Context.Parent.Tell("2002 Korea Japan World Cup");
        }
    }
}

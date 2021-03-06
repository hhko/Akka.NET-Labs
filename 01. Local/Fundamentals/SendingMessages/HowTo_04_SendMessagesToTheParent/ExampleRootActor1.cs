﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Akka.Actor;

namespace HowTo_04_SendMessagesToTheParent
{
    public class ExampleRootActor1 : ReceiveActor
    {
        private readonly IActorRef _childActorRef;

        public static Props Props()
        {
            return Akka.Actor.Props.Create(() => new ExampleRootActor1());
        }

        public ExampleRootActor1()
        {
            _childActorRef = Context.ActorOf(ExampleChildActor1.Props(), ActorPaths.ChildActor1.Name);

            Receive<string>(value => Handle(value));
        }

        private void Handle(string value)
        {
            Console.WriteLine(
                string.Format("{0:000} {1,-30} : {2}",
                    Thread.CurrentThread.ManagedThreadId,
                    "ExampleRootActor1",
                    value));
        }
    }
}

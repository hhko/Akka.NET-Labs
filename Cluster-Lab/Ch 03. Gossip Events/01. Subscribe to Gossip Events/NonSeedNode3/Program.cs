﻿using Akka.Actor;
using Akka.Configuration;
using System;
using System.IO;

namespace NonSeedNode3
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigurationFactory.ParseString(File.ReadAllText("App.Akka.conf"));
            ActorSystem system = ActorSystem.Create("ClusterLab", config);

            system.ActorOf(MemberListenAsSnapshotActor.Props(), nameof(MemberListenAsSnapshotActor));

            Console.WriteLine();
            Console.WriteLine("NonSeedNode3 is running...");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

# MORE FUN with Akka.NET Labs 

## Cluster Lab
1. **Overview**
   - Create Cluster : **akka.cluster.seed-nodes**
   - Integrate with Petabridge.Cmd  
   - Automatically Mark Unreachable Nodes : **akka.cluster.auto-down-unreachable-after**
   - Retry Joining Time Interval : **akka.cluster.seed-node-timeout**
   - > Seed Node N개 일 때
   - > Petabridge.Cmd Join, Leave, ...
1. **Roles and Minimum Size**
   - Define Roles : **akka.cluster.roles**
   - Cluster-Wide Minimum Size : **akka.cluster.min-nr-of-members**
   - Per-Role Minimum Size : **akka.cluster.role.<role-name>.min-nr-of-members**
   - Mix Minimum Size  
1. **Gossip Events**
   - Subscribe to Gossip Events : **Cluster _cluster = Cluster.Get(Context.System); _cluster.Subscribe(Self, ...);**
   - Discover Actor by Tag
   - Discover Actor by Role and Path : **cluster.State.Members.Where(member => ...);**
1. **Warm-up For Cluster Routing**
   - Local Routing Pools : Create routees automatically. **round-robin-pool**
   - Local Routing Groups : Create routees yourself. **round-robin-group**, **path**
   - Remote Deploy
   - > Local Routing Pools : Exceptions
   - > Local Routing Groups : Exceptions
   - > Remote Deploy : Exceptions Info? 
1. **Cluster Routing**
1. **Cluster Singleton**
1. **Distributed PubSub**
1. **Cluster Client**
   - Communicate with Cluster by Path 
   - Communicate with Cluster by Topic
   - Subscribe to SubscribeContactPoints Events
   - Subscribe to SubscribeClusterClients Events
   - Send Custom Messages
   - > Ping Pong Tutorial(Akka.NET Example)
   - > akka.cluster.client.receptionist, akka.cluster.client HOCON
1. **Sharding**
1. **Distributed Data**
1. **Split Brain Resolver**      
   
<br/>
<br/>

## DOING - Labs
1. Akka
   - Cluster Lab
   - Local Lab
   - Persistence Lab
1. Pattern Lab
   - Saga
1. Docker Container Lab
1. RabbitMQ Lab
1. Visual Studio Extension Lab

<br/>

## DOING
- [ ] [Role 기반으로 Actor에게 메시지 보내기](https://github.com/akkadotnet/akka.net/issues/3757#issuecomment-483522034)
   - [ ] Sender ?
   - [ ] async IEnumerable 적용
- [ ] ClusterClient 
   - [ ] Sender.Tell???? 
   - [ ] 반드시 Seed Node이어야만 하나?
- [ ] Warm-up
   - [ ] 예외만 예제를 분리한다.
- [ ] Cluster Pool Routing
- [ ] Cluster Group Routing
- [ ] Cluster Pub/Sub
- [ ] At least once
- [ ] 콘솔 타이틀
- [ ] NLog 
- [ ] akka.cluster.client.receptionist.role ???
- [ ] README.md > 주요 함수 Summary 추가
- [ ] NLog
   - [ ] [3] -> [0003] ThreadId 고정 영역으로 출력하기
   - [ ] Log 출력 소스 정보 [ ...? ] -> [akka://ClusterLab/deadletters]
   - [ ] 01. Overview -> 04. Retry Joining Time Interval -> NonSeedNode1 적용
- [ ] Akka
   - [ ] 콘솔 타이틀을 추가한다.
   - [ ] Console.WriteLine -> Log
   - [ ] 프로그램 종료 방법 변경
   - [ ] ActorSystem 이름을 conf 파일에서 지정하기 + SeedNode 이름에도 같이 사용하기?
   - [ ] [ClusterClient Router 연동할 때 버그 이슈](https://github.com/akkadotnet/akka.net/issues/3315)
- [ ] README.md 
   - [ ] 요약 추가
   - [ ] Diagram 이미지 추가
   - [ ] Youtube 데모 동영상 추가

<br/>

## TODO - Akka.NET 이슈
- [ ] Hocon 다음 행 시작에 ","일 때 예외 발생
- [ ] Warm-up, Deploy, Deploy 예외 처리 정보 부족
- [ ] ClusterClient "/user/xyz/" ActorPath 마지막에 "/"가 있으면 전달되지 않는다. 
- [ ] ClusterClient에세 정의된 사용자 정의 메시지가 Seed Node에도 참조되어 있어야 전송할 수 있다.

<br/>

## TODO - FAQ
- [ ] Long running + Cancel: FSM
- [ ] Ask -> FSM
- [ ] Logging Message Info(including Generic).
- [ ] Log 분리(App, Akka, ...)
- [ ] Large Message
- [ ] 환경 설정 이해(akka.cluster.failure-detector/akka.remote.transport-failure-detector/ ...
- [ ] Serialization 
   - [ ] readonly
   - [ ] WPF
- [ ] WPF
   - [ ] main-thread Router x
   - [ ] Akka Coding Rules
   - [ ] MVVM + Akka Router
- [ ] 장애 처리 재시도?
- [ ] DeadLetter 재시도?
- [ ] 장기간 Busy Actor일 때 Heartbeat 처리?
- [ ] 매뉴얼 무중단 Rolling Update(메시지 버전 Up, ...)
- [ ] Actor Hierarchy 출력(/user/..., /system/...)
- [ ] 메시지 전송을 위해서는 메시지 Dll을 Cluster 모듈 모두가 참조해야 하나? SeedNode까지 포함해서?

<br/>
 
## TODO - ClusterLab
- [ ] Overview 
   - [ ] SeedNode가 종료된 후 재 시작할 때?
   - [ ] SeedNode가 N개 일 때
- [ ] Gossip Events > RegisterOnMemberRemoved, Leave, Join, ... 
- [ ] Cluster Routing Pools
- [ ] Cluster Routing Groups
- [ ] Cluster Singleton
- [ ] Cluster Pub/Sub
- [ ] Split Brain Resolver
- [ ] Consul Actor Discovery
- [ ] Cluster Sharding
- [ ] Cluster Distributed Data
- [ ] Transactions
  
<br/>  
  
## TODO - 예제 추가
- [ ] [Cluster.WebCrawler](https://github.com/petabridge/akkadotnet-code-samples/tree/master/Cluster.WebCrawler)
- [ ] [Cluster.Monitoring](https://github.com/cgstevens/Akka.Cluster.Monitor)
- [ ] [Akka.NET Repo Cluster Examples](https://github.com/akkadotnet/akka.net/tree/dev/src/examples/Cluster)
- [ ] [Sharding](https://github.com/uatec/akka.net-clustersharding-example)
- [ ] [Pluralsight Akka.NET Cluster](https://github.com/thelegendofando/Pluralsight)
- [ ] [Pub/Sub Problem](https://github.com/thelegendofando/ProducerConsumerProblem)
- [ ] [Singleton Example](https://github.com/cgstevens/MyClusterServices)
- [ ] [FileProcessor](https://github.com/cgstevens/FileProcessor)
- [ ] [Akka.NET Workshop](https://github.com/profesor79/LDNAAkkaWorkshop)
- [ ] [Akka.NET Patterns](https://github.com/profesor79/akka.net.Patterns)
- [ ] [Riccardo Terrell, ActorModel](https://github.com/rikace/AkkaActorModel)
- [ ] [Riccardo Terrell, Workshop](https://github.com/rikace/akkaworkshop)
- [ ] [Riccardo Terrell, devConf2017](https://github.com/rikace/devConf2017)
- [ ] [Proto Saga](http://proto.actor/blog/2017/06/24/money-transfer-saga.html)
- [ ] [Proto Examples](https://github.com/rogeralsing/protoactor-dotnet/tree/dev/examples)
- [ ] [Akka.Cluster.Sharding demo](https://github.com/Horusiath/AkkaDemos)
- [ ] [CQRS](https://github.com/Horusiath/AkkaCQRS)
- [ ] [HealthCheck](https://github.com/petabridge/akkadotnet-healthcheck)
- [ ] [Cluster Sharding](https://github.com/ctrlaltdan/akka.net-cluster-sharding)
- [ ] [한글 예제](https://github.com/psmon/AkkaNetTest/blob/master/README.md)
- [ ] [akka-net-traffic-control](https://github.com/EdwinVW/akka-net-traffic-control)
- [ ] [akka.net-warehouse-sample](https://github.com/EdwinVW/akka.net-warehouse-sample)
- [ ] [Akka 공식 예제](https://github.com/akka/akka-samples)
- [ ] [Akka.NET 공식 예제](https://github.com/akkadotnet/akka.net/tree/dev/src/examples)
- [ ] [Akka.NET Bootcamp](https://github.com/petabridge/akka-bootcamp)
- [ ] [Actor MapReduce WordCounter](https://github.com/DavidHoerster/ActorMapReduceWordCounter)
- [ ] [Saga Pattern](https://github.com/heynickc/akka_process_manager)
- [ ] [Saga UnitTests](https://github.com/VaughnVernon/Dotsero/blob/master/DotseroTest/ProcessManagerTests.cs), [동영상](https://vimeo.com/104021785)

<br/>

## Blog Korean
- [ ] [Bbotcamp 한글화](https://blog.rajephon.dev/2018/12/02/akka-01/)
- [ ] [블로그](https://m.blog.naver.com/PostView.nhn?blogId=kbh3983&logNo=221182343063&categoryNo=119&proxyReferer=https%3A%2F%2Fwww.google.co.kr%2F)
- [ ] [한글 Wiki](http://wiki.webnori.com/m/mobile.action#page/1048605)

<br/>

## Blog English
- [ ] [Gigi](http://gigi.nullneuron.net/gigilabs/tag/akka-net/)
- [ ] [Akka-Guide](https://connelhooley.uk/blog/2017/02/21/akka-guide)
- [ ] [Akka-Testing-Helper V1](https://connelhooley.uk/blog/2017/09/30/introducing-akka-testing-helpers-di)
- [ ] [Akka-Testing-Helper V2](https://connelhooley.uk/blog/2018/10/05/akka-testing-helpers-v2)
- [ ] [AkkaTestingHelpers](https://github.com/connelhooley/AkkaTestingHelpers)
- [ ] [Akka.NET with EF.Core](https://havret.io/akka-entity-framework-core)
- [ ] [Akka.NET + DI + Testing Considerations](https://sachabarbs.wordpress.com/2018/05/22/akka-net-di-testing-considerations/)
- [ ] [Supervisors in C# with Akka.NET](https://buildplease.com/pages/supervisors-csharp/)
- [ ] [Akka.NET 기술 정리 7개](https://hryniewski.net/tag/akka-net/)
- [ ] [Akka.NET 팀 코어 멤버](https://bartoszsypytkowski.com/tag/akka-net/)
- [ ] [Akka.NET Extension 만들기](https://havret.io/akka-entity-framework-core)


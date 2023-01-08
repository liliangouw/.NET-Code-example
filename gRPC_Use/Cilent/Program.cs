// See https://aka.ms/new-console-template for more information
using Cilent;

Console.WriteLine("Hello, World!");

//客户端调用gRPC
//1.引入Nuget包：Grpc.Net.Client、Grpc.Tools、Google.Protobuf
//2.拷贝服务端的Proto文件，修改项目文件为Cilent
//3.调用
await gRPCRequest.TestHello();
await gRPCRequest.TestCount();

//支持AOP
//1.引入Grpc.Core.Api
//2.通过Intercepter扩展
Console.ReadKey();

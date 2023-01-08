using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using gRPC_Use;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilent
{
    internal class gRPCRequest
    {
        public static async Task TestHello()
        {
            using(var channel = GrpcChannel.ForAddress("https://localhost:7042"))
            {
                var client=new Greeter.GreeterClient(channel);
                var reply = await client.SayHelloAsync(new HelloRequest
                {
                    Name="你好"
                });
                Console.WriteLine("Greeter服务器返回数据:"+reply.Message);
            }
        }
        public static async Task TestCount()
        {
            using (var channel = GrpcChannel.ForAddress("https://localhost:7042"))
            {
                var client = new Greeter.GreeterClient(channel);
                var reply = await client.CountAsync(new Empty());
                Console.WriteLine("Greeter服务器返回数据:" + reply.Count);
            }
        }
    }
}

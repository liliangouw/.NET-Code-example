using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using gRPC_Use;

namespace gRPC_Use.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
        public override Task<CountResult> Count(Empty request, ServerCallContext context)
        {
            return Task.FromResult(new CountResult
            {
                Count = "1"
            });
        }
        
    }
}
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var channel = GrpcChannel.ForAddress("https://localhost:5001"))
            {
                var client = new GrpcServiceDemo.Greeter.GreeterClient(channel);

                var request = new GrpcServiceDemo.HelloRequest()
                {
                    Name = "Mr Grpc"
                };

                var response = await client.SayHelloAsync(request);
                Console.WriteLine(response.Message);
            }
            Console.ReadLine();
        }
    }
}

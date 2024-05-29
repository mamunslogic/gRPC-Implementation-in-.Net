using Grpc.Net.Client;
using GrpcServer.Protos;

GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:7068");
Tweeter.TweeterClient client = new(channel);

var request = new TweetRequest { Message = "Hi" };
var reply = await client.SendTweetAsync(request);

Console.WriteLine($"Request from client: {request.Message}");
Console.WriteLine($"Response from server: {reply.Message}");
Console.ReadLine();
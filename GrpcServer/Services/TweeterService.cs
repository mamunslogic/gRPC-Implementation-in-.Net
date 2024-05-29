using Grpc.Core;
using GrpcServer.Protos;

namespace GrpcServer.Services
{
    public class TweeterService : Tweeter.TweeterBase
    {
        public override Task<TweetReply> SendTweet(TweetRequest request, ServerCallContext context)
        {
            return Task.FromResult(new TweetReply { Message= "Hello. I think you are doing well."});
        }
    }
}

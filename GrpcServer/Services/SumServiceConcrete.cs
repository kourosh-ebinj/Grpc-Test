using Grpc.Core;
using MyGrpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MyGrpc.SumService;

namespace WebServices.Services
{
    public class SumServiceConcrete : SumServiceBase
    {
        private static int Sum;
        public override Task<SumResponse> CalculateSum(SumRequest request, ServerCallContext context)
        {
            return Task.Run(() => new SumResponse()
            {
                Result = request.First + request.Second
            });
        }
        public async override Task CalculateManyTimeSum(SumRequest request, IServerStreamWriter<SumResponse> responseStream, ServerCallContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(500);

                Sum = Sum + (request.First + request.Second);
                await responseStream.WriteAsync(
                    new SumResponse() { Result = Sum });
            }
        }
    }
}

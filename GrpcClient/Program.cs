using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using MyGrpc;
using Deltaban.Grpc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Net.Http;

namespace GrpcClient
{
    public class Program
    {

        static async Task Main(string[] args)
        {
            string target = "https://127.0.0.1:5501";
            var httpHandler = new HttpClientHandler();
            // Always return `true` to allow certificates that are untrusted/invalid
            httpHandler.ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            using var channel = GrpcChannel.ForAddress(target, new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new SumService.SumServiceClient(channel);
            Console.Write("First Number: ");
            var first = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            var second = int.Parse(Console.ReadLine());

            var req = new SumRequest() { First = first, Second = second };
            //var resp = client.CalculateSum(req);
            //Console.WriteLine(resp.Result);

            var resp = client.CalculateManyTimeSum(req);
            while (await resp.ResponseStream.MoveNext())
                   Console.WriteLine(resp.ResponseStream.Current.Result);

            //var client = new SearchService.SearchServiceClient(channel);
            //var req = new SearchRequest() { Message = "input" };
            //var resp = client.Search(req, deadline: DateTime.UtcNow.AddSeconds(30));

            //while (await resp.ResponseStream.MoveNext())
            //    Console.WriteLine("Result is : " + resp.ResponseStream.Current.ServiceData + " @" + DateTime.Now.TimeOfDay.ToString());

            channel.ShutdownAsync().Wait();
            Console.ReadLine();
        }

    }
}


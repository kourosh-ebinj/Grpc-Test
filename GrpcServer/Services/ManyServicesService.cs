using Deltaban.Grpc;
using Grpc.Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Deltaban.Grpc.SearchService;

namespace WebServices.Services
{
    public class ManyServicesService : SearchServiceBase
    {
        public override async Task Search(SearchRequest request, IServerStreamWriter<SearchResponse> responseStream, ServerCallContext context)
        {
            var tasks = new List<Task<string>>();
            tasks.Add(GetFirstMethod());
            tasks.Add(GetSecondMethod());
            tasks.Add(GetThirdMethod());
            while (tasks.Any())
            {
                var completed = await Task.WhenAny(tasks);
                tasks.Remove(completed);
                await responseStream.WriteAsync(new SearchResponse() { ServiceData = await completed });
            }
        }
        public async Task<string> GetFirstMethod()
        {
            Console.WriteLine("1 running ... " + DateTime.Now.TimeOfDay.ToString());
            //await Task.Run(async () => { await Task.Delay(delay); });

            //    Console.WriteLine("1 running after delay ... " + DateTime.Now.TimeOfDay.ToString());
            //    return $"After {delay / 1000} second";

            var client = new RestClient("http://legacyapi.test.speedapp.co/barcode/GeneratePDF");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            // 34 items
            request.AddParameter("application/json", "[{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"11111\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"22222\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"55555\"}\r\n\r\n]\r\n", ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);

            //if (response.StatusCode != System.Net.HttpStatusCode.OK)
            return DateTime.Now.TimeOfDay.ToString() + $". 1 returns {response.StatusDescription}.";
            //return response.Content;
        }

        public async Task<string> GetSecondMethod()
        {
            Console.WriteLine("2 running ... " + DateTime.Now.TimeOfDay.ToString());
            //await Task.Run(async () => { await Task.Delay(delay * 2); });
            //    Console.WriteLine("2 running after delay ... " + DateTime.Now.TimeOfDay.ToString());
            //return $"After {delay * 2 / 1000} second";

            var client = new RestClient("http://legacyapi.test.speedapp.co/barcode/GeneratePDF");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            // 194 items
            request.AddParameter("application/json", "[{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"11111\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"22222\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"33333\"},{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"44444\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"55555\"}\r\n\r\n]\r\n", ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);

            //if (response.StatusCode != System.Net.HttpStatusCode.OK)
            return DateTime.Now.TimeOfDay.ToString() + $". 2 returns {response.StatusDescription}.";
            //return response.Content;
        }

        public async Task<string> GetThirdMethod()
        {
            Console.WriteLine("3 running ... " + DateTime.Now.TimeOfDay.ToString());
            //await Task.Run(async () => { await Task.Delay(delay * 3); });
            //    Console.WriteLine("3 running after delay ... " + DateTime.Now.TimeOfDay.ToString());
            //return $"After {delay * 3 / 1000} second";

            var client = new RestClient("http://legacyapi.test.speedapp.co/barcode/GeneratePDF");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            // 2 items
            request.AddParameter("application/json", "[{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"11111\"},\r\n{\"Label\":\"Mohammad Ghaderi\",\"Value\":\"55555\"}\r\n\r\n]\r\n", ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);

            //if (response.StatusCode != System.Net.HttpStatusCode.OK)
            return DateTime.Now.TimeOfDay.ToString() + $". 3 returns {response.StatusDescription}.";
            //return response.Content;
        }

    }
}

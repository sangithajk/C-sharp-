using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace HttpClientExample
{
    class Program
    {
        static async  Task  Main(string[] args)
        {
            //var HttpClient = HttpClientFactory.Create();
            //var url = "https://jsonplaceholder.typicode.com/todos";
            //var data = await HttpClient.GetStringAsync(url);
            //Console.WriteLine(data);

            var HttpClient = HttpClientFactory.Create();
            var url = "https://jsonplaceholder.typicode.com/todos/1";
            HttpResponseMessage HttpResponse = await HttpClient.GetAsync(url);
            if(HttpResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = HttpResponse.Content;
                //var data = await content.ReadAsStringAsync();
                var data = await content.ReadAsAsync<Data>();
                Console.WriteLine(data);
            }
        }
    }
}

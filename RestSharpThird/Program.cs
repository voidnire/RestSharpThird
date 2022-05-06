using RestSharp;
using System;

namespace RestSharpThird
{
    public class Program //post method
    {
        static async Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            var client = new RestClient(url);
            var request = new RestRequest();
            var body = new Post { body = "bode de testes", title = "test post resquest", userId = 2 };
            request.AddJsonBody(body);
            var resp = await client.PostAsync(request);
            Console.WriteLine(resp.StatusCode.ToString() + "    " + resp.Content.ToString());

            Console.ReadKey();
        }


        public class Post
        {
            public int userId { get; set; }
            public string body { get; set; }
            public string title { get; set; }
        }
    }
}


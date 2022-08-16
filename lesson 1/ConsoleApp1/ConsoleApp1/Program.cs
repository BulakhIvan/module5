using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace lesson_1 
{
    public class Rnd
    {
        public string Message { get; set; }
        public string Status { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SendAsync().GetAwaiter().GetResult();
            Console.Read();
        }

        private async static Task SendAsync()
        {
            using var clientGet1 = new HttpClient();
            HttpResponseMessage resultGet1 = await clientGet1.GetAsync("https://reqres.in/api/users?page=2");

            if (resultGet1.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Ok");
                string content = await resultGet1.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }//1
            using var clientGet2 = new HttpClient();
            HttpResponseMessage resultGet2 = await clientGet2.GetAsync("https://reqres.in/api/users/2");

            if (resultGet2.StatusCode == HttpStatusCode.OK)
            {
                string content = await resultGet2.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }//2

            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/23");
                if (result.StatusCode == HttpStatusCode.NotFound)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }//3
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown");
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }//4
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown/2");
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }//5
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown/23");
                if (result.StatusCode == HttpStatusCode.NotFound)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }//6
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users");
                if (result.StatusCode == HttpStatusCode.Created)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/2");
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }
            // Console.WriteLine("patch update")
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/2");
                if (result.StatusCode == HttpStatusCode.NoContent)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/register");
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/register");
                if (result.StatusCode == HttpStatusCode.BadRequest)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/login");
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/login");
                if (result.StatusCode == HttpStatusCode.BadRequest)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users?delay=3");
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(result.StatusCode);
                    Console.WriteLine(content);
                }

            }
        }
    }
}
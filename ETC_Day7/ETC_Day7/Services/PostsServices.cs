using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ETC_Day7.Services
{
    public class PostsServices
    {
        public async Task<string> GetAllPosts()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync("https://jsonplaceholder.typicode.com/comments");
                    var serverResponse = response.Content.ReadAsStringAsync().Result.ToString();
                    return serverResponse;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    public class PoeConnection
    {
        public HttpClient client { get; set; }

        public PoeConnection()
        {
            this.client = new HttpClient();
        }

        public async Task<League[]> GetLeaguesAsync()
        {
            League[] list = null;
            HttpResponseMessage response = await client.GetAsync("leagues?type=main&compact=1");
            if (response.IsSuccessStatusCode)
            {
                string res = await response.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<League[]>(res);
               
            }
            return list;
        }

        public async Task<League[]> RunAsyncLeagues()
        {
            client.BaseAddress = new Uri("http://api.pathofexile.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            League[] list = null;
            try
            {
                list = await GetLeaguesAsync();
                
            }
            catch (Exception ex)
            {

            }
            return list;
        }

    }
    
}

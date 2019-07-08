using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace POT.Logic
{
    public class NinjaConnection
    {
        public HttpClient client { get; set; }

        public NinjaConnection()
        {
            this.client = new HttpClient();
        }

        public void ShowCurrency(CurrencyOverview currency)
        {
            for (int i = 0; i < currency.lines.Length; i++)
            {
                Console.WriteLine($"CurrencyType: {currency.lines[i].currencyTypeName}");
                Console.WriteLine($"Chaos Equivalent: {currency.lines[i].chaosEquivalent}");
                Console.WriteLine($"Currency Details name: {currency.currencyDetails[i].name}");
                Console.WriteLine(String.Empty.PadRight(79, '*'));
            }
        }

        public async Task<CurrencyOverview> GetProductAsync(string path)
        {
            CurrencyOverview currency = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                // currency = await response.Content.ReadAsAsync<CurrencyOverview>();
                string res = await response.Content.ReadAsStringAsync();
                while (res.IndexOf("null") != -1)
                {
                    res = res.Replace("null", "0.0");
                }
                while (res.IndexOf("\"pay\":0.0") != -1)
                {
                    res = res.Replace("\"pay\":0.0", "\"pay\":null");
                }
                currency = JsonConvert.DeserializeObject<CurrencyOverview>(res);
            }
            return currency;
        }

        public async Task<CurrencyOverview> RunAsync()
        {
            client.BaseAddress = new Uri("https://poe.ninja/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            CurrencyOverview currency = new CurrencyOverview();
            try
            {
                currency = await GetProductAsync("api/data/currencyoverview?league=Legion&type=Currency");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return currency;
        }
    }
}

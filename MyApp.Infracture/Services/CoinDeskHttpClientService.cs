using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infracture.Services
{
    public class CoinDeskHttpClientService(HttpClient httpClient)
    {
        public async Task<CoindeskData> GetDate()
        {
            return await httpClient.GetFromJsonAsync<CoindeskData>("https://jsonplaceholder.typicode.com/todos/1");
        }
    }
}

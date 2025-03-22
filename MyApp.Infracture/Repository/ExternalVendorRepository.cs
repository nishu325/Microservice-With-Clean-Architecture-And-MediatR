using MyApp.Core.Interface;
using MyApp.Core.Models;
using MyApp.Infracture.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infracture.Repository
{
    public class ExternalVendorRepository(CoinDeskHttpClientService coinDeskHttpClient) : IExternalVendorRepository
    {
        public async Task<CoindeskData> GetDate()
        {
            return await coinDeskHttpClient.GetDate();
        }
    }
}

using MyApp.Application;
using MyApp.Core.Models;
using MyApp.Infracture.Services;

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

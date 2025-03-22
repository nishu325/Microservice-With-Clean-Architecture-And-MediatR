using MyApp.Core.Models;

namespace MyApp.Infracture.Services
{
    public interface ICoindeskHttpClientService
    {
        Task<CoindeskData> GetData();
    }
}

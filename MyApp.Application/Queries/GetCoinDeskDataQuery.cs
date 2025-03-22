using MediatR;
using MyApp.Core.Interface;
using MyApp.Core.Models;

namespace MyApp.Application.Queries
{
    public record GetCoinDeskDataQuery() : IRequest<CoindeskData>;
    public class GetCoindeskDataQueryHandler(IExternalVendorRepository externalVendorRepository)
        : IRequestHandler<GetCoinDeskDataQuery, CoindeskData>
    {
        public async Task<CoindeskData> Handle(GetCoinDeskDataQuery request, CancellationToken cancellationToken)
        {
            return await externalVendorRepository.GetDate();
        }
    }

}

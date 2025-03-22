using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Commands
{
    public record DeleteEmployeeCommand(Guid empId) : IRequest<bool>;

    internal class DeleteEmployeeCommandHandler(IEmployeeRepository employee) :IRequestHandler<DeleteEmployeeCommand , bool>
    {
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employee.DeleteEmployeeAsync(request.empId);
        }
    }
    
}

using MediatR;
using MyApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Commands
{
    public record UpdateEmployeeCommand(EmployeeEntity EmployeeEntity): IRequest<EmployeeEntity>;

    public class UpdateEmployeeCommandHelper(IEmployeeRepository employeeRepository) : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand updateEmployeeCommand, CancellationToken cancellationToken)
        {
            return await employeeRepository.UpdateEmployeeAsync(updateEmployeeCommand.EmployeeEntity);
        }
    }
    
}

using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Commands;
using MyApp.Application.Queries;
using MyApp.Core.Entities;


namespace MyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender) : ControllerBase
    {
        // Add new employee data
        [HttpPost("AddNewEmployee")]
        public async Task<IActionResult> AddEmployees([FromBody] EmployeeEntity employee)
        {
            var res = await sender.Send(new AddEmployeeCommand(employee));
            return Ok(res);
        }

        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var res = await sender.Send(new GetAllEmployeesQuery());
            return Ok(res);
        }

        [HttpGet("GetEmployeeById")]
        public async Task<IActionResult> GetEmployeeById(Guid empId)
        {
            var res = await sender.Send(new GetEmployeeByIdQuery(empId));
            return Ok(res);
        }

        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] EmployeeEntity employeeEntity)
        {
            var res = await sender.Send(new UpdateEmployeeCommand(employeeEntity));
            return Ok(res);
        }

        [HttpDelete("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(Guid empId)
        {
            var res = await sender.Send(new DeleteEmployeeCommand(empId));
            return Ok(res);
        }
    }
}

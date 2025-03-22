using Microsoft.EntityFrameworkCore;
using MyApp.Application;
using MyApp.Core.Entities;
using MyApp.Infracture.Data;

namespace MyApp.Infracture.Repository
{
    public class EmployeeRepository (AppDbContext dbContext) : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeEntity>> GetEmployees()
        {
            return await dbContext.Employee.ToListAsync();
        }

        public async Task<EmployeeEntity> GetEmployeeById(Guid id)
        {
            var res = await dbContext.Employee.FirstOrDefaultAsync(x => x.Id == id);
            if(res is not null)
            {
                return res;
            }
            return new EmployeeEntity();
        }

        public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employee)
        {
            employee.Id = Guid.NewGuid();
            dbContext.Employee.Add(employee);

            await dbContext.SaveChangesAsync();

            return employee;
        }

        public async Task<EmployeeEntity> UpdateEmployeeAsync(EmployeeEntity employee)
        {
            var emp = await dbContext.Employee.FirstOrDefaultAsync(x => x.Id == employee.Id);
            if(emp is not null)
            {
                emp.Name = employee.Name;
                emp.Email = employee.Email;
                emp.Phone = employee.Phone;

                await dbContext.SaveChangesAsync();
                return emp;
            }
            return employee;
        }

        public async Task<bool> DeleteEmployeeAsync(Guid id)
        {
            var emp = await dbContext.Employee.FirstOrDefaultAsync(x => x.Id == id);
            if (emp is not null)
            {
                dbContext.Employee.Remove(emp);
                dbContext.SaveChanges();

                return true;
            }

            return false;
        }
    }
}

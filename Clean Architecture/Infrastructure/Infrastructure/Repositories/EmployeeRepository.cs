using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext employeeContext) : base(employeeContext) { }
        public async Task<IEnumerable<Employee>> GetEmployeeByLastName(string lastname)
        {
            return await _employeeContext.Employees.Where(m => m.LastName == lastname).ToListAsync();
        }
    }
}

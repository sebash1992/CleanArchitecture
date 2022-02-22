using Core.Entities;
using Core.Repositories.Base;

namespace Core.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeeByLastName(string lastname);
    }
}

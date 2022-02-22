using Core.Entities;
using MediatR;

namespace Application.Queries
{
    public class GetAllEmployeeQuery : IRequest<List<Employee>>
    {

    }
}

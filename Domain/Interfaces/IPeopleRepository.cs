using Domain.Entities;
using System.Linq;

namespace Domain.Interfaces
{
    public interface IPeopleRepository
    {
        IQueryable<People> Get();
    }
}
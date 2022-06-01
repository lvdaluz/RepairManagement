using Domain.Entities;
using Domain.Interfaces;
using Infra.Contexts;
using System.Linq;

namespace Infra.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly RmContext _context;

        public PeopleRepository(RmContext context)
        {
            _context = context;
        }

        public IQueryable<People> Get() =>
            _context.People;
    }
}
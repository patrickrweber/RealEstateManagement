using RealEstateManagement.Domain.Interfaces.Repositories;
using RealEstateManagement.Domain.Models;
using RealEstateManagement.Infra.Data.Data;


namespace RealEstateManagement.Infra.Data.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        private readonly MySqlContext? _context;
        public PersonRepository(MySqlContext context) : base(context) { _context = context; }
    }
}

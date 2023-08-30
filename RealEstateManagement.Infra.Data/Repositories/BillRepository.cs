using RealEstateManagement.Domain.Interfaces.Repositories;
using RealEstateManagement.Domain.Models;
using RealEstateManagement.Infra.Data.Data;

namespace RealEstateManagement.Infra.Data.Repositories
{
    public class BillRepository : BaseRepository<Bill>, IBillRepository
    {
        private readonly MySqlContext? _context;
        public BillRepository(MySqlContext context) : base(context) { _context = context; }
    }
}

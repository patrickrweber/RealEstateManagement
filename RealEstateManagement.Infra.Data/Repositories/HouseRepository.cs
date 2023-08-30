using RealEstateManagement.Domain.Interfaces.Repositories;
using RealEstateManagement.Domain.Models;
using RealEstateManagement.Infra.Data.Data;

namespace RealEstateManagement.Infra.Data.Repositories
{
    public class HouseRepository : BaseRepository<House>, IHouseRepository
    {
        private readonly MySqlContext? _context;
        public HouseRepository(MySqlContext context) : base(context) { _context = context; }
    }
}

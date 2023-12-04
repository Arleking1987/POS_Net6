using POS.Domain.Entities;
using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;


namespace POS.Infrastructure.Persistences.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly Contexts.POSContext _context;

        public CategoryRepository(Contexts.POSContext context)
        {
            _context = context;
        }
    }
}

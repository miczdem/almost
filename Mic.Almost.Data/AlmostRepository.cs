using System.Data.Entity;
using Mic.Almost.RepositoryInterfaces;

namespace Mic.Almost.Data
{
    public class AlmostRepository : IAlmostRepository
    {
        private IAlmostDbContext _context;

        public IAlmostDbContext Context
        {
            get
            {
                if (_context == null) InitialiseContext();

                return _context;
            }
        }

        private void InitialiseContext()
        {
            Database.SetInitializer(new AlmostDbInitializer());
            _context = new AlmostDbContext();
        }
    }
}
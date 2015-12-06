using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Mic.Almost.BusinessInterfaces;
using Mic.Almost.Domain;
using Mic.Almost.RepositoryInterfaces;

namespace Mic.Almost.Business
{
    public class CustomerManager : ICustomerManager
    {
        private readonly IAlmostRepository _almostRepository;

        public CustomerManager(IAlmostRepository almostRepository )
        {
            _almostRepository = almostRepository;
        }

        public async Task<IList<Customer>> GetCustomersAsync()
        {
            return await _almostRepository.Context.Customers.ToListAsync();
        } 
    }
}

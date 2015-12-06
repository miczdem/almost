using System.Collections.Generic;
using System.Threading.Tasks;
using Mic.Almost.Domain;

namespace Mic.Almost.BusinessInterfaces
{
    public interface ICustomerManager
    {
        Task<IList<Customer>> GetCustomersAsync();
    }
}
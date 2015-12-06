using System.Threading;
using Autofac;
using Mic.Almost.Business;
using Mic.Almost.BusinessInterfaces;
using Mic.Almost.Data;
using Mic.Almost.RepositoryInterfaces;

namespace Mic.Almost.DependencyInjection
{
    public class IoC
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerManager>().As<ICustomerManager>();
            builder.RegisterType<AlmostRepository>().As<IAlmostRepository>();
        }
    }
}

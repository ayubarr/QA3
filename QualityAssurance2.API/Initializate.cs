using AyubArbievQualityAssurance2.Data.Models.Entities;
using QualityAssurance2.Data.Repositories.Implementations;
using QualityAssurance2.Data.Repositories.Interfaces;
using QualityAssurance2.Data.Serveces.Implementations.Service;
using QualityAssurance2.Data.Serveces.Interfaces.ServiceInterfaces;

namespace QualityAssurance2.API
{
    public static  class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
           // services.AddScoped(typeof(IRepository<Client>), typeof(Repository<Client>));
           // services.AddScoped(typeof(IRepository<Order>), typeof(Repository<Order>));
           // services.AddScoped(typeof(IAsyncRepository<Order>), typeof(Repository<Order>));
            services.AddScoped(typeof(IAsyncRepository<Client>), typeof(AsyncRepository<Client>));

            //services.AddScoped<IRepository<Client>, Repository<Client>>();
            //services.AddScoped<IRepository<Order>, Repository<Order>>();

        }
        public static void InitializeServeces(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IClientService), typeof(ClientService));
            //services.AddScoped(typeof(IOrderService), typeof(OrderService));

           // services.AddScoped<IClientService, ClientService>();
          //  services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IAsyncClientService, AsyncClientService>();
            


        }
    }
}

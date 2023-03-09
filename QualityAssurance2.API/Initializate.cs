using AyubArbievQualityAssurance2.Data.Models.Entities;
using QualityAssurance2.Data.Repositories.Implementations;
using QualityAssurance2.Data.Repositories.Interfaces;
using QualityAssurance2.Data.Serveces.Implementations;
using QualityAssurance2.Data.Serveces.Interfaces;

namespace QualityAssurance2.API
{
    public static  class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<Client>), typeof(Repository<Client>));
            services.AddScoped(typeof(IRepository<Order>), typeof(Repository<Order>));
            //services.AddScoped<IRepository<Client>, Repository<Client>>();
            //services.AddScoped<IRepository<Order>, Repository<Order>>();

        }
        public static void InitializeServeces(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseService<Client>), typeof(BaseService<Client>));
            services.AddScoped(typeof(IBaseService<Order>), typeof(BaseService<Order>));
            //services.AddScoped<IBaseService<Client>, BaseService<Client>>();
            //services.AddScoped<IBaseService<Order>, BaseService<Order>>();

        }
    }
}

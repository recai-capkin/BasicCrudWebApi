using CrudApi.DAL.Concrete;
using CrudApi.DAL.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CrudApi.DAL.ServicesConfiguration
{
    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddScoped<IFactoryDal, FactoryDal>();
            serviceDescriptors.AddScoped<IPositionDal, PositionDal>();
            serviceDescriptors.AddScoped<IWorkerDal, WorkerDal>();
        }
    }
}

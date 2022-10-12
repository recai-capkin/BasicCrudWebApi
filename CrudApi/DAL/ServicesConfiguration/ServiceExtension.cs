using CrudApi.DAL.Concrete;
using CrudApi.DAL.Interface;
using CrudApi.SMTP.Interfaces;
using CrudApi.SMTP.Services;
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
            serviceDescriptors.AddScoped<IEmailService, EmailService>();
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Crud_UI.ApiServices.HttpConfiguration
{
    public static class HttpServiceExtension
    {
        private static IConfiguration _Configuration;
        public static void Configure(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }

        public static void AddHttpService(this IServiceCollection services)
        {
            services.AddHttpClient<FactoryApiService>(options =>
            {
                options.BaseAddress = new Uri(_Configuration["FactoryApiAddress"]);
            });
            services.AddHttpClient<WorkerApiService>(options =>
            {
                options.BaseAddress = new Uri(_Configuration["WorkerApiAddress"]);
            });
        }




    }
}

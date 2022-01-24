using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieManagement.Aplication.Common.Interfaces;
using MovieManagement.Infrastructure.ExternalAPI.OMDB;
using MovieManagement.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("OmdbClient", options=>
            {
                options.BaseAddress = new Uri("http://www.omdbapi.com");
                options.Timeout = new TimeSpan(0, 0, 10);
                options.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }).ConfigurePrimaryHttpMessageHandler(sp=> new HttpClientHandler());

            services.AddScoped<IOmdbClient, OmdbClient>();
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IFileStore, FileStore.FileStore>();
            services.AddTransient<IFileWrapper, FileStore.FileWrapper>();
            services.AddTransient<IDirectoryWrapper, FileStore.DirectoryWrapper>();

            return services;
        }
    }
}

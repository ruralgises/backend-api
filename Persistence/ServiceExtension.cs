using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceExtension
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration) {
            var connectionString = configuration.GetConnectionString("db");

            services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));

            services.AddScoped<IRuralPropertiesRepository, RuralPropertiesRepository>();
        }
    }
}

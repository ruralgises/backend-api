using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence
{
    public static class ServiceExtension
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration) {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<InformationDatabaseDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));
            services.AddDbContext<RuralPropertiesDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));
            services.AddDbContext<LocationDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));
            services.AddDbContext<AlertDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));
            services.AddDbContext<ConservationUnitDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));
            services.AddDbContext<DeforestationDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));
            services.AddDbContext<EmbargoDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));
            services.AddDbContext<IndigenouslandsContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));
            services.AddDbContext<QuilombolaAreaDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));
            services.AddDbContext<SettlementsDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));
            services.AddDbContext<UseCoverageDbContext>(opt => opt.UseNpgsql(connectionString, x => x.UseNetTopologySuite()));

            services.AddScoped<IInformationDatabaseRepository, InformationDatabaseRepository>();
            services.AddScoped<IDeforestationsRepository, DeforestationRepository>();
            services.AddScoped<IEmbargoesRepository, EmbagosRepository>();
            services.AddScoped<IQuilombolaAreasRepository, QuilombolaAreasRepository>();
            services.AddScoped<ISettlementsRepository, SettlementsRepository>();
            services.AddScoped<IAlertRepository, AlertRepository>();
            services.AddScoped<IConservationUnitsRepository, ConservationUnitRepository>();
            services.AddScoped<IMunicipalitiesRepository, MunicipalitiesRepository>();
            services.AddScoped<IMicroregionRepository, MicroregionsRepository>();
            services.AddScoped<IMessoreionRepository, MessoreionsRepository>();
            services.AddScoped<ILocationsRepository, LocationsRepository>();
            services.AddScoped<IUseCoverageRepository, UseCoverageRepository>();
            services.AddScoped<IIndigenouslandsRepository, IndigenouslandsRepository>();
            services.AddScoped<IRuralPropertiesRepository, RuralPropertiesRepository>();
        }
    }
}

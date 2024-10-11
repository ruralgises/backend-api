using Application.DTOs.Response;
using Application.Mappers;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class MapperExtension
    {
        public static void ConfigureMapper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<BaseMapper<Alert, AlertResponse>, AlertMapper>();
            services.AddSingleton<BaseMapper<ConservationUnit, ConservationUnitResponse>, ConservationUnitMapper>();
            services.AddSingleton<BaseMapper<Deforestation, DeforestationResponse>, DeforestationMapper>();
            services.AddSingleton<BaseMapper<Embargo, EmbargoResponse>, EmbargoMapper>();
            services.AddSingleton<BaseMapper<QuilombolaArea, QuilombolaAreaResponse>, QuilombolaAreaMapper>();
            services.AddSingleton<BaseMapper<Settlement, SettlementResponse>, SettlementMapper>();
            services.AddSingleton<BaseMapper<UseCoverage, UseCoverageResponse>, UseCoverageMapper>();
        }
    }
}

using Application.Interfaces.Services;
using Application.Services;
using Application.Services.ReportPDF;
using Application.Services.ReportPDF.ReportHandlerFactories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class ServiceExtension
    {
        public static void ConfigureApp(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IInformationDatabaseService, InformationDatabaseService>();

            services.AddTransient<IAlertService, AlertService>();
            services.AddTransient<IIndigenouslandsService, IndigenouslandsService>();
            services.AddTransient<IUseCoverageService, UseCoverageService>();
            services.AddTransient<IConservationUnitService, ConservationUnitService>();
            services.AddTransient<IDeforestationService, DeforestationService>();
            services.AddTransient<IEmbargoService, EmbargoService>();
            services.AddTransient<IQuilombolaAreaService, QuilombolaAreaService>();
            services.AddTransient<ISettlementService, SettlementService>();
            services.AddTransient<ILocationService, LocationService>();
            services.AddTransient<IRuralPropertyMinimumService, RuralPropertyMinimumService>();
            
            services.AddTransient<IRuralPropertyService, RuralPropertyService>();

            services.AddTransient<IReportHandlerFactory, ReportHandlerFactory>();
            services.AddTransient<IReportPDF, ReportPDF>(provider =>
            {
                var factory = provider.GetRequiredService<IReportHandlerFactory>();
                return new ReportPDF(factory.Create());
            });
            services.AddTransient<IReportPDFService, ReportPDFService>();
        }
    }
}

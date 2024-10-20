using Application.Services.ReportPDF.ReportHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.ReportPDF.ReportHandlerFactories;

public class ReportHandlerFactory : IReportHandlerFactory
{
    public IReportHandler Create()
    {
        var header = new HeaderHandler();
        var sicar = new RuralPropertyHandler();
        var ibge = new LocationHandler();
        var cnuc = new ConservationUnitHandler();
        var incra = new QuilombolaAreaHandler();
        var incra2 = new SettlementHandler();
        var funai = new IndigenouslandsHandler();
        var mapbioma = new UseCoverageHandler();
        var mapbioma2 = new AlertHandler();
        var inpe = new DeforestationHandler();
        var ibma = new EmbargoHandler();
        
        header.SetNext(sicar);
        sicar.SetNext(ibge);
        ibge.SetNext(cnuc);
        cnuc.SetNext(incra);
        incra.SetNext(incra2);
        incra2.SetNext(funai);
        funai.SetNext(mapbioma);
        mapbioma.SetNext(inpe);
        inpe.SetNext(ibma);
        ibma.SetNext(mapbioma2);

        return header;
    }
}
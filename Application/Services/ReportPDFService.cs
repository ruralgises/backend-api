using Application.DTOs.Request;
using Application.Interfaces.Services;
using Application.Services.ReportPDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReportPDFService : IReportPDFService
    {
        private readonly IReportPDF _reportPDF;
        private readonly IRuralPropertyService _propertyService;

        public ReportPDFService(IReportPDF reportPDF, IRuralPropertyService propertyService)
        {
            _reportPDF = reportPDF;
            _propertyService = propertyService;
        }

        public async Task<byte[]?> GetReportPDF(GetByCodeRuralPropretiesRequest CAR, CancellationToken cancellationToken)
        {
            var ruralPropert = await _propertyService.GetByCode(CAR, cancellationToken);

            if (ruralPropert == null)
            {
                return null;
            }

            return _reportPDF.Compose(ruralPropert);
        }
    }
}

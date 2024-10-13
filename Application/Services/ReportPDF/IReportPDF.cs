using Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ReportPDF
{
    public interface IReportPDF
    {
        public byte[] Compose(RuralPropertyResponse ruralProperty);
    }
}

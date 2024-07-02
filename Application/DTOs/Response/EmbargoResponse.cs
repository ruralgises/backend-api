using Application.DTOs.Response.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class EmbargoResponse : GeoSpatialBaseIntersectionResponse
    {
        public string IdentificationEmbargoTerm { get; init; } = string.Empty;
        public DateOnly EmbargoIssuanceDate { get; init; }
        public string NameEmbargoed { get; init; } = string.Empty;
        public string CPF_CNPJ { get; init; } = string.Empty;
        public string AdministrativeProcessNumber { get; init; } = string.Empty;
        public string TotalEmbargoArea { get; init; } = string.Empty;
        public string InflationActNumber { get; init; } = string.Empty;
        public string InfractionDescription { get; init; } = string.Empty;
        public string Status { get; init; } = string.Empty;
        public DateOnly RegistrationDate { get; init; }
        public string Legislation { get; init; } = string.Empty;
        public string Article { get; init; } = string.Empty;
    }
}

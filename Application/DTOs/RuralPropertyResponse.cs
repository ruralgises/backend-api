using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class RuralPropertyResponse
    {
        public string ThemeName { get; init; } = string.Empty;
        public string Code { get; init; } = string.Empty;
        public double AreaHa { get; init; }
        public string Status { get; init; } = string.Empty;
        public string Type { get; init; } = string.Empty;
        public string Condition { get; init; } = string.Empty;
        public Location? Location { get; init; }
        public IList<ConservationUnit> ConservationUnits { get; init; } = new List<ConservationUnit>();
        public IList<Deforestation> Deforestations { get; init; } = new List<Deforestation>();
        public IList<Embargo> Embargoes { get; init; } = new List<Embargo>();
        
        public IList<QuilombolaAreaResponse> QuilombolaAreas { get; init; } = new List<QuilombolaAreaResponse>();
        public IList<Settlement> Settlements { get; init; } = new List<Settlement>();
    }
}

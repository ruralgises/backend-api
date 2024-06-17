using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class RuralPropertyMapper
    {
        public static RuralPropertyResponse MapToResponse(this RuralProperty ruralPropertie)
        {
            return new RuralPropertyResponse
            {
                ThemeName = ruralPropertie.ThemeName,
                Code = ruralPropertie.Code,
                AreaHa = ruralPropertie.AreaHa,
                Status = ruralPropertie.Status,
                Type = ruralPropertie.Type,
                Condition = ruralPropertie.Condition,
                ConservationUnits = new List<ConservationUnit>(),
                Deforestations = new List<Deforestation>(),
                Embargoes = new List<Embargo>(),
                QuilombolaAreas = new List<QuilombolaArea>(),
                Settlements = new List<Settlement>(),
            };
        }
    }
}

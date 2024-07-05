using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class UseCoverageMapper
    {
        public static UseCoverageResponse ToResponse(UseCoverage useCoverage)
        {
            return new UseCoverageResponse()
            {
                Class = useCoverage.Class,
                AreaIntersectHa = useCoverage.AreaIntersectHa,
                Name = useCoverage.Name,
            };
        }


        public static IList<UseCoverageResponse> ToResponse(IList<UseCoverage> useCoverages)
        {
            IList<UseCoverageResponse> useCoverageResponses = new List<UseCoverageResponse>();

            foreach (var item in useCoverages)
            {
                useCoverageResponses.Add(ToResponse(item));
            }

            return useCoverageResponses;
        }
    }
}

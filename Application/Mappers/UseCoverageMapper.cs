using Application.DTOs.Response;
using Domain.Entities;

namespace Application.Mappers
{
    public class UseCoverageMapper : BaseMapper<UseCoverage, UseCoverageResponse>
    {
        public override UseCoverageResponse ToResponse(UseCoverage useCoverage)  
        {
            return new UseCoverageResponse()
            {
                Class = useCoverage.Class,
                AreaIntersectHa = useCoverage.AreaIntersectHa,
                Name = useCoverage.Name,
            };
        }
    }
}

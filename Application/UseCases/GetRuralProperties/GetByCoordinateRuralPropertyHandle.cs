using Application.DTOs;
using Application.Mappers;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.GetRuralProperties
{
    public class GetByCoordinateRuralPropertyHandle
    {
        private readonly IRuralPropertiesRepository repository;
        public GetByCoordinateRuralPropertyHandle(IRuralPropertiesRepository ruralPropertieRepository)
        {
            repository = ruralPropertieRepository;
        }

        public async Task<IList<RuralPropertyResponse>> Handle(GetByCoordinateRuralPropretiesRequest request, CancellationToken cancellationToken)
        {
            var ruralProperties = await repository.GetByCoordinate(request.Coordinate!, request.Skip, request.Take, cancellationToken);

            var response = new List<RuralPropertyResponse>();

            foreach (var rp in ruralProperties)
            {
                response.Add(rp.MapToResponse());
            }

            return response;
        }
    }
}

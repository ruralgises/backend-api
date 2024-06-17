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
    public class GetByCodeRuralPropertyHandle
    {
        private readonly IRuralPropertiesRepository repository;
        public GetByCodeRuralPropertyHandle(IRuralPropertiesRepository ruralPropertieRepository)
        {
            repository = ruralPropertieRepository;
        }

        public async Task<IList<RuralPropertyResponse>> Handle(GetByCodeRuralPropretiesRequest request, CancellationToken cancellationToken)
        {
            var ruralProperties = await repository.GetByCode(request.Code!, request.Skip, request.Take, cancellationToken);
            var response = new List<RuralPropertyResponse>();

            foreach (var rp in ruralProperties)
            {
                response.Add(rp.MapToResponse());
            }

            return response;
        }
    }
}

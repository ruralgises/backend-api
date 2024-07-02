using Application.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class QuilombolaAreaMapper
    {
        public static QuilombolaAreaResponse ToResponse(QuilombolaArea quilombolaArea)
        {
            return new QuilombolaAreaResponse()
            {
                AreaIntersectHa = quilombolaArea.AreaIntersectHa,
                AreaTotalHa = quilombolaArea.AreaTotalHa,
                CommunityName = quilombolaArea.CommunityName,
                DecreeDate = quilombolaArea.DecreeDate,
                FamilyNumber = quilombolaArea.FamilyNumber,
                Phase = quilombolaArea.Phase,
                ProcessNumber = quilombolaArea.ProcessNumber,
                Realm = quilombolaArea.Realm,
                Responsible = quilombolaArea.Responsible,
            };
        }

        public static IList<QuilombolaAreaResponse> ToResponse(IList<QuilombolaArea> quilombolaAreas)
        {
            var response = new List<QuilombolaAreaResponse>();

            foreach(var item in quilombolaAreas)
            {
                response.Add(ToResponse(item));
            }

            return response;
        }
    }
}

using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Domain.Entities;
using Domain.Entities.BasesEntities;

namespace Application.Mappers
{
    public abstract class BaseMapper<Rq, Rp>
    {
        public abstract Rp ToResponse(Rq requisicao);
        public IList<Rp> ToResponses(IList<Rq> requisicao)
        {
            var response = new List<Rp>();

            foreach (var item in requisicao)
            {
                response.Add(ToResponse(item));
            }

            return response;
        }
    }
}

using Domain.Entities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IRuralPropertiesRepository
    {
        Task<IList<RuralProperty>> GetByCode(string code, int? Skip, int? Take, CancellationToken cancellationToken);
        Task<IList<RuralProperty>> GetByCoordinate(Coordinate coordinate, int? Skip, int? Take, CancellationToken cancellationToken);
        public Task<RuralProperty> GetByCode(string code, CancellationToken cancellationToken);
    }
}

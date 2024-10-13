using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RuralPropertiesRepository : IRuralPropertiesRepository
    {
        private readonly RuralPropertiesDbContext _context;

        public RuralPropertiesRepository(RuralPropertiesDbContext context)
        {
            _context = context;
        }

        public async Task<IList<RuralProperty>> GetByCoordinate(Coordinate coordinate, int? Skip, int? Take, CancellationToken cancellationToken)
        {
            var query = _context.RuralProperties.Where(item => item.Geom != null && item.Geom.Intersects(new Point(coordinate)));

            if (Skip.HasValue)
            {
                query = query.Skip(Skip.Value);
            }

            if (Take.HasValue)
            {
                query = query.Take(Take.Value);
            }

            return await query.ToListAsync(cancellationToken);
        }

        public async Task<IList<RuralProperty>> GetByCode(string code, int? Skip, int? Take, CancellationToken cancellationToken)
        {
            var query = _context.RuralProperties.Where(item => item.Code.Contains(code));

            if (Skip.HasValue)
            {
                query = query.Skip(Skip.Value);
            }

            if (Take.HasValue)
            {
                query = query.Take(Take.Value);
            }

            return await query.ToListAsync(cancellationToken);
        }

        public async Task<RuralProperty?> GetByCode(string code, CancellationToken cancellationToken)
        {
            var query = _context.RuralProperties.Where(item => item.Code == code);

            return await query.FirstOrDefaultAsync(cancellationToken);
        }
    }
}

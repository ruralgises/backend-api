using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class LocationsRepository : ILocationsRepository
    {
        private readonly LocationsGeoSpatialBaseRepository<Municipality> _municipalityRepository;
        private readonly IMicroregionRepository _microregionRepository;
        private readonly IMessoreionRepository _messoreionRepository;

        public LocationsRepository(
            LocationsGeoSpatialBaseRepository<Municipality> municipalityRepository, 
            IMicroregionRepository microregionRepository, 
            IMessoreionRepository messoreionRepository)
        {
            _messoreionRepository = messoreionRepository;
            _microregionRepository = microregionRepository;
            _municipalityRepository = municipalityRepository;
        }

        public async Task<Location> GetByGeometry(NetTopologySuite.Geometries.Geometry geometry, CancellationToken cancellationToken)
        {
            var municipalityTask = _municipalityRepository.GetByGeometryQueryable(geometry).FirstOrDefaultAsync(cancellationToken);
            var microregionTask = _microregionRepository.GetByGeometryQueryable(geometry).FirstOrDefaultAsync(cancellationToken);
            var mesoregionTask = _messoreionRepository.GetByGeometryQueryable(geometry).FirstOrDefaultAsync(cancellationToken);

            var municipality = await municipalityTask;
            var microregion = await microregionTask;
            var mesoregion = await mesoregionTask;

            return new Location
            {
                Messorerion = mesoregion,
                Microregion = microregion,
                Municipality = municipality
            };
        }
    }
}

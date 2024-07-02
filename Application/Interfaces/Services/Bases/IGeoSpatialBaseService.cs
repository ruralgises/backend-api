using Application.DTOs.Response.Bases;
using Application.DTOs.Response;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services.Bases
{
    public interface IGeoSpatialBaseService<T> where T : GeoSpatialBaseIntersectionResponse
    {
        public Task<GeoSpatialInformationResponse<T>> GetByGeometry(Geometry geom, CancellationToken cancellationToken);
    }
}

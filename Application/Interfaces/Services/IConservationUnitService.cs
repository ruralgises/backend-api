using Application.DTOs.Response;
using Application.DTOs.Response.Bases;
using Application.Interfaces.Services.Bases;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IConservationUnitService : IGeoSpatialBaseService<ConservationUnitResponse>
    {
    }
}

using Application.DTOs.Response.Bases;
using Application.DTOs.Response;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Services.Bases;

namespace Application.Interfaces.Services
{
    public interface IDeforestationService : IGeoSpatialBaseService<DeforestationResponse>
    {
    }
}

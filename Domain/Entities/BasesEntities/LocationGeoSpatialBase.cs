using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.BasesEntities
{
    public abstract class LocationGeoSpatialBase : GeoSpatialBase
    {
        public string Code { get; private set; } = string.Empty;
        public string Name { get; private set; } = string.Empty;
    }
}

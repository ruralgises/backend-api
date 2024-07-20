using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.BasesEntities
{
    public interface LocationGeoSpatialBase : IGeoSpatialBase
    {
        public string Code { get; init; }
        public string Name { get; init; }
    }
}

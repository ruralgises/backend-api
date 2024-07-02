﻿using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("mesorregioes")]
    public class Messoregion : LocationGeoSpatialBase
    {
        protected Messoregion() { }
    }
}

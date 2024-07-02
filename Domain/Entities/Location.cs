using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public record Location
    {
        public Municipality? Municipality { get; init; }
        public Microregion? Microregion { get; init; }
        public Messoregion? Messorerion { get; init; }

        public Location() { }

        public Location(Municipality? municipality, Microregion? microregion, Messoregion? messorerion)
        {
            Municipality = municipality;
            Microregion = microregion;
            Messorerion = messorerion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Request
{
    public class GetByCodeRuralPropretiesMinimumRequest : GetByCodeRuralPropretiesRequest
    {
        public int? Skip { get; set; }
        public int? Take { set; get; }
    }
}

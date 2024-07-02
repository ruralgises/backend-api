using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response
{
    public class MessoregionResponse
    {
        public string Code { get; init; } = string.Empty;
        public string Name { get; init; } = string.Empty;
    }
}

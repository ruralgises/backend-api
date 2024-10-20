using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Request
{
    public class GetByCodeRuralPropretiesMinimumRequest
    {
        [Required]
        [RegularExpression(@"^ES-\d{7}-[0-9A-F]{0,32}$", ErrorMessage = "O formato da string é inválido.")]
        [StringLength(43, MinimumLength = 12, ErrorMessage = "A string deve ter entre 12 e 43 caracteres com os caracteres de separação.")]
        public string Code { get; set; }
        public int? Skip { get; set; } = null;
        public int? Take { set; get; } = null;
    }
}

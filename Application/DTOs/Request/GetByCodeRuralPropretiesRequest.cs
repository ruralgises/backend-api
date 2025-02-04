using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Request
{
    public class GetByCodeRuralPropretiesRequest
    {
        [Required]
        [RegularExpression(@"^BA-\d{7}-[0-9A-F]{32}$", ErrorMessage = "O formato da string é inválido.")]
        [StringLength(43, MinimumLength = 43, ErrorMessage = "A string deve ter exatamente 43 caracteres.")]
        public string Code { get; set; }
    }
}

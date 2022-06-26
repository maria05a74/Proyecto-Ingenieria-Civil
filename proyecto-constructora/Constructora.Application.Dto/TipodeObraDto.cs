using System.ComponentModel.DataAnnotations;

namespace Constructora.Application.Dto
{
    public class TipodeObraDto
    {
        [Key]
        [Required]
        public int TipodeObraId { get; set; }
        public string Nombre { get; set; }
    }
}

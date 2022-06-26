using System.ComponentModel.DataAnnotations;

namespace Constructora.Application.Dto
{
    public class TipoDeClienteDto
    {
        [Key]
        [Required]
        public int TipoClienteId { get; set; }
        public string Nombre { get; set; }

    }
}

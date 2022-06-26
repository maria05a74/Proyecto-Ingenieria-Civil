using System.ComponentModel.DataAnnotations;

namespace Constructora.Application.Dto
{
    public class DepartamentoDto
    {
        [Required]
        [Key]
        public int DepartamentoId { get; set; }

        public string Nombre { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Constructora.Application.Dto
{
    public class CiudadDto
    {
        [Required]
        [Key]
        public int CiudadId { get; set; }

        public string Nombre { get; set; }
        public DepartamentoDto Departamento { get; set; }
        public int DepartamentoId { get; set; }
    }
}

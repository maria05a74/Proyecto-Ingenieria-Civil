using System.ComponentModel.DataAnnotations;

namespace Constructora.Application.Dto
{
    public class ProyectoDto
    {
        [Key]
        [Required]
        public int ProyectoId { get; set; }
        public int NroContrato { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        [Required]
        public CiudadDto Ciudad { get; set; }

        [Required]
        public int CiudadId { get; set; }

        [Required]
        public int TipoObraId { get; set; }

        [Required]
        public TipodeObraDto TipoObra { get; set; } = default!;

        public int Valor { get; set; }
    }
}

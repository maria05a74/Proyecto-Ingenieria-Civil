using System.ComponentModel.DataAnnotations;

namespace proyecto_constructora_web.Model
{
    public class Proyecto
    {
        [Key]
        [Required]
        public int ProyectoId { get; set; }
        public int NroContrato { get; set; }
        public string Nombre { get; set; }
        [Required]
        public Ciudad Ciudad { get; set; }
        [Required]
        public int CiudadId { get; set; }

        [Required]
        public int TipoObraId { get; set; }

        [Required]
        public TipodeObra TipoObra { get; set; } = default!;

        public int Valor { get; set; }
    }
}

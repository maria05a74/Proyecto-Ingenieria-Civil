using System.ComponentModel.DataAnnotations;

namespace proyecto_constructora_web.Model
{
    public class TipodeObra
    {
        [Key]
        [Required]
        public int TipodeObraId { get; set; }
        public string Nombre { get; set; }
    }
}

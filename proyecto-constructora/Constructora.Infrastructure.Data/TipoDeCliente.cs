using System.ComponentModel.DataAnnotations;

namespace proyecto_constructora_web.Model
{
    public class TipoDeCliente
    {
        [Key]
        [Required]
        public int TipoClienteId { get; set; }
        public string Nombre { get; set; }   

    }
}

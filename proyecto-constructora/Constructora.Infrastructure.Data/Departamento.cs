using System.ComponentModel.DataAnnotations;

namespace proyecto_constructora_web.Model
{
    public class Departamento
    {
        [Required]
        [Key]
        public int DepartamentoId { get; set; }

        public string Nombre { get; set; }
    }
}

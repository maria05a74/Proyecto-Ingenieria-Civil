using System.ComponentModel.DataAnnotations;

namespace proyecto_constructora_web.Model
{
    public class Ciudad
    {
        [Required]
        [Key]
        public int CiudadId { get; set; }

        public string Nombre { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
    }
}

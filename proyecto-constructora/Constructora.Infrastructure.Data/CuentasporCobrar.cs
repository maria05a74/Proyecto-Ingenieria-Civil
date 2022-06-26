using System.ComponentModel.DataAnnotations;

namespace proyecto_constructora_web.Model
{
    public class CuentasporCobrar
    {
        [Key]
        [Required]
        public int CuentasporCobrarId { get; set; }
        public int Contrato { get; set; }
        public int Obra { get; set; }
        public int Valor { get; set; }

        public string Nombre  { get; set; }
        public string  Apellidos { get; set; }
       
        public int Abono { get; set; }
        public int Saldo { get; set; }
    }
}

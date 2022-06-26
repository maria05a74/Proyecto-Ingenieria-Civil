using System.ComponentModel.DataAnnotations;

namespace Constructora.Application.Dto
{
    public class CuentasporCobrarDto
    {
        [Key]
        [Required]
        public int CuentasporCobrarId { get; set; }
        public int Contrato { get; set; }
        public int Obra { get; set; }
        public int Valor { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public int Abono { get; set; }
        public int Saldo { get; set; }
    }
}

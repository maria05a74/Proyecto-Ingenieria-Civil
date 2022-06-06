using Microsoft.EntityFrameworkCore;

namespace proyecto_constructora_web.Model
{
    public class ConstructoraDbcontex : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Proyecto> proyectos { get; set; }
        public DbSet<TipoDeCliente> tipoClientes { get; set; }
        public DbSet<TipodeObra> tipoObra { get; set; }
        public DbSet<CuentasporCobrar> cuentasporCobrar { get; set; }
        public DbSet<Departamento> departamentos { get; set; }
        public DbSet<Ciudad> ciudades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LV3F03K;Initial Catalog=constructora-db;Integrated Security=True;User ID=sa;Password=0918273456;");
    }
}

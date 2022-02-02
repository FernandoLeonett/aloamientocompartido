using System.Data.Entity;




namespace SharedHostApplicacion.Models
{
    public class SharedHouseContext : DbContext
    {
        public SharedHouseContext() : base("conexion") { }



        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<House> Socios { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}

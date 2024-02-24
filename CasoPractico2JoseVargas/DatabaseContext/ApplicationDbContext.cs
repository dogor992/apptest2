using CasoPractico2JoseVargas.Models;
using Microsoft.EntityFrameworkCore;

namespace CasoPractico2JoseVargas.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }

        public virtual DbSet<Persona_Profesor> Personas_Profesor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Persona_Profesor>().HasData(new Persona_Profesor()
            {
                Id = 1,
                Nombre = "Jose",
                Apellidos = "Vargas",
                Edad = 31,
                Cedula = "115180942215",
                Preferencias = "Preferencias uno uno uno"
            });

            modelBuilder.Entity<Persona_Profesor>().HasData(new Persona_Profesor()
            {
                Id = 2,
                Nombre = "Jos",
                Apellidos = "Prado",
                Edad = 26,
                Cedula = "1168409454",
                Preferencias = "Preferencias dos dos dos"
            });
        }
    }
}

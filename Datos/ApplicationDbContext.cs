using MagicVilla_Api.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_Api.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //usar add-migration nombreCuaquiera para crear la migracion del Modelo a la tabla de la base de datos, tambien crear la base de datos
        //update-database ejecutar script anterior
        {

        }

        //definimos los modelos que queremos que se creen como tablas en la base de datos
        public DbSet<Villa> Villas { get; set; }

        /* Agregar valores iniciales a la base de datos, ejecutar con add-migration y update-database      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                    new Villa()
                    {
                        Id = 1,
                        Nombre = "Villa real",
                        Detalle = "Detalle de la villa",
                        ImageUrl = "",
                        Ocupantes = 5,
                        MetrosCuadrados = 50,
                        Tarifa = 200100,
                        Amenida = "",
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now
                    },
                    new Villa()
                    {
                        Id = 2,
                        Nombre = "Villa premiun vista a la playa",
                        Detalle = "Detalle de la villa",
                        ImageUrl = "",
                        Ocupantes = 4,
                        MetrosCuadrados = 60,
                        Tarifa = 500000,
                        Amenida = "",
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now
                    }
                );
        }
        */

    }
}

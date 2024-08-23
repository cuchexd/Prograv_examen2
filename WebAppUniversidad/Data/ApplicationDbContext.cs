using WebAppUniversidad.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAppUniversidad.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public bool VerificarConexion()
        {
            try
            {
                // Intenta abrir la conexión
                Database.OpenConnection();
                // Cierra la conexión si se abrió correctamente
                Database.CloseConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    } // Llave de cierre para la clase 'ApplicationDbContext'
} // Llave de cierre para el namespace 'WebAppUniversidad.Data'

namespace WebAppUniversidad.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;  // Inicializa con valor vacío
        public string Apellido { get; set; } = string.Empty;  // Inicializa con valor vacío
        public int Edad { get; set; }
        public string Correo { get; set; } = string.Empty;  // Inicializa con valor vacío
    }
}

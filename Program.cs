using cuartopunto;

class Program
{
    static void Main(string[] args)
    {
        Publicacion publicacion = Publicacion.CrearPublicacion();

        if (publicacion != null)
        {
            Console.WriteLine("\nDetalles de la publicación:");
            Console.WriteLine("Número de hojas: " + publicacion.NumeroHojas);
            Console.WriteLine("Valor por hoja: " + publicacion.ValorHoja);
            Console.WriteLine("Hojas a color: " + (publicacion.HojasColor ? "Sí" : "No"));
            Console.WriteLine("Título: " + publicacion.Titulo);
            Console.WriteLine("Tipo de portada: " + publicacion.TipoPortada);
            Console.WriteLine("Nombre del autor: " + publicacion.NombreAutor);
            Console.WriteLine("Nombre del periódico: " + publicacion.NombrePeriodico);
            Console.WriteLine("Fecha de publicación: " + publicacion.Fecha);
            Console.WriteLine("Costo total: " + publicacion.CalcularCosto());
        }
        else
        {
            Console.WriteLine("Error: No se pudo crear la publicación.");
        }
    }
}
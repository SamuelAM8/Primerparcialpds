using Primerpuntopds;

class Program
{
    static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        // Llenar la lista de estudiantes (aquí se pueden agregar más estudiantes)
        estudiantes.Add(new Estudiante() { Codigo = 1, Nombre = "Juan", Edad = 20, Genero = 'M', NotaDefinitiva = 3.5 });
        estudiantes.Add(new Estudiante() { Codigo = 2, Nombre = "Maria", Edad = 18, Genero = 'F', NotaDefinitiva = 4.0 });
        estudiantes.Add(new Estudiante() { Codigo = 3, Nombre = "Pedro", Edad = 22, Genero = 'M', NotaDefinitiva = 3.0 });

        // Promedio de edad
        double promedioEdad = estudiantes.Average(e => e.Edad);
        Console.WriteLine("Promedio de edad: " + promedioEdad);

        // Cuántos son menores de edad
        int menoresEdad = estudiantes.Count(e => e.Edad < 18);
        Console.WriteLine("Cantidad de estudiantes menores de edad: " + menoresEdad);

        // Cuántos son mayores de edad
        int mayoresEdad = estudiantes.Count(e => e.Edad >= 18);
        Console.WriteLine("Cantidad de estudiantes mayores de edad: " + mayoresEdad);

        // Edad menor y su nombre
        var estudianteEdadMinima = estudiantes.OrderBy(e => e.Edad).First();
        Console.WriteLine("Edad menor: " + estudianteEdadMinima.Edad + ", Nombre: " + estudianteEdadMinima.Nombre);

        // Edad mayor, género y nota definitiva
        var estudianteEdadMaxima = estudiantes.OrderByDescending(e => e.Edad).First();
        Console.WriteLine("Edad mayor: " + estudianteEdadMaxima.Edad + ", Género: " + estudianteEdadMaxima.Genero + ", Nota definitiva: " + estudianteEdadMaxima.NotaDefinitiva);

        // Promedio de notas de hombres y mujeres
        double promedioNotasHombres = estudiantes.Where(e => e.Genero == 'M').Average(e => e.NotaDefinitiva);
        Console.WriteLine("Promedio de notas de hombres: " + promedioNotasHombres);

        double promedioNotasMujeres = estudiantes.Where(e => e.Genero == 'F').Average(e => e.NotaDefinitiva);
        Console.WriteLine("Promedio de notas de mujeres: " + promedioNotasMujeres);
    }
}

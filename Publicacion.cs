using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuartopunto
{
    internal class Publicacion
    {
        public int NumeroHojas { get; set; }
        public double ValorHoja { get; set; }
        public bool HojasColor { get; set; }
        public string Titulo { get; set; }
        public string TipoPortada { get; set; }
        public string NombreAutor { get; set; }
        public string NombrePeriodico { get; set; }
        public string Fecha { get; set; }

        public Publicacion(int numeroHojas, double valorHoja, bool hojasColor, string titulo, string tipoPortada, string nombreAutor, string nombrePeriodico, string fecha)
        {
            NumeroHojas = numeroHojas;
            ValorHoja = valorHoja;
            HojasColor = hojasColor;
            Titulo = titulo;
            TipoPortada = tipoPortada;
            NombreAutor = nombreAutor;
            NombrePeriodico = nombrePeriodico;
            Fecha = fecha;
        }

        public static Publicacion CrearPublicacion()
        {
            Console.Write("Ingrese el tipo de publicación (libro o periodico): ");
            string tipo = Console.ReadLine().ToLower();
            if (tipo != "libro" && tipo != "periodico")
            {
                Console.WriteLine("Tipo de publicación no válido.");
                return null;
            }

            Console.Write("Ingrese el número de hojas: ");
            int numeroHojas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor por hoja: ");
            double valorHoja = double.Parse(Console.ReadLine());
            Console.Write("¿Hojas a color? (si/no): ");
            bool hojasColor = Console.ReadLine().ToLower() == "si";
            Console.Write("Ingrese el título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingrese el tipo de portada (lujo/normal/economica): ");
            string tipoPortada = Console.ReadLine();
            Console.Write("Ingrese el nombre del autor: ");
            string nombreAutor = Console.ReadLine();
            Console.Write("Ingrese el nombre del periódico: ");
            string nombrePeriodico = Console.ReadLine();
            Console.Write("Ingrese la fecha de publicación dd/mm/aa: ");
            string fecha = Console.ReadLine();

            if (tipo == "libro")
            {
                return new Libro(numeroHojas, valorHoja, hojasColor, titulo, tipoPortada, nombreAutor, nombrePeriodico, fecha);
            }
            else if (tipo == "periodico")
            {
                return new Periodico(numeroHojas, valorHoja, hojasColor, titulo, tipoPortada, nombreAutor, nombrePeriodico, fecha);
            }

            return null;
        }

        public double CalcularCosto()
        {
            double costoTotal = NumeroHojas * ValorHoja;
            if (TipoPortada.ToLower() == "lujo")
            {
                costoTotal += 12000;
            }
            else if (TipoPortada.ToLower() == "normal")
            {
                costoTotal += 7000;
            }
            else if (TipoPortada.ToLower() == "economica")
            {
                costoTotal += 4000;
            }
            if (HojasColor)
            {
                costoTotal += 300 * NumeroHojas;
            }
            return costoTotal;
        }
    }

}


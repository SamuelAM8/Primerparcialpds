using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuartopunto
{
    internal class Periodico:Publicacion
    {
            public Periodico(int numeroHojas, double valorHoja, bool hojasColor, string titulo, string tipoPortada, string nombreAutor, string nombrePeriodico, string fecha)
                : base(numeroHojas, valorHoja, hojasColor, titulo, tipoPortada, nombreAutor, nombrePeriodico, fecha)
            {
            }
        }

}


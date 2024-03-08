using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerpunto
{
    internal class Cliente
    {
            public string Nombre { get; set; }
            public string Clave { get; set; }

            public Cliente(string nombre, string clave)
            {
                Nombre = nombre;
                Clave = clave;
            }

            public string IniciarSesion()
            {
                Console.Write("Ingrese su nombre: ");
                string nombreUsuario = Console.ReadLine();
                Console.Write("Ingrese su clave: ");
                string clave = Console.ReadLine();
                return $"Bienvenido, {nombreUsuario}!";
            }
        }
    }


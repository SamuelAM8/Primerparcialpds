using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treepoint
{
    internal class Empleado
    {
        
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public double SalarioBasico { get; set; }
            public int HorasExtras { get; set; }
            public double Deduccion { get; set; }
            public double Bonificacion { get; set; }

            public Empleado(string codigo, string nombre, double salarioBasico, int horasExtras = 0, double deduccion = 0, double bonificacion = 0)
            {
                Codigo = codigo;
                Nombre = nombre;
                SalarioBasico = salarioBasico;
                HorasExtras = horasExtras;
                Deduccion = deduccion;
                Bonificacion = bonificacion;
            }

            public double CalcularSalarioTotal()
            {
                double salarioTotal = SalarioBasico + (SalarioBasico * 0.5 * HorasExtras);
                salarioTotal -= Deduccion;
                salarioTotal += Bonificacion;
                double deduccionSalud = SalarioBasico * 0.07;
                double deduccionPension = SalarioBasico * 0.07;
                salarioTotal -= deduccionSalud;
                salarioTotal -= deduccionPension;
                return salarioTotal;
            }

            public override string ToString()
            {
                return $"Código: {Codigo}, Nombre: {Nombre}, Salario Total: {CalcularSalarioTotal()}";
            }
        }
    }


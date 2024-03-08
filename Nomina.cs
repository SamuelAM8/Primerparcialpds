using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treepoint
{
    internal class Nomina
    {
        
    private List<Empleado> empleados;

        public Nomina()
        {
            empleados = new List<Empleado>();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public void ModificarSalarioBasico(string codigo, double nuevoSalario)
        {
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Codigo == codigo)
                {
                    empleado.SalarioBasico = nuevoSalario;
                    Console.WriteLine("Salario básico modificado con éxito.");
                    return;
                }
            }
            Console.WriteLine("No se encontró ningún empleado con ese código.");
        }

        public void IngresarHorasExtras(string codigo, int horasExtras)
        {
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Codigo == codigo)
                {
                    empleado.HorasExtras = horasExtras;
                    Console.WriteLine("Horas extras ingresadas con éxito.");
                    return;
                }
            }
            Console.WriteLine("No se encontró ningún empleado con ese código.");
        }

        public void IngresarDeduccionBonificacion(string codigo, double deduccion, double bonificacion)
        {
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Codigo == codigo)
                {
                    empleado.Deduccion = deduccion;
                    empleado.Bonificacion = bonificacion;
                    Console.WriteLine("Deducción y bonificación ingresadas con éxito.");
                    return;
                }
            }
            Console.WriteLine("No se encontró ningún empleado con ese código.");
        }

        public void ObtenerPlanillaPagos()
        {
            Console.WriteLine("Planilla de Pagos:");
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine(empleado);
            }
        }
    }

}


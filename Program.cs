
namespace treepoint
{
    class Program
    {
        static void MostrarMenu()
        {
            Console.WriteLine("1. Modificar salario básico mensual");
            Console.WriteLine("2. Ingresar cantidad de horas extras");
            Console.WriteLine("3. Ingresar deducción y bonificación");
            Console.WriteLine("4. Obtener planilla de pagos");
            Console.WriteLine("5. Salir");
        }

        static void Main(string[] args)
        {
            Nomina nomina = new Nomina();

            // Ejemplo de creación de empleados
            nomina.AgregarEmpleado(new Empleado("001", "Juan", 2000));
            nomina.AgregarEmpleado(new Empleado("002", "María", 2500));

            while (true)
            {
                MostrarMenu();
                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el código del empleado: ");
                        string codigo1 = Console.ReadLine();
                        Console.Write("Ingrese el nuevo salario básico: ");
                        double nuevoSalario = Convert.ToDouble(Console.ReadLine());
                        nomina.ModificarSalarioBasico(codigo1, nuevoSalario);
                        break;
                    case "2":
                        Console.Write("Ingrese el código del empleado: ");
                        string codigo2 = Console.ReadLine();
                        Console.Write("Ingrese la cantidad de horas extras: ");
                        int horasExtras = Convert.ToInt32(Console.ReadLine());
                        nomina.IngresarHorasExtras(codigo2, horasExtras);
                        break;
                    case "3":
                        Console.Write("Ingrese el código del empleado: ");
                        string codigo3 = Console.ReadLine();
                        Console.Write("Ingrese la deducción: ");
                        double deduccion = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la bonificación: ");
                        double bonificacion = Convert.ToDouble(Console.ReadLine());
                        nomina.IngresarDeduccionBonificacion(codigo3, deduccion, bonificacion);
                        break;
                    case "4":
                        nomina.ObtenerPlanillaPagos();
                        break;
                    case "5":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }
}
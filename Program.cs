namespace Primerpunto { 
    class Program
    {
        static void Main(string[] args)
        {
            Maquinadecambio cambio = new Maquinadecambio();
            Cliente cliente = new Cliente("", "");

            Console.WriteLine(cliente.IniciarSesion());

            Console.Write("Ingrese la cantidad a cambiar: ");
            int cantidadACambiar = Convert.ToInt32(Console.ReadLine());

            if (cantidadACambiar > 200000)
            {
                Console.WriteLine("La cantidad máxima de dinero a cambiar son $200.000 pesos");
            }
            else
            {
                var resultado = cambio.CambioDeBilletes(cantidadACambiar);
                Console.WriteLine("Billetes de 10000: " + resultado.Item1);
                Console.WriteLine("Billetes de 5000: " + resultado.Item2);
                Console.WriteLine("Billetes de 2000: " + resultado.Item3);
                Console.WriteLine("Billetes de 1000: " + resultado.Item4);
            }
        }
    }
}
    


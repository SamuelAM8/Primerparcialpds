using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerpunto
{
    internal class Maquinadecambio
    {
            public (int, int) CalcularBilletes(int cantidad, int denominacion)
            {
                int billetes = cantidad / denominacion;
                cantidad %= denominacion;
                return (billetes, cantidad);
            }

            public int AjustarValor(int cantidad)
            {
                if (500 <= cantidad && cantidad <= 900)
                {
                    return 1000;
                }
                else if (cantidad <= 499 && cantidad > 0)
                {
                    return 0;
                }
                else
                {
                    return cantidad;
                }
            }

            public (int, int, int, int) CambioDeBilletes(int cantidad)
            {
                var (billetesDe10000, nuevaCantidad) = CalcularBilletes(cantidad, 10000);
                var (billetesDe5000, nuevaCantidad2) = CalcularBilletes(nuevaCantidad, 5000);
                var (billetesDe2000, nuevaCantidad3) = CalcularBilletes(nuevaCantidad2, 2000);

                int cantidadAjustada = AjustarValor(nuevaCantidad3);
                if (cantidadAjustada == 1000)
                {
                    var (billetesDe1000, _) = CalcularBilletes(nuevaCantidad3 + 1000, 1000);
                    return (billetesDe10000, billetesDe5000, billetesDe2000, billetesDe1000);
                }
                else
                {
                    var (billetesDe1000, _) = CalcularBilletes(nuevaCantidad3, 1000);
                    return (billetesDe10000, billetesDe5000, billetesDe2000, billetesDe1000);
                }
            }
        }
    }


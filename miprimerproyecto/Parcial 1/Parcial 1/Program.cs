using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARCIAL 1 Brian David Alvarado Valenzuela, Samuel Antonio Gonzales Rodriguez

            decimal[] desde = { 0.01m, 500.01m, 1000.01m, 2000.01m, 3000.01m, 8000.01m, 18000.01m, 30000.01m, 600000.01m, 100000.01m, 200000.01m, 300000.01m, 400000.01m, 500000.01m, 1000000.01m, };
            decimal[] hasta = { 500m, 1000m, 2000m, 3000m, 6000m, 18000m, 30000m, 60000m, 100000m, 200000m, 300000m, 400000m, 500000m, 1000000m, 99999999m };
            decimal[] precio = { 1.5m, 1.5m, 3m, 6m, 9m, 15m, 39m, 63m, 93m, 125m, 195m, 255m, 300m, 340m, 490m };
            decimal[] adicional = { 0m, 3m, 3m, 3m, 2m, 2m, 2m, 1m, 0.8m, 0.7m, 0.6m, 0.45m, 0.4m, 0.3m, 0.18m };

            Console.Write("Ingrese el monto de la actividad económica: ");
            decimal monto = decimal.Parse(Console.ReadLine());

            decimal impuesto = 0;

            for (int i = 0; i < desde.Length; i++)
            {
                if (monto >= desde[i] && monto <= hasta[i])
                {
                    if (adicional[i] > 0)
                    {
                        decimal diferencia = monto - desde[i];
                        impuesto = (diferencia / 1000) * adicional[i] + precio[i];
                    }
                    else
                    {
                        impuesto = precio[i];
                    }
                    break;
                }
            }

            Console.WriteLine($"El impuesto a pagar es: ${Math.Round(impuesto, 2)}");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadLine();



        }
    }
    }

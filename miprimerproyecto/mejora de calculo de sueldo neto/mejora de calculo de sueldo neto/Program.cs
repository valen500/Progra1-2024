using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mejora_de_calculo_de_sueldo_neto
{
    class Program
    {
        static void Main(string[] args)  {


            // Definir la matriz con los rangos y los porcentajes para el cálculo del ISR
            double[,] matriz = new double[,]
            {
            // {Rango Inferior, Rango Superior, % de ISR, Cuota Fija}
            { 0.01, 472.00, 0, 0 },
            { 472.01, 895.24, 10, 17.67 },
            { 895.25, 2038.10, 20, 60.00 },
            { 2038.11, 999999.99, 30, 288.57 }
            };

            Console.Write("Sueldo: ");
            double sueldo = double.Parse(Console.ReadLine()),
                   afp = sueldo * 6.25 / 100,
                   isss = sueldo * 3 / 100,
                   isr = 0;
            sueldo -= afp;

            // Calcular el ISR basado en la matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (sueldo >= matriz[i, 0] && sueldo <= matriz[i, 1])
                {
                    isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];
                    break; // Salir del bucle una vez que se haya calculado el ISR
                }
            }

            sueldo -= isss;
            sueldo -= isr;

            Console.WriteLine("Sueldo Neto: {0}, AFP: {1}, ISSS: {2}, ISR: {3}", Math.Round(sueldo, 2), Math.Round(afp, 2), Math.Round(isss, 2), Math.Round(isr, 2));
            Console.ReadLine();
        }
    }
}

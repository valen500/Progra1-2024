using System;

namespace miPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uso de matrices. Calcular el sueldo de una persona.
            double[,] matriz = new double[,] {
                {0.01, 472.00, 10, 0},
                {472.01, 895.24, 10, 17.67},
                {895.25, 2038.10, 20, 60.00},
                {2038.11, 9999999, 30, 288.57},
            };

            Console.Write("Sueldo: ");
            double sueldo = double.Parse(Console.ReadLine()),
                   afp = sueldo * 6.25 / 100,
                   isss = sueldo * 3 / 100,
                   isr = 0;

            // Restar AFP e ISSS del salario
            sueldo -= afp;
            sueldo -= isss;

            // Calcular ISR
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (sueldo >= matriz[i, 0] && sueldo <= matriz[i, 1])
                {
                    isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];
                    break;
                }
            }

            // Calcular sueldo neto
            sueldo -= isr;

            // Mostrar resultados
            Console.WriteLine("Sueldo Neto: {0}, AFP: {1}, ISSS: {2}, ISR: {3}",
                              Math.Round(sueldo, 2), Math.Round(afp, 2), Math.Round(isss, 2), Math.Round(isr, 2));
            Console.ReadLine();
        }
    }
}

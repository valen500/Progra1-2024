using System;


namespace CalculoSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matriz que define los rangos y porcentajes de ISR
            double[,] matriz = new double[,]
            {
                {0.01, 487.60, 0, 0},
                {487.61, 642.85, 10, 17.48},
                {642.86, 915.81, 10, 32.70},
                {915.82, 2058.67, 20, 60.00},
                {2058.68, 9999999, 30, 288.57},
            };

            Console.Write("Sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());

            // Cálculo de AFP e ISSS
            double afp = sueldo * 6.25 / 100;
            double isss = sueldo * 3 / 100;

            sueldo -= afp; // Sueldo después de AFP

            double isr = 0;

            // Cálculo de ISR según el rango en la matriz
            for (int i = 0; i < 5; i++)
            {
                if (sueldo >= matriz[i, 0] && sueldo <= matriz[i, 1])
                {
                    isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];
                    break; // Salir del bucle una vez que se haya calculado el ISR
                }
            }

            sueldo -= isss; // Sueldo después de ISSS
            sueldo -= isr;  // Sueldo después de ISR

            // Mostrar los resultados
            Console.WriteLine("Sueldo Neto: {0}, AFP: {1}, ISSS: {2}, ISR: {3}",
                Math.Round(sueldo, 2), Math.Round(afp, 2), Math.Round(isss, 2), Math.Round(isr, 2));

            Console.ReadLine();
        }
    }
}

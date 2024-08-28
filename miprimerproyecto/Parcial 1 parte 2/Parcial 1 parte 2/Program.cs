using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1_parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARCIAL 1 Brian David Alvarado Valenzuela, Samuel Antonio Gonzales Rodriguez
            string[] opciones = new string[]
                   {
                "Pie Cuadrado",
                "Vara Cuadrada",
                "Yarda Cuadrada",
                "Metro Cuadrado",
                "Tareas (El Salvador)",
                "Manzana (El Salvador)",
                "Hectárea"
                   };

            // Factores de conversión a pie cuadrado 
            double[] conversionesAPieCuadrado = new double[]
            {
                1,          // Pie Cuadrado
                8.36,       // Vara Cuadrada
                9,          // Yarda Cuadrada
                10.7639,    // Metro Cuadrado
                4329,       // Tareas (El Salvador)
                69889.9,    // Manzana (El Salvador)
                107639      // Hectárea
            };

            Console.WriteLine("Seleccione la unidad de entrada:");
            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {opciones[i]}");
            }

            int opcion = int.Parse(Console.ReadLine()) - 1;

            if (opcion < 0 || opcion >= opciones.Length)
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            Console.Write($"Ingrese el valor en {opciones[opcion]}: ");
            double valorEntrada = double.Parse(Console.ReadLine());

            // Convertir la unidad de entrada a pies cuadrados
            double valorEnPieCuadrado = valorEntrada * conversionesAPieCuadrado[opcion];

            Console.WriteLine("\nConversiones:");

            // Convertir de pies cuadrados a todas las demás unidades
            for (int i = 0; i < conversionesAPieCuadrado.Length; i++)
            {
                double valorConvertido = valorEnPieCuadrado / conversionesAPieCuadrado[i];
                Console.WriteLine($"{opciones[i]}: {valorConvertido:F4}");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
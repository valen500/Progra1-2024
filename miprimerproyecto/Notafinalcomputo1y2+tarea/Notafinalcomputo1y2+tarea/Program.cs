using System;

namespace Notafinalcomputo1y2_tarea
{
    class Program
    {
        static void Main(string[] args)
        {


            // Ejercicio de obtener la nota final de la materia de Programación I.
            // Cómputo 1
            Console.Write("Lab1 C1: ");
            double lab1_c1 = double.Parse(Console.ReadLine()); //8

            Console.Write("Lab2 C1: ");
            double lab2_c1 = double.Parse(Console.ReadLine()); //9

            Console.Write("Parcial 1 C1: ");
            double parcial1_c1 = double.Parse(Console.ReadLine()); //7

            double c1 = lab1_c1 * 30 / 100 + lab2_c1 * 30 / 100 + parcial1_c1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            // Cómputo 2
            Console.Write("Lab1 C2: ");
            double lab1_c2 = double.Parse(Console.ReadLine()); //8

            Console.Write("Lab2 C2: ");
            double lab2_c2 = double.Parse(Console.ReadLine()); //9

            Console.Write("Parcial 1 C2: ");
            double parcial1_c2 = double.Parse(Console.ReadLine()); //7

            double c2 = lab1_c2 * 30 / 100 + lab2_c2 * 30 / 100 + parcial1_c2 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0}", c2);

            // Calcular la nota final de la materia
            double notaFinal = (c1 + c2) / 2;
            Console.WriteLine("La Nota Final de la materia Programación I es: {0}", notaFinal);

            // Pausa
            Console.ReadLine();
        }
    }
}

﻿using System;

namespace Uso_de_la_estructura_repetitiva_for
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";

            while (continuar == "s")
            {
                Console.Clear(); // Limpiar la consola
                Console.WriteLine("\n\n *** MENU ***");
                Console.WriteLine("1. Promedio Notas");
                Console.WriteLine("2. Promedio Serie Numeros");
                Console.WriteLine("3. Clasificacion Edad");
                Console.WriteLine("4. Tabla Multiplicar");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());

                Console.Clear(); // Limpiar la consola
                switch (opcion)
                {
                    case 1:
                        promedio();
                        break;
                    case 2:
                        promedioSerie();
                        break;
                    case 3:
                        clasificacionEdad();
                        break;
                    case 4:
                        tablaMultiplicar();
                        break;
                    case 5:
                        continuar = "n";
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

                if (continuar == "s")
                {
                    Console.WriteLine("\n¿Desea continuar? (s/n): ");
                    continuar = Console.ReadLine().ToLower();
                }
            }
        }

        static void tablaMultiplicar()
        {
            Console.Write("Tabla: ");
            int ntabla = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", ntabla, i, ntabla * i);
            }
        }

        static void promedio()
        {
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine());

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            Console.Write("Lab1: ");
            lab1 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            lab2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1: ");
            parcial1 = double.Parse(Console.ReadLine());

            double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0}", c2);
        }

        static void promedioSerie()
        {
            int[] serie = new int[] { 5, 4, 6, 8, 9 };
            int suma = 0;

            foreach (int num in serie)
            {
                suma += num;
            }

            decimal prom = (decimal)suma / serie.Length;
            Console.WriteLine("La suma es: {0}, el promedio es: {1}", suma, prom);
        }

        static void clasificacionEdad()
        {
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 0)
            {
                Console.WriteLine("Edad incorrecta.");
            }
            else if (edad <= 2)
            {
                Console.WriteLine("Eres un bebé.");
            }
            else if (edad < 12)
            {
                Console.WriteLine("Eres un niño.");
            }
            else if (edad < 18)
            {
                Console.WriteLine("Eres un adolescente.");
            }
            else if (edad <= 65)
            {
                Console.WriteLine("Bienvenido al mundo de las responsabilidades.");
            }
            else if (edad <= 80)
            {
                Console.WriteLine("Eres un adulto mayor.");
            }
            else
            {
                Console.WriteLine("Larga vida.");
            }
        }
    }
}

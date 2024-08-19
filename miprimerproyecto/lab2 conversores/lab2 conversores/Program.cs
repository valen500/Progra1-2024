using System;
using System.Collections.Generic;


namespace lab2_conversores
{
    class Program
    {
        static void Main(string[] args)
        {
     
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Seleccione la categoría de conversión:");
                    Console.WriteLine("1. Monedas");
                    Console.WriteLine("2. Masa");
                    Console.WriteLine("3. Volumen");
                    Console.WriteLine("4. Longitud");
                    Console.WriteLine("5. Almacenamiento");
                    Console.WriteLine("6. Tiempo");
                    Console.WriteLine("7. Salir");
                    int categoria = int.Parse(Console.ReadLine());

                    if (categoria == 7)
                    {
                        break;
                    }

                    switch (categoria)
                    {
                        case 1:
                            ConvertirMonedas();
                            break;
                        case 2:
                            ConvertirMasa();
                            break;
                        case 3:
                            ConvertirVolumen();
                            break;
                        case 4:
                            ConvertirLongitud();
                            break;
                        case 5:
                            ConvertirAlmacenamiento();
                            break;
                        case 6:
                            ConvertirTiempo();
                            break;
                        default:
                            Console.WriteLine("Categoría no válida.");
                            break;
                    }
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }

            static void ConvertirMonedas()
            {
                var conversiones = new Dictionary<string, double>
            {
                { "Dolar ", 1.0 },
                { "Euro ", 0.85 },
                { "Yen japonés ", 110.0 },
                { "Libra esterlina ", 0.75 },
                { "Dólar australiano ", 1.4 },
                { "Dólar canadiense ", 1.25 },
                { "Franco suizo ", 0.92 },
                { "Yuan chino ", 6.5 },
                { "Corona sueca ", 8.5 },
                { "Dólar neozelandés ", 1.45 }
            };

                Convertir("Monedas", conversiones);
            }

            static void ConvertirMasa()
            {
                var conversiones = new Dictionary<string, double>
            {
                { "Kilogramos", 1.0 },
                { "Gramos", 1000.0 },
                { "Libras", 2.20462 },
                { "Onzas", 35.274 },
                { "Toneladas", 0.001 },
                { "Miligramos", 1000000.0 },
                { "Microgramos", 1000000000.0 },
                { "Stones", 0.157473 },
                { "Quintales", 0.01 },
                { "Quilates", 5000.0 }
            };

                Convertir("Masa", conversiones);
            }

            static void ConvertirVolumen()
            {
                var conversiones = new Dictionary<string, double>
            {
                { "Litros", 1.0 },
                { "Mililitros", 1000.0 },
                { "Galones", 0.264172 },
                { "Pintas", 2.11338 },
                { "Cups", 4.22675 },
                { "Centímetros cúbicos", 1000.0 },
                { "Metros cúbicos", 0.001 },
                { "Onzas líquidas", 33.814 },
                { "Barriles", 0.00838641 },
                { "Cucharadas", 67.628 }
            };

                Convertir("Volumen", conversiones);
            }

            static void ConvertirLongitud()
            {
                var conversiones = new Dictionary<string, double>
            {
                { "Metros", 1.0 },
                { "Kilómetros", 0.001 },
                { "Centímetros", 100.0 },
                { "Milímetros", 1000.0 },
                { "Micrómetros", 1000000.0 },
                { "Nanómetros", 1000000000.0 },
                { "Millas", 0.000621371 },
                { "Yardas", 1.09361 },
                { "Pies", 3.28084 },
                { "Pulgadas", 39.3701 }
            };

                Convertir("Longitud", conversiones);
            }

            static void ConvertirAlmacenamiento()
            {
                var conversiones = new Dictionary<string, double>
            {
                { "Bytes", 1.0 },
                { "Kilobytes", 0.001 },
                { "Megabytes", 0.000001 },
                { "Gigabytes", 0.000000001 },
                { "Terabytes", 0.000000000001 },
                { "Petabytes", 0.000000000000001 },
                { "Bits", 8.0 },
                { "Kibibytes", 0.000976563 },
                { "Mebibytes", 0.000000953674 },
                { "Gibibytes", 0.000000000931323 }
            };

                Convertir("Almacenamiento", conversiones);
            }

            static void ConvertirTiempo()
            {
                var conversiones = new Dictionary<string, double>
            {
                { "Segundos", 1.0 },
                { "Minutos", 1.0 / 60.0 },
                { "Horas", 1.0 / 3600.0 },
                { "Días", 1.0 / 86400.0 },
                { "Semanas", 1.0 / 604800.0 },
                { "Meses", 1.0 / 2628000.0 },
                { "Años", 1.0 / 31536000.0 },
                { "Milisegundos", 1000.0 },
                { "Microsegundos", 1000000.0 },
                { "Nanosegundos", 1000000000.0 }
            };

                Convertir("Tiempo", conversiones);
            }

            static void Convertir(string categoria, Dictionary<string, double> conversiones)
            {
                Console.WriteLine($"\nConversión de {categoria}:");
                Console.WriteLine("Unidades disponibles:");
                int i = 1;
                foreach (var unidad in conversiones.Keys)
                {
                    Console.WriteLine($"{i}. {unidad}");
                    i++;
                }

                Console.Write("\nSeleccione la unidad de origen que desea convertir: ");
                int origen = int.Parse(Console.ReadLine());

                Console.Write("Seleccione la unidad de destino a la cual se hara la conversion: ");
                int destino = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el valor a convertir: ");
                double valor = double.Parse(Console.ReadLine());

                string unidadOrigen = ObtenerUnidad(origen, conversiones);
                string unidadDestino = ObtenerUnidad(destino, conversiones);

                if (unidadOrigen != null && unidadDestino != null)
                {
                    double resultado = valor * conversiones[unidadDestino] / conversiones[unidadOrigen];
                    Console.WriteLine($"\n{valor} {unidadOrigen} = {resultado} {unidadDestino}");
                }
                else
                {
                    Console.WriteLine("Unidades seleccionadas no válidas.");
                }
            }

            static string ObtenerUnidad(int indice, Dictionary<string, double> conversiones)
            {
                int i = 1;
                foreach (var unidad in conversiones.Keys)
                {
                    if (i == indice)
                    {
                        return unidad;
                    }
                    i++;
                }
                return null;

            }
    }
}
         
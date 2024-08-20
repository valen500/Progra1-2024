﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace media_armonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //ejercicio encontrar la media aritmetica y la desviacion tipica y armonica  de una seria de numeros.
            Console.Write("Ingrese la serie de numeros separados por comas: ");
            String serie = Console.ReadLine();
            String[] numeros = serie.Split(',');

            Console.WriteLine("La media aritmetica es: {0}, y la desviacion tipica es: {1}", media(numeros), tipica(numeros));
            Console.WriteLine("La media aritmetica es: {0}, y la desviacion tipica es: {1}, la media armonica es: {2}",
                media(numeros), tipica(numeros), armonica(numeros));

            Console.ReadLine();
        }
   static double tipica(string[] serie)
        {
            tipica = Math.Sqrt(tipica / serie.Length);
            return Math.Round(tipica, 2);
        }
        static double armonica(string[] serie)
        {
            double armonica = 0;
            foreach (string num in serie)
            {
                armonica += (1.0 / double.Parse(num));
            }
            armonica = serie.Length / armonica;
            return Math.Round(armonica, 2);
        }
    }
}
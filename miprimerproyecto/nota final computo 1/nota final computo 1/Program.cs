﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nota_final_computo_1
{
    class Program
    {
        static void Main(string[] args) {


            //ejercicio de obtener la nota final de la materia de Programacion 1
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine()); //8

        Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine()); //9

        Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine()); //7

        // 8*30%= 2.4
        // 9*30%= 2.7
        // 7*40%= 2.8
        //C1    = 7.9

        double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
        Console.WriteLine("La nota de C1 es: {0}", c1);
            //Pausa.
            Console.ReadLine();
        
        }
    }
}

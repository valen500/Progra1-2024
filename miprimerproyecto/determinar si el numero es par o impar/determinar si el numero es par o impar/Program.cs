﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace determinar_si_el_numero_es_par_o_impar
{
    class Program
    {
        static void Main(string[] args) {

            //  determinar si cada numero de la serie es para o impar.
            int[] serie = new int[] { 5, 9, 4, 6, 3, 2 };
            foreach (int num in serie)
            {
                Console.WriteLine("El num {0} es {1}", num, num % 2 == 0 ? "Par" : "Impar");
            }
            Console.ReadLine();
        }
    }
}

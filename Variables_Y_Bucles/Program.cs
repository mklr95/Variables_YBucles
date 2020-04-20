using System;
using System.Collections.Generic;

namespace Variables_Y_Bucles
{
    class Program
    {
        static String nombre = "Marc";
        static String apellido1 = "Llobera";
        static String apellido2 = "Rodríguez";
        static int dia = 2;
        static int mes = 11;
        static int año = 1995;
        const int añobis = 1948;
        const int tiempoañobis = 4;
        
        static void Main(string[] args)
        {
            Console.WriteLine(apellido1 + apellido2 + nombre);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(dia + "/" + mes + "/" + año);

            Console.WriteLine(Environment.NewLine);
            int añosentrebis = (año - añobis) / tiempoañobis;
            Console.WriteLine(añosentrebis + " años bisiestos entre 1948 i año nacimiento");

            Console.WriteLine(Environment.NewLine);
            for(int i = añobis;i<= año; i+=4) {
                Console.WriteLine("Año {0}", i);
            }

            var bisiesto = new List<int>();
            var nobisiesto = new List<int>();
            Console.WriteLine(Environment.NewLine);
            for (int i = añobis; i <= año; i ++)
            {
                bool boolañobis;
                if (IsDivisible(i, 4))
                {
                    boolañobis = true;
                    bisiesto.Add(i);
                }
                else
                {
                    nobisiesto.Add(i);
                    boolañobis = false;
                }
                Console.WriteLine("Año {0} , {1}", i, boolañobis);
            }
            static bool IsDivisible(int x, int n)
            {
                return (x % n) == 0;
            }

            Console.WriteLine(Environment.NewLine);
            String nombrevar;
            nombrevar = nombre + " " + apellido1 + " " + apellido2;
            String añovar = dia.ToString()+"/"+mes.ToString()+"/"+año.ToString();
            if(IsDivisible(año, 4))
            {
                Console.WriteLine(nombrevar);
                Console.WriteLine(añovar);
            }
        }
    }
}

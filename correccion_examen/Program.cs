using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correccion_examen
{
    class Program
    {
        //****************************************************************************************************
        const int MAX = 100;
            
        static void Main(string[] args)
        {
            int[] vector = new int[MAX];
            llenarvector(vector);
            ordenarvector(vector);
            imprimirvector(vector);
            Console.WriteLine("\n\n\nValor Máximo: {0}", vector[0]);
            Console.WriteLine("\nValor Minimo: {0}", vector[MAX-1]);
            Console.WriteLine("\nSumatoria: {0}", sumatoria(vector));
            Console.WriteLine("\nPromedio: {0}", promedio (vector));
            Console.WriteLine("\nTotal Decenas: {0}", contarDecenas(vector));

            Console.WriteLine("\nDesv. Estandar: {0}", desvEstadar(vector));

            Console.ReadKey();
        }

        public static int contarDecenas(int[] x)
        {
            int c = 0;
            for (int i=0;i<MAX;i++)
            {
                if (x[i]>=10 && x[i]<=90)
                {
                    if (x[i] % 10 == 0)
                        c++;
                }
            }
            return c;
        }


        public static int sumatoria (int[]x)
        {
            int suma = 0;
            for (int i = 0; i < MAX; i++)
                suma = suma + x[i];
            return suma;
        }

        public static double promedio (int[]x)
        {
            double suma = sumatoria(x);
            return (suma / MAX);
        }


        public static void llenarvector(int[] x)
        {
            //Creamos un objeto random, simplemente
            Random r = new Random();
            for (int i=0; i<MAX;i++)
            {
                int numero = r.Next(1, 1000); //Número entre 1 - 1000
                x[i] = numero;
            }
        }

        public static void imprimirvector(int []x)
        {
            Console.WriteLine("Elementos del Vector: ");
            for (int i=0; i< MAX;i++)
            {
                Console.Write("{0}  ", x[i]);
            }
        }

        public static void ordenarvector(int[] x)
        {
            int aux = 0;
            for(int i=0; i<MAX;i++)
                for (int j=i+1; j<MAX; j++)
                {
                    if (x[i]<x[j])
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
                }
        }
        //*********************************************************************************************

        public static double desvEstadar(int[] x)
        {
            double res = 0;
            double prom = promedio(x);
            for (int i=0; i<MAX; i++)
            {
                res = res + (x[i] - prom) * (x[i] - prom);
            }
            return Math.Sqrt(res / (MAX - 1));
        }
    }
}

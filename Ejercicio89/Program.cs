using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio89
{
    class Program
    {
        static void Main(string[] args)
        {
            var numerosRandom = new int[100];
            PopulateArray(numerosRandom);
            ShowArray(numerosRandom);
            ShowStatistics(numerosRandom);
        }

        private static void ShowStatistics(int[] numerosRandom)
        {
            var estadisticas = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                estadisticas[i] = ContarNumero(numerosRandom, i);
            }
            Console.WriteLine("Listado Estadístico");
            for (int i = 0; i < estadisticas.Length; i++)
            {
                Console.WriteLine($"Veces que aparece el número {i} es {estadisticas[i]}");
            }
            Console.ReadLine();
        }

        private static int ContarNumero(int[] numerosRandom, int i)
        {
            var resultado = 0;
            foreach (var numero in numerosRandom)
            {
                if (numero==i)
                {
                    resultado++;
                }
            }
            return resultado;
        }

        private static void ShowArray(int[] numerosRandom)
        {
            Console.Clear();
            Console.WriteLine("Listado del Array");
            for (int i = 0; i < numerosRandom.Length/5; i++)
            {
                string linea =
                    $"{numerosRandom[i]} {numerosRandom[i + 20]} {numerosRandom[i + 40]} {numerosRandom[i + 60]} {numerosRandom[i+80]}";
                Console.WriteLine(linea);
            }
            Console.ReadLine();
        }

        private static void PopulateArray(int[] numerosRandom)
        {
            Random r = new Random();
            for (int i = 0; i < numerosRandom.Length; i++)
            {
                numerosRandom[i] = r.Next(0, 10);
            }
        }
    }
}

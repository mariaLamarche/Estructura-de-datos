using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temperaturas = new int[10];
            temperaturas[0] = 30;
            temperaturas[1] = 28;
            temperaturas[2] = 25;
            temperaturas[3] = 27;
            temperaturas[4] = 31;
            temperaturas[5] = 29;
            temperaturas[6] = 26;
            temperaturas[7] = 32;
            temperaturas[8] = 24;
            temperaturas[9] = 30;
            int temperaturaMaxima = temperaturas[0];
            int temperaturaMinima = temperaturas[0];
            int sumaTemperaturas = 0;
            int diasCalurosos = 0;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > temperaturaMaxima)
                {
                    temperaturaMaxima = temperaturas[i];
                }
                else if (temperaturas[i] < temperaturaMinima)
                {
                    temperaturaMinima = temperaturas[i];
                }
                sumaTemperaturas += temperaturas[i];
                if (temperaturas[i] > 30)
                {
                    diasCalurosos++;
                }
            }
            int promedioTemperaturas = sumaTemperaturas / temperaturas.Length;
            Console.WriteLine("Temperatura máxima: " + temperaturaMaxima);
            Console.WriteLine("Temperatura mínima: " + temperaturaMinima);
            Console.WriteLine("Promedio de temperaturas: " + promedioTemperaturas);
            Console.WriteLine("Número de días calurosos: " + diasCalurosos);
            Console.ReadLine();
        }
    }
}

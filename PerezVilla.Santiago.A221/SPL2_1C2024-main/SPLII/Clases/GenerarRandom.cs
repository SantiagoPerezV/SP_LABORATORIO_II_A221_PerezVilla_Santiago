using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class GenerarRandom
    {
        public static int EnteroAleatorio(int minimo, int maximo)
        {
            Random random = new Random();
            return (int)random.Next(minimo, maximo);
        }

        public static double DoubleAleatorio()
        {
            Random random = new Random();
            return (double)random.NextDouble();
        }
    }
}

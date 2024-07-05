using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Taller
    {
        List<Barco> barcos;

        public List<Barco> Barcos { get => barcos;}

        public Taller()
        {
            barcos = new List<Barco>();
        }

        public bool EncontrarBarco(Barco barco)
        {
            bool retorno = false;
            foreach(Barco b in Barcos)
            {
                if (b.CompararBarcos(b, barco))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}

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
                if (b.CompararBarcos(barco))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public void IngresarBarco(Barco barco)
        {
            if(EncontrarBarco(barco) == false)
            {
                Barcos.Add(barco);
            }
        }

        public bool Reparar(Taller taller)
        {
            bool retorno = false;
            foreach (Barco b in Barcos)
            {
                if(b.EstadoReparado == false)
                {
                    b.EstadoReparado = true;
                    retorno = true;
                    //Falta guardar en la BD.
                    if(b is Marina)
                    {
                        Marina m = (Marina)b;
                        m.CalcularCosto();
                    }
                    else
                    {
                        Pirata p = (Pirata)b;
                        p.CalcularCosto();
                    }
                }
            }
            return retorno;
        }

    }
}

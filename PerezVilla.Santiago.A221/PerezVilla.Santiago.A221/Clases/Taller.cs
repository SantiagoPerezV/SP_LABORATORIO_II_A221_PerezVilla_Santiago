using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Excepciones;

namespace Clases
{
    public class Taller
    {
        List<Barco> barcos;

        public List<Barco> Barcos { get => barcos; set => barcos = value; }

        public Taller()
        {
            barcos = new List<Barco>();
        }

        public bool EncontrarBarco(Barco barco)
        {
            bool retorno = false;
            foreach (Barco b in Barcos)
            {
                if (b.CompararBarcos(barco))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public void IngresarBarco(Barco barco)
        {
            if (EncontrarBarco(barco) == false)
            {
                Barcos.Add(barco);
            }
            else
            {
                throw new BarcoEncontradoException($"El barco {barco.Nombre} ya se encuentra en el taller");
            }
        }

        public bool Reparar(Taller taller)
        {
            bool retorno = false;
            if (!(taller is Taller))
            {
                throw new ArgumentException("El parámetro dado no es de tipo Taller");
            }
            else
            {
                foreach (Barco b in taller.Barcos)
                {
                    if (b.EstadoReparado == false)
                    {
                        b.EstadoReparado = true;
                        retorno = true;
                        if (b is Marina)
                        {
                            Marina m = (Marina)b;
                            m.CalcularCosto();
                        }
                        else
                        {
                            Pirata p = (Pirata)b;
                            p.CalcularCosto();
                        }
                        AccesoDatos.Guardar(b);
                    }
                }
            }

            return retorno;
        }

    }
}


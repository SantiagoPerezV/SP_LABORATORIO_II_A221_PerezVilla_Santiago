using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Marina : Barco
    {
        public Marina(bool estadoReparado, string nombre, EOperacion operacion, int tripulacion) :base(estadoReparado,nombre,operacion,tripulacion)
        {
            if (tripulacion == 0)
            {
                base.tripulacion = GenerarRandom.EnteroAleatorio(30, 60);
            }
            CalcularCosto();
        }

        public Marina()
        {
            
        }

        public override int Tripulacion
        {
            get => tripulacion;
            set => tripulacion = value; 
        }

        public override void CalcularCosto()
        {
            int nroRandom = GenerarRandom.EnteroAleatorio(5000, 25000);
            Costo = nroRandom;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

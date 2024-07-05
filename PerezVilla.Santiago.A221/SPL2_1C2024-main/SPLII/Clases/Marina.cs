using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Marina : Barco
    {
        public Marina(float costo, bool estadoReparado, string nombre, EOperacion operacion, int tripulacion) :base(costo, estadoReparado,nombre,operacion,tripulacion)
        {
            
        }

        public int Tripulacion
        {
            get => this.tripulacion;
            set
            {
                if (this.tripulacion == 0)
                {
                    this.tripulacion = GenerarRandom.EnteroAleatorio(30, 60);
                }
            }
        }

        public override void CalcularCosto()
        {
            int nroRandom = GenerarRandom.EnteroAleatorio(5000, 25000);
            this.costo = nroRandom;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

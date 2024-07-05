using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pirata : Barco
    {
        public Pirata(float costo, bool estadoReparado, string nombre, EOperacion operacion, int tripulacion) :base(costo,estadoReparado,nombre,operacion,tripulacion)
        {
            
        }
                
        public int Tripulacion
        {
            get => this.tripulacion;
            set 
            {
                if (this.tripulacion == 0)
                {
                    this.tripulacion = GenerarRandom.EnteroAleatorio(10, 30);
                }
            }
        }

        public override void CalcularCosto()
        {
            int nroRandom = GenerarRandom.EnteroAleatorio(2000, 12000);
            this.costo = nroRandom;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

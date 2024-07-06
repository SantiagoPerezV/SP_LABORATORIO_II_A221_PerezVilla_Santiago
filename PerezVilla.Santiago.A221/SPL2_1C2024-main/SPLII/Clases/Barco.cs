using System.Text;

namespace Clases
{
    public abstract class Barco
    {

        protected float costo;
        protected bool estadoReparado;
        protected string nombre = "";
        protected EOperacion operacion;
        protected int tripulacion;

        public float Costo { get => costo; set => costo = value; }
        public bool EstadoReparado { get => estadoReparado; set => estadoReparado = value; }
        public string Nombre { get => nombre;}
        public EOperacion Operacion { get => operacion;}
        public abstract int Tripulacion { get; set; }
        public Barco(bool estadoReparado, string nombre, EOperacion operacion, int tripulacion)
        {
            this.estadoReparado = estadoReparado;
            this.nombre = nombre;
            this.operacion = operacion;
            this.tripulacion = tripulacion;
        }

        public Barco()
        {
            
        }


        public abstract void CalcularCosto();

        public bool CompararBarcos(Barco a)
        {
            bool retorno = false;
            if (Nombre == a.Nombre)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"{Nombre} -- {Costo} -- {EstadoReparado} -- {Operacion} -- {Tripulacion}");
            return cadena.ToString();
        }

    }
}

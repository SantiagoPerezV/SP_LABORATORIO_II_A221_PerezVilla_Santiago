using System.Text;

namespace Clases
{
    public abstract class Barco
    {
        public enum EOperacion
        {
            Reparar_Mastil,
            Pintar,
            Cambiar_Velas,
            Reparar_Mascaron,
            Reparar_Casco,
            Recargar_Cañones
        }

        protected float costo;
        protected bool estadoReparado;
        protected string nombre;
        protected EOperacion operacion;
        protected int tripulacion;

        public float Costo { get => costo;}
        public bool EstadoReparado { get => estadoReparado; set => this.estadoReparado = value; }
        public string Nombre { get => nombre;}
        public EOperacion Operacion { get => operacion;}
        protected int Tripulacion { get => tripulacion;}

        public Barco()
        {
            
        }

        public Barco(float costo, bool estadoReparado, string nombre, EOperacion operacion, int tripulacion)
        {
            this.costo = costo;
            this.estadoReparado = estadoReparado;
            this.nombre = nombre;
            this.operacion = operacion;
            this.tripulacion = tripulacion;
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

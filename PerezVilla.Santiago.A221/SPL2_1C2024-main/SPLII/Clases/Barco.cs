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
        public bool EstadoReparado { get => estadoReparado;}
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

        protected abstract void CalcularCosto();

        public bool CompararBarcos(Barco a, Barco b)
        {
            bool retorno = false;
            if (a.Nombre == b.Nombre)
            {
                retorno = true;
            }
            return retorno;
        }

        //public static bool operator ==(Barco a, Barco b)
        //{
        //    return a.Nombre == b.Nombre;
        //}
        //public static bool operator !=(Barco a, Barco b)
        //{
        //    return !(a == b);
        //}

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"{Nombre} -- {Costo} -- {EstadoReparado} -- {Operacion} -- {Tripulacion}");
            return cadena.ToString();
        }

    }
}

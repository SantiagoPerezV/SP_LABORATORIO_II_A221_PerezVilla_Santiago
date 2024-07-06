namespace Clases
{
    [Serializable]
    public class Pirata : Barco
    {
        public Pirata(bool estadoReparado, string nombre, EOperacion operacion, int tripulacion) : base(estadoReparado, nombre, operacion, tripulacion)
        {
            if (tripulacion == 0)
            {
                base.tripulacion = GenerarRandom.EnteroAleatorio(10, 30);
            }
            CalcularCosto();
        }

        public Pirata()
        {
            
        }

        public override int Tripulacion
        {
            get => tripulacion;
            set => tripulacion = value;
        }

        public override void CalcularCosto()
        {
            int nroRandom = GenerarRandom.EnteroAleatorio(2000, 12000);
            Costo = nroRandom;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

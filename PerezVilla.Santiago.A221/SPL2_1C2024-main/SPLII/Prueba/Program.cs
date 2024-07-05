using Clases;
namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pirata p1 = new Pirata(20, true, "german", Barco.EOperacion.Reparar_Mascaron, 8);
            Pirata p2 = new Pirata(30, false, "german", Barco.EOperacion.Reparar_Mascaron, 8);
            Marina m1 = new Marina(50, true, "santiago", Barco.EOperacion.Reparar_Mascaron, 0);
            Taller t1 = new Taller();


        }
    }
}

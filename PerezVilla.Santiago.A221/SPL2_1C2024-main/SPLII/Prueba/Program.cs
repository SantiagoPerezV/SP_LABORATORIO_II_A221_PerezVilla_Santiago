using Clases;
namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pirata p1 = new Pirata(true, "german", EOperacion.Reparar_Mascaron, 15);
            Pirata p2 = new Pirata(true, "germn", EOperacion.Reparar_Casco, 20);
            Pirata p3 = new Pirata(false, "german", EOperacion.Reparar_Casco, 0);
            Marina m1 = new Marina(true, "santiago", EOperacion.Pintar, 40);
            Marina m2 = new Marina(true, "santiago", EOperacion.Cambiar_Velas, 30);
            Marina m3 = new Marina(true, "santi", EOperacion.Recargar_Cañones, 0);

            Taller t1 = new Taller();

            Console.WriteLine(p1.CompararBarcos(p2));
            Console.WriteLine(p1.CompararBarcos(p3));
            Console.WriteLine(m1.CompararBarcos(m2));
            Console.WriteLine(m1.CompararBarcos(m3));

            Console.WriteLine("****************");

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());
            Console.WriteLine(m3.ToString());

            Console.WriteLine("****************");

            t1.IngresarBarco(p1);
            t1.IngresarBarco(p2);
            t1.IngresarBarco(p3);
            t1.IngresarBarco(m1);
            t1.IngresarBarco(m2);
            t1.IngresarBarco(m3);

            foreach(Barco b in t1.Barcos)
            {
                Console.WriteLine(b.ToString());
            }

        }
    }
}

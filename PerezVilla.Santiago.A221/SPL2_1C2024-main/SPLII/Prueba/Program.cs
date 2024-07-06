using Clases;
using Clases.Excepciones;
namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pirata p1 = new Pirata(true, "german", EOperacion.Reparar_Mascaron, 15);
            Pirata p2 = new Pirata(false, "Haolin", EOperacion.Reparar_Casco, 20);
            Pirata p3 = new Pirata(false, "Sherman", EOperacion.Reparar_Casco, 0);
            Marina m1 = new Marina(false, "santiago", EOperacion.Pintar, 40);
            Marina m2 = new Marina(false, "Titanic", EOperacion.Cambiar_Velas, 30);
            Marina m3 = new Marina(false, "Perez", EOperacion.Recargar_Cañones, 0);

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

            try
            {
                t1.IngresarBarco(p1);
                t1.IngresarBarco(p2);
                t1.IngresarBarco(m1);
                t1.IngresarBarco(m3);
                t1.IngresarBarco(m2);
                t1.IngresarBarco(p3);
            }
            catch(BarcoEncontradoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            XmlManager ser = new XmlManager();
            Console.WriteLine(ser.Guardar(".\\Barcos.xml", t1.Barcos));
            Taller t2 = new Taller();
            t2.Barcos = ser.Leer(".\\Barcos.xml");

            //foreach (Barco b in t1.Barcos)
            //{
            //    Console.WriteLine(b.ToString());
            //}

            //foreach (Barco b in t2.Barcos)
            //{
            //    Console.WriteLine(b.ToString());
            //}

            //Console.WriteLine("****************");

            //try
            //{
            //    Console.WriteLine(t1.Reparar(t1));
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //foreach(Barco b in t1.Barcos)
            //{
            //    Console.WriteLine(b.ToString());
            //}
        }
    }
}

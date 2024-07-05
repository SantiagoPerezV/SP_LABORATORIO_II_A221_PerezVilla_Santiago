using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases
{
    public class XmlManager :IArchivos
    {
        public bool Guardar(string path, List<Barco> listaBarcos)
        {
            bool retorno = false;
            using (StreamWriter streamWriter = new StreamWriter($@"{path}"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Barco>));
                xmlSerializer.Serialize(streamWriter, listaBarcos);
                retorno = true;
            }
            return retorno;
        }

        public List<Barco> Leer(string path)
        {
            List<Barco> listaBarcos = new List<Barco>();
            using(StreamReader streamReader = new StreamReader($@"{path}"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Barco>));
                listaBarcos = (List<Barco>)xmlSerializer.Deserialize(streamReader);
            }
            return listaBarcos;
        }
    }
}

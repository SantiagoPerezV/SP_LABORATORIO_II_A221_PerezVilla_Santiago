using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface IArchivos
    {
        bool Guardar(string path, List<Barco> listaBarcos);
        List<Barco> Leer(string path);
    }
}

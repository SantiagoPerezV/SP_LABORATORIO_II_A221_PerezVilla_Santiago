﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface IArchivos
    {
        bool Guardar(List<Barco> listaBarcos);
        List<Barco> Leer();
    }
}

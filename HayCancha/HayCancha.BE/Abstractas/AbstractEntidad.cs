﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayCancha.BE.Abstractas
{
    public abstract class AbstractEntidad
    {
        public AbstractEntidad(string sTabla)
        {
            Id = new Guid();
            Tabla = sTabla;
        }

        public Guid Id { get; }
        public string Tabla { get; }
    }
}

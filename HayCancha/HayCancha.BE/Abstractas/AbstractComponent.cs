﻿using System.Collections.Generic;
using HayCancha.BE.Enumerables;

namespace HayCancha.BE.Abstractas
{
    public abstract class AbstractComponent
    {
        public PermisoEnum Permiso { get; set; }
        public abstract IList<AbstractComponent> lstHijos { get; }

        public abstract void AgregarHijo(AbstractComponent oComponente);

        public abstract void VaciarHijos();
    }
}

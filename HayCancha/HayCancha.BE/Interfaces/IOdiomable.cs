using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayCancha.BE.Enumerables;

namespace HayCancha.BE.Interfaces
{
    public interface IOdiomable
    {
        IdiomaEnum IdiomaControl { get; set; }
        void Update();
    }
}

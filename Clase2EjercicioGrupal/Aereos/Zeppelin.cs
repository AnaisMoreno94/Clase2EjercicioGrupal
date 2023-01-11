using Clase2EjercicioGrupal.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Clase2EjercicioGrupal.Aereos
{
    internal class Zeppelin:Aeronaves
    {
        public Zeppelin(string nombre, string marca, string tamaño, bool usoMilitar, bool rigido) : base(nombre, marca, tamaño, usoMilitar)
        {
            Rigido = rigido;
        }
        public bool Rigido { get; set; }
    }

}

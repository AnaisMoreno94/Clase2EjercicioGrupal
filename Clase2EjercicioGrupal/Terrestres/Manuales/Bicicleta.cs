using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Manuales
{
    public class Bicicleta : Manual
    {
        public string TipoMarco { get; set; }
        public string TipoFreno { get; set; }

        public Bicicleta(string Nombre, string Modelo, string Ruedas, string Tamaño, string TipoMarco, string TipoFreno ):base(Nombre, Modelo, Ruedas, Tamaño)
        {
            this.TipoMarco = TipoMarco;
            this.TipoFreno = TipoFreno;
        }


    }
}

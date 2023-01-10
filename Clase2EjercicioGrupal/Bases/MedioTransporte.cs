using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjercicioGrupal.Bases
{
    public abstract class MedioTransporte
    {

        public MedioTransporte() { }
        public MedioTransporte(string Nombre, string Modelo)
        {
            this.Nombre = Nombre;
            this.Modelo = Modelo;
        }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
    }
}

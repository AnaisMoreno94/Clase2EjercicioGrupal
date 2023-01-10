using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Manuales
{
    public class Triciclo : Manual
    {
        public string Asiento { get; set; }
        public string Ejes { get; set; }

        public Triciclo(string Nombre, string Modelo, string Ruedas, string Tamaño, string Asiento, string Ejes) : base(Nombre, Modelo, Ruedas, Tamaño)
        {
            this.Asiento = Asiento;
            this.Ejes = Ejes;
        }
    }

}

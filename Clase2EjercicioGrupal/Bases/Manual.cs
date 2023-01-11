using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjercicioGrupal.Bases
{
    public abstract class Manual:MedioTransporte
    {
        public Manual(string Nombre,string Modelo, string Ruedas, string Tamaño ):base(Nombre, Modelo)
        {
        this.Ruedas= Ruedas;
        this.Tamaño = Tamaño;
        }

        public string Ruedas  { get; set; }
        public string Tamaño { get; set; }
    }
}

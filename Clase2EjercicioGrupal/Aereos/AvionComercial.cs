using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Aereos
{
    public class AvionComercial : Aeronaves

    {
       public AvionComercial(string nombre, string marca,string tamaño, bool usoMilitar,string aereolinea, string tipo) : base(nombre, marca, tamaño, usoMilitar)
       {
           Aereolinea = aereolinea;
           Tipo = tipo;
       }
        public string Aereolinea { get; set; }
        public string Tipo { get; set; }
    }


}

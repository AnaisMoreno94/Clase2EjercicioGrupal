using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Aereos
{
    public class Avioneta:Aeronaves
    {
        public Avioneta(string nombre, string marca, string tamaño, bool usoMilitar, bool cabotaje) : base(nombre, marca,tamaño, usoMilitar)
        {
            Cabotaje = cabotaje;
        }
        public bool Cabotaje { get; set; }
    }


}

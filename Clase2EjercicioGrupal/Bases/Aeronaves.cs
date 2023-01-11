using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjercicioGrupal.Bases
{
    public abstract class Aeronaves : MedioTransporte
    {
        public Aeronaves(string Nombre, string Marca, string tamaño, bool usoMilitar): base(Nombre, Marca)
        {
            Tamaño = tamaño;
            Militar = usoMilitar;
        }
        public string Tamaño { get; set; }
        public bool Militar { get; set; }
    }

}

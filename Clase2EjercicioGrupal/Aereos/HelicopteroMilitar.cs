using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Aereos
{
    internal class HelicopteroMilitar : Aeronaves
    {
        public HelicopteroMilitar(string nombre, string marca, string tamaño, bool usoMilitar, int transporte, bool ataque) : base(nombre, marca, tamaño, usoMilitar)
        {
            Transporte = transporte;
            Ataque = ataque;
        }
        public int Transporte { get; set; }
        public bool Ataque { get; set; }

    }
}

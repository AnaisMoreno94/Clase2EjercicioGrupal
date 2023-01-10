using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjercicioGrupal.Bases
{
    internal class Camion : MedioTransporte
    {
        public string TipoMotor { get; set; }
        public int Capacidad { get; set; }
        public Camion(string Nombre, string Modelo, string TipoMotor, int Capacidad) : base(Nombre, Modelo)
        {
            this.TipoMotor = TipoMotor;
            this.Capacidad = Capacidad;
        }
    }
}

}

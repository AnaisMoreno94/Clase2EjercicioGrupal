using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjercicioGrupal.Bases
{
    public abstract class Motoo :MedioTransporte
    {
        public Motoo(string Nombre, string Modelo, int Cilindraje, bool Scooter) : base(Nombre, Modelo)
        {
            this.Cilindraje = Cilindraje;
            this.Scooter = Scooter;
        }
        public int Cilindraje { get; set; }
        public bool Scooter { get; set; }
    }
}

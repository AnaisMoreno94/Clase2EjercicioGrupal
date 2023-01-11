using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Motos
{
    public class MotoCarrera : Motoo
    {
        public int Velocidad { get; set; }
        public string Patente { get; set; }
        public MotoCarrera(string Nombre, string Modelo, int Cilindraje, bool Scooter, int Velocidad, string Patente) : base(Nombre, Modelo, Cilindraje, Scooter)
        {
            this.Velocidad = Velocidad;
            this.Patente = Patente;
        }

    }
}

using Clase2EjercicioGrupal.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjercicioGrupal.Terrestres.Motos
{
    internal class Motomel:Motoo
    {
        public Motomel(string Nombre, String Modelo, int Cilindraje, bool Scooter, int Patente, string Color) : base(Nombre, Modelo, Cilindraje, Scooter)
        {
            this.Patente = Patente;
            this.Color = Color;
        }
        public int Patente { get; set; }
        public string Color { get; set; }
    }
}

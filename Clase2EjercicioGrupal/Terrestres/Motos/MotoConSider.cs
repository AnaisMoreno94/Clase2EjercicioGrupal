using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Motos
{
    internal class MotoConSider:Motoo
    {
        public MotoConSider(string Nombre, String Modelo, int Cilindraje, bool Scooter, int Pasajeros, bool SiderRemovible) : base(Nombre, Modelo, Cilindraje, Scooter)
        {
            this.Pasajeros = Pasajeros;
            this.SiderRemovible = SiderRemovible;
        }
        public int Pasajeros { get; set; }
        public bool SiderRemovible { get; set; }
    }
}

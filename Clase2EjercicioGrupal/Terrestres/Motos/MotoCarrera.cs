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
        public int MyProperty { get; set; }
        public string MyPro { get; set; }
        public MotoCarrera(string Nombre, string Modelo, int Cilindraje, bool Scooter, int Prop, string Propiedad) : base(Nombre, Modelo, Cilindraje, Scooter)
        {
            this.MyProperty = Prop;
            this.MyPro = Propiedad;
        }

    }
}

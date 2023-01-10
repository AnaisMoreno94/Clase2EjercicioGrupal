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
        public Motomel(string Nombre, String Modelo, int Cilindraje, bool Scooter, int Prop, string Propiedad) : base(Nombre, Modelo, Cilindraje, Scooter)
        {
            this.MyProperty = Prop;
            this.MyPro = Propiedad;
        }
        public int MyProperty { get; set; }
        public string MyPro { get; set; }
    }
}

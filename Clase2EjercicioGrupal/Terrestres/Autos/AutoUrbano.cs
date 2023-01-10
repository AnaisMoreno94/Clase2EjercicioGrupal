using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Autos
{
    internal class AutoUrbano : Auto
    {
        public string Marca { get; set; }
        public int Comodidad { get; set; }
        public AutoUrbano(string Nombre, string Modelo, string TipoMotor, string Color, string Marca, int Comodidad) : base(Nombre, Modelo, TipoMotor, Color)
        {
            this.Marca = Marca;
            this.Comodidad = Comodidad;
        }

    }
}

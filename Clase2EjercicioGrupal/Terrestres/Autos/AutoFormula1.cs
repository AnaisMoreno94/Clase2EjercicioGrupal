using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Autos
{
    public class AutoFormula1:Auto
    {
        public int Velocidad { get; set; }
        public int CaballosPotencia { get; set; }
        public AutoFormula1(string Nombre, string Modelo, string TipoMotor, string Color, int Velocidad, int CaballosPotencia) : base(Nombre, Modelo, TipoMotor, Color)
        {
            this.Velocidad = Velocidad;
            this.CaballosPotencia = CaballosPotencia;
        }

    }
}

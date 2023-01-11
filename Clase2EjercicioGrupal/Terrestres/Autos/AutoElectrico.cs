using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Autos
{
    public class AutoElectrico : Auto
    {
        public float CantidadKW { get; set; }
        public float Carga { get; set; }
        public AutoElectrico(string Nombre, string Modelo, string TipoMotor, string Color, float CantidadKW, float Carga) : base(Nombre, Modelo, TipoMotor, Color)
        {
            this.CantidadKW = CantidadKW;
            this.Carga = Carga;
        }


    }
}

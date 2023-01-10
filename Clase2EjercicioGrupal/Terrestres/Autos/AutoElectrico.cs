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
        public int CantidadKW { get; set; }
        public int Carga { get; set; }
        public AutoElectrico(string Nombre, string Modelo, string TipoMotor, string Color, int CantidadKW, int Carga) : base(Nombre, Modelo, TipoMotor, Color)
        {
            this.CantidadKW = CantidadKW;
            this.Carga = Carga;
        }


    }
}

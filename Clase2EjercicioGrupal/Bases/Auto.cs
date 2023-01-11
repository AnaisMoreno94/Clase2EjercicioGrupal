using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjercicioGrupal.Bases
{
    public abstract class Auto : MedioTransporte
    {
        public string TipoMotor { get; set; }
        public string Color { get; set; }
        public Auto(string Nombre, string Modelo, string TipoMotor, string Color) : base(Nombre, Modelo)
        {
            this.TipoMotor = TipoMotor;
            this.Color = Color;
        }
    }
}

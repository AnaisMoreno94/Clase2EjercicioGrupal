using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Camiones
{
    public class CamionDeCarga : Camion
    {
        public int CapacidadAutomoviles { get; set; }
        public int CantidadDePisos { get; set; }
        public CamionDeCarga(string Nombre, string Modelo, string TipoMotor, int Capacidad, int CapacidadAutomoviles, int CantidadDePisos) : base(Nombre, Modelo, TipoMotor, Capacidad)
        {
            this.CapacidadAutomoviles = CapacidadAutomoviles;
            this.CantidadDePisos = CantidadDePisos;
        }
    }

}

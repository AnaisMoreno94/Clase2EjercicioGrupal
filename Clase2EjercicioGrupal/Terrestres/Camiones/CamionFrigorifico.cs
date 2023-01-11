using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Camiones
{
    internal class CamionFrigorifico:Camion
    {
        public int Frigorias { get; set; }
        public string Marca { get; set; }
        public CamionFrigorifico(string Nombre, string Modelo, string TipoMotor, int Capacidad, int Frigorias, string Marca) : base(Nombre, Modelo, TipoMotor, Capacidad)
        {
            this.Frigorias = Frigorias;
            this.Marca = Marca;
        }
    }
}

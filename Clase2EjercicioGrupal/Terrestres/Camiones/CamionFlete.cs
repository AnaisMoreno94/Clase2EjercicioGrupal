using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Camiones
{
    public class CamionFlete : Camion
    {
        public string MarcaAsociada { get; set; }
        public string TipoProducto { get; set; }
        public CamionFlete(string Nombre, string Modelo, string TipoMotor, int Capacidad, string MarcaAsociada, string TipoProducto) : base(Nombre, Modelo, TipoMotor, Capacidad)
        {
            this.MarcaAsociada = MarcaAsociada;
            this.TipoProducto = TipoProducto;
        }
    }

}

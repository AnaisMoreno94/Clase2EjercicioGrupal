using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Terrestres.Manuales
{
    public class BicicletaCarrera : Manual
    {
        public int Cambios { get; set; }

        public int Velocidades { get; set; }
        public BicicletaCarrera(int Cambios, int Velocidades, string Nombre, string Modelo, string Ruedas, string Tamaño) : base(Nombre, Modelo, Ruedas, Tamaño)
        {
            this.Cambios=Cambios;

            this.Velocidades = Velocidades;

        }

    }
}

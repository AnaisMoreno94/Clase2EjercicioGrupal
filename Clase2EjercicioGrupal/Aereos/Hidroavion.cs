using Clase2EjercicioGrupal.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjercicioGrupal.Aereos
{
    public class Hidroavion : Aeronaves
    {
        public Hidroavion(string nombre, string marca, string tamaño, bool usoMilitar, string privado, string tipo) : base(nombre, marca,tamaño, usoMilitar)
        {
            Privado = privado;
            Tipo = tipo;
        }
        public string Privado { get; set; }
        public string Tipo { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2EjercicioGrupal.Bases;

namespace Clase2EjercicioGrupal.Aereos
{
    public class HelicopteroGrua:Aeronaves
    {
        public HelicopteroGrua(string nombre, string marca, string tamaño, bool usoMilitar, float pesoDeCarga) : base(nombre, marca, tamaño, usoMilitar)
        {
            PesoDeCarga = pesoDeCarga;
        }
        public float PesoDeCarga { get; set; }

    }
}

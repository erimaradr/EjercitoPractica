﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoWF
{
    public class InfanteriaBasica : IMovil, IDestructor, IPrecio
    {
        private string ID;

        private float Precio;

        private int Velocidad;
        private int PotenciaFuego;
    }
}
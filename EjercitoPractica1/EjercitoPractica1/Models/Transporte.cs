using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoWF
{
    public class Transporte : IMovil, IBlindado, IPrecio
    {
        private string ID;

        private float Precio;

        private int Velocidad;

        private int Blindaje;
    }
}
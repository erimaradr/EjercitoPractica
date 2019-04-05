using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoWF
{
    public class Tanque : IPrecio, IBlindado, IDestructor, IMovil
    {
        private string ID;

        private float Precio;

        private int Velocidad;

        private int Blindaje;
    }
}
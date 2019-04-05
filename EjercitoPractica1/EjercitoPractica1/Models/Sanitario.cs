using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoPractica1.Models
{
    public class Sanitario : IMovil, IBlindado, IPrecio
    {
        private string ID;
        private float Precio;
        private int Velocidad;
        private int Blindaje;
    }
}
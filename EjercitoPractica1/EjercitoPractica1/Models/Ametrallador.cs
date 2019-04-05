using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoPractica1.Models
{
    public class Ametrallador : IMovil, IBlindado, IPrecio
    {
        private string ID;

        private float Precio;

        private int Velocidad;

        public float Precio1 { get => Precio; set => Precio = value; }
        public int Velocidad1 { get => Velocidad; set => Velocidad = value; }
        public string ID1 { get => ID; set => ID = value; }

        public double capacidadDeMovimineto()
        {
            throw new NotImplementedException();
        }

        public void mostrarPrecio()
        {
            throw new NotImplementedException();
        }

        public double resistenciaAlAtaque()
        {
            throw new NotImplementedException();
        }
    }
}
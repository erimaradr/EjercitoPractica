using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoPractica1.Models
{
    public class Transporte : IMovil, IBlindado, IPrecio
    {
        private string ID;

        private float Precio;

        private int Velocidad;

        private int Blindaje;

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
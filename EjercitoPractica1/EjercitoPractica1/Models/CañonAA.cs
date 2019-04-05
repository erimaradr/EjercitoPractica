using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoPractica1.Models
{
    public class CañonAA : IMovil, IDestructor, IPrecio
    {
        private string ID;

        private float Precio;

        private int PotenciaFuego;

        private int Velocidad;

        public double capacidadDeDestruccion()
        {
            throw new NotImplementedException();
        }

        public double capacidadDeMovimineto()
        {
            throw new NotImplementedException();
        }

        public void mostrarPrecio()
        {
            throw new NotImplementedException();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoPractica1.Models
{
    public class InfanteriaBasica : IMovil, IDestructor, IPrecio
    {
        private string ID;

        private float Precio;

        private int Velocidad;
        private int PotenciaFuego;

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
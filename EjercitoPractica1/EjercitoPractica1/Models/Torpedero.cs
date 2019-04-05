using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoPractica1.Models
{
    public class Torpedero : IMovil, IDestructor, IBlindado, IPrecio
    {
        private string ID;

        private float Precio;

        private int Velocidad;

        private int Blindaje;

        private int PotenciaFuego;

        public string ID1 { get => ID; set => ID = value; }
        public float Precio1 { get => Precio; set => Precio = value; }
        public int Velocidad1 { get => Velocidad; set => Velocidad = value; }
        public int PotenciaFuego1 { get => PotenciaFuego; set => PotenciaFuego = value; }
        public int Blindaje1 { get => Blindaje; set => Blindaje = value; }

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

        public double resistenciaAlAtaque()
        {
            throw new NotImplementedException();
        }
    }
}
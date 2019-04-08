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

        public Torpedero(string iD, float precio, int velocidad, int blindaje, int potenciaFuego)
        {
            this.ID1 = iD ?? throw new ArgumentNullException(nameof(iD));
            this.Precio1 = precio;
            this.Velocidad1 = velocidad;
            this.Blindaje1 = blindaje;
            this.PotenciaFuego1 = potenciaFuego;
        }

        public string ID1 { get => ID; set => ID = value; }
        public float Precio1
        {
            get { return Precio; }
            set
            {
                if (value < 0)
                {
                    Precio = 0;
                }
                else
                {
                    Precio = value;
                }
            }
        }

        public int Velocidad1
        {
            get { return Velocidad; }
            set
            {
                if (value < 0)
                {
                    Velocidad = 0;
                }
                else
                {
                    Velocidad = value;
                }
            }
        }

        public int PotenciaFuego1
        {
            get { return PotenciaFuego; }
            set
            {
                if (value < 0)
                {
                    PotenciaFuego = 0;
                }
                else
                {
                    PotenciaFuego = value;
                }
            }
        }

        public int Blindaje1
        {
            get { return Blindaje; }
            set
            {
                if (value < 0)
                {
                    Blindaje = 0;
                }
                else
                {
                    Blindaje = value;
                }
            }
        }

        public double capacidadDeDestruccion()
        {
            return PotenciaFuego1;
        }

        public double capacidadDeMovimineto()
        {
            return Velocidad1;
        }

        public float mostrarPrecio()
        {
            return Precio1;
        }

        public double resistenciaAlAtaque()
        {
            return Blindaje1;
        }
    }
}
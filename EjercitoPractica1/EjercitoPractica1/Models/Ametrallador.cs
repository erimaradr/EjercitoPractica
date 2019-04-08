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

        private int Blindaje;

        public Ametrallador(string iD, float precio, int velocidad, int blindaje)
        {
            this.ID1 = iD ?? throw new ArgumentNullException(nameof(iD));
            this.Precio1 = precio;
            this.Velocidad1 = velocidad;
            this.Blindaje1 = blindaje;
        }

        public float Precio1
        {
             get{return Precio; }
             set{
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
        public string ID1 { get => ID; set => ID = value; }

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
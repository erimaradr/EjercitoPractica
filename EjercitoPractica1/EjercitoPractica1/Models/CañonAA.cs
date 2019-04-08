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

        public CañonAA(string iD, float precio, int potenciaFuego, int velocidad)
        {
            this.ID1 = iD ?? throw new ArgumentNullException(nameof(iD));
            this.Precio1 = precio;
            this.PotenciaFuego1 = potenciaFuego;
            this.Velocidad1 = velocidad;
        }

        public string ID1 { get => ID; set => ID = value; }

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

        public double capacidadDeDestruccion()
        {
            throw new NotImplementedException();
        }

        public double capacidadDeMovimineto()
        {
            throw new NotImplementedException();
        }

        public float mostrarPrecio()
        {
            throw new NotImplementedException();
        }
    }
}
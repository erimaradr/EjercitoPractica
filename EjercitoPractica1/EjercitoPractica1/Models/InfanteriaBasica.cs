using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoPractica1.Models
{
    public class InfanteriaBasica : IMovil, IDestructor, IPrecio
    {
        /* Variables */
        private string ID;
        private float Precio;

        private int Velocidad;
        private int PotenciaFuego;

        public InfanteriaBasica(string iD, float precio, int velocidad, int potenciaFuego)
        {
            this.ID1 = iD ?? throw new ArgumentNullException(nameof(iD));
            this.Precio1 = precio;
            this.Velocidad1 = velocidad;
            this.PotenciaFuego1 = potenciaFuego;
        }

        /* Propiedades  */
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


        /* Métodos */
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
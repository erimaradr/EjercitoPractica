using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoPractica1.Models
{
    public class Cañon : IDestructor, IPrecio
    {
        private string ID;

        private float Precio;

        private int PotenciaFuego;

        public Cañon(string iD, float precio, int potenciaFuego)
        {
            this.ID1 = iD ?? throw new ArgumentNullException(nameof(iD));
            this.Precio1 = precio;
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

        public double capacidadDeDestruccion()
        {
            throw new NotImplementedException();
        }

        public void mostrarPrecio()
        {
            throw new NotImplementedException();
        }
    }
}
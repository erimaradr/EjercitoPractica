using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoPractica1.Models
{
    public class TransporteRapido : IMovil, IPrecio
    {
        private string ID;

        private float Precio;

        private int Velocidad;

        public TransporteRapido(string iD, float precio, int velocidad)
        {
            this.ID1 = iD ?? throw new ArgumentNullException(nameof(iD));
            this.Precio1 = precio;
            this.Velocidad1 = velocidad;
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
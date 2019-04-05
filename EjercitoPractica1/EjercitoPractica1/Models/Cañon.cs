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

        public string ID1 { get => ID; set => ID = value; }
        public float Precio1 { get => Precio; set => Precio = value; }
        public int PotenciaFuego1 { get => PotenciaFuego; set => PotenciaFuego = value; }

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
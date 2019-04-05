using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercitoWF
{
    public class Cañon : IDestructor, IPrecio
    {
        private string ID;

        private float Precio;

        private int PotenciaFuego;

        public double capacidadDeDestruccion()
        {
            throw new NotImplementedException();
        }
    }
}
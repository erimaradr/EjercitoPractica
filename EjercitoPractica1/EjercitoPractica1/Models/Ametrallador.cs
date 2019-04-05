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

        public Ametrallador(string id, float precio, int velocidad) {
            this.ID = id;
                
        }


        

    }
}
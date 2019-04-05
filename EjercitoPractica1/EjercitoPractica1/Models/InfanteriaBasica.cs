using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjercitoPractica1.Models
{
    public class InfanteriaBasica : IMovil, IDestructor, IPrecio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        /* Variables */
        private string ID;

        private float Precio;

        private int Velocidad;
        private int PotenciaFuego;

        /* Propiedades  */
        public string ID1 { get => ID; set => ID = value; }
        public float Precio1 { get => Precio; set => Precio = value; }
        public int Velocidad1 { get => Velocidad; set => Velocidad = value; }
        public int PotenciaFuego1 { get => PotenciaFuego; set => PotenciaFuego = value; }


        /* Métodos */
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
    }
}
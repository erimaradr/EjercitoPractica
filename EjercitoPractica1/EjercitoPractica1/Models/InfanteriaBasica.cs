using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EjercitoPractica1.Models
{
    [Table("InfanteriaBasica")]
    public class InfanteriaBasica : IMovil, IDestructor, IPrecio
    {
        
        /* Propiedades  */
        [Key]
        public string ID1 { get; set; }
        public float Precio1 { get; set; }
        public int Velocidad1 { get; set; }
        public int PotenciaFuego1 { get; set; }


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
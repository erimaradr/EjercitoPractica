using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercitoPractica1.Models.Metadata
{
    [MetadataType(typeof(CañonMetadata))]

    public partial class Cañon { }

    public partial class CañonMetadata
    {
        [Required]
        private string ID;

        [Required]
        private float Precio;

        [Required]
        private int PotenciaFuego;
    }
}
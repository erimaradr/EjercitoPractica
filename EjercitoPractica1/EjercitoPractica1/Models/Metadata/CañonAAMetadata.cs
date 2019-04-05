using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercitoPractica1.Models.Metadata
{
    [MetadataType(typeof(CañonAAMetadata))]

    public partial class CañonAA { }
    public partial class CañonAAMetadata
    {
        [Required(ErrorMessage = "El código del cañon antiaéreo debe tener tres carácteres")]
        [Display(Name = "Cod. Cañon Antiaéreo")]
        [MinLength(2, ErrorMessage = "El código debe tener 3 carácteres")]
        [StringLength(4, ErrorMessage = " ")]
        public string ID { get; set; }

        [Required(ErrorMessage = "El precio no puede estar vacío")]
        [Display(Name = "Precio en €")]
        [DataType(DataType.Currency)]
        public float Precio { get; set; }

        [Required(ErrorMessage = "La potencia de fuego debe ser un entero")]
        [Display(Name = "Potencia de fuego")]
        public int PotenciaFuego { get; set; }

        [Required(ErrorMessage = "La velocidad debe ser un entero")]
        [Display(Name = "Velocidad")]
        public int Velocidad { get; set; }
    }
}
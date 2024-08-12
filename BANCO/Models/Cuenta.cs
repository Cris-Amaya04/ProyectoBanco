using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BANCO.Models
{
    public class Cuenta:BancoBase
    {
        
        [Display(Prompt ="Número de cuenta")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Ingrese solo números")]
        [StringLength(12)]
        public string Numero { get; set; }
        public string IdUsuario { get; set; }
        /**/public Usuario Usuario { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Campo requerido *")]
        public double SaldoActual { get; set; }

        [Required(ErrorMessage = "Seleccione un tipo de cuenta *")]
        public Tipo_Cuenta Tipo { get; set; }

    }
}

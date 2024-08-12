using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BANCO.Models
{
    public enum Tipo_Movimiento
    {
        [Display(Name = "Entre Cuentas")]
        Entre_Cuentas,

        [Display(Name = "Entre Bancos")]
        Entre_Bancos,

        [Display(Name = "Terceros")]
        Terceros,

        [Display(Name = "Pago")]
        Pago,
    }

}

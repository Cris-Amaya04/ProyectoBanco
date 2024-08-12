namespace BANCO.Models
{
    public class EnumHelper
    {

        public static string GetDisplayName(Tipo_Movimiento tipo)
        {
            switch (tipo)
            {
                case Tipo_Movimiento.Entre_Cuentas:
                    return "Entre cuentas";
                case Tipo_Movimiento.Entre_Bancos:
                    return "Entre Bancos";
                case Tipo_Movimiento.Terceros:
                    return "Terceros";
                case Tipo_Movimiento.Pago:
                    return "Pago";
                default:
                    return string.Empty;
            }

        }


    }
}

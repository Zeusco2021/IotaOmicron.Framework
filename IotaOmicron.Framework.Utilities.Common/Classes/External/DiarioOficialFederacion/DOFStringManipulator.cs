using IotaOmicron.Framework.Utilities.Common.Enums.External.DiarioOficialFederacion;

namespace IotaOmicron.Framework.Utilities.Common.Classes.External.DiarioOficialFederacion
{
    public static class DOFStringManipulator
    {
        public static string PeriodoDeTiempo(DOFPeriodosTiempo periodoTiempo)
        {
            string periodoTiempoSalida = string.Empty;
            switch(periodoTiempo)
            {
                case DOFPeriodosTiempo.Anual : periodoTiempoSalida = "anual";
                    break;
                case DOFPeriodosTiempo.Mensual : periodoTiempoSalida = "mensual";
                    break;
                case DOFPeriodosTiempo.Semanal : periodoTiempoSalida = "semanal";
                    break;
                default : periodoTiempoSalida = string.Empty;
                    break;
            }
            return periodoTiempoSalida;
        }

        public static string EdicionDelDOF(DOFEdiciones tipoEdicion)
        {
            string edicionSalida = string.Empty;
            switch (tipoEdicion)
            {
                case DOFEdiciones.Matutina : edicionSalida = "MAT";
                    break;
                case DOFEdiciones.Vespertina : edicionSalida = "VES";
                    break;
                case DOFEdiciones.Extraordinaria : edicionSalida = "EXT";
                    break;
                default: edicionSalida = string.Empty;
                    break;
            }
            return edicionSalida;
        } 
    }
}

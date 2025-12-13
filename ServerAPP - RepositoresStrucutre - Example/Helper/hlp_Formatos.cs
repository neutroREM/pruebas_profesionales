using NodaTime;
using NodaTime.Extensions;

namespace certinom_sadper_v1.Helper
{
    public class hlp_Formatos
    {
        public string FormatearFecha(DateTime fecha)
        {
            // Formatear la fecha como "dd MMM yyyy"
            string fechaFormateada = fecha.ToString("dd MMM yyyy");
            return fechaFormateada;
        }
        public string FormatearFechaSinAnio(DateTime fecha)
        {
            // Formatear la fecha como "dd MMM yyyy"
            string fechaFormateada = fecha.ToString("MMM dd");
            return fechaFormateada;
        }

        public string DateTimeaFecha(DateTime dtDateTime)
        {
            return dtDateTime.ToString("dd/mm/yyyy");
        }

        public static DateTime ConvertirFecha(string dtDateTime)
        {
            string[] sDividirFecha = dtDateTime.Split("/");

            if (dtDateTime != "")
            {
                return new DateTime(int.Parse(sDividirFecha[2]), int.Parse(sDividirFecha[1]), int.Parse(sDividirFecha[0]));
            }
            else
            {
                return new DateTime(1900, 01, 01);
            }
        }



        //años de antigüedad 
        public static string DeterminarAntiguedad(DateTime? fechaBaja, DateTime? fechaAntiguedad, DateTime? fechaInicial)
        {
            LocalDate FechaActual = DateTime.Now.ToLocalDateTime().Date;

            string sFormatoAntiguedad = string.Empty;

            if (fechaBaja != null)
            {
                sFormatoAntiguedad = fechaAntiguedad == null ?
                    PeriodoEdadAntiguedad(fechaInicial.Value.ToLocalDateTime().Date, fechaBaja.Value.ToLocalDateTime().Date) :
                    PeriodoEdadAntiguedad(fechaAntiguedad.Value.ToLocalDateTime().Date, fechaBaja.Value.ToLocalDateTime().Date);
            }
            else
            {
                sFormatoAntiguedad = fechaAntiguedad == null ?
                    PeriodoEdadAntiguedad(fechaInicial.Value.ToLocalDateTime().Date, FechaActual) :
                    PeriodoEdadAntiguedad(fechaAntiguedad.Value.ToLocalDateTime().Date, FechaActual);

            }
            return sFormatoAntiguedad;
        }




        /// <summary>
        /// PeriodoEdadAntigüedad, calcula laedad y los años de antigüedad dependiendo de la fecha de baja o la fecha antual
        /// formato calculado en años, meses y días.
        /// </summary>
        /// <param name="FechaAntiguedad">fecha de antigüedad o de ingreso</param>
        /// <param name="FechaBaja_Actual">fecha de baja o fecha actual</param>
        /// <returns></returns>
        public static string PeriodoEdadAntiguedad(LocalDate FechaAntiguedad, LocalDate FechaBaja_Actual)
        {
            string sPeriodoFormato;
            Period Periodo = Period.Between(FechaAntiguedad, FechaBaja_Actual);
            return $"{Periodo.Years}A, {Periodo.Months}M, {Periodo.Days}D";
        }


        public static char ObtenerGeneroCURP(string sCurp)
        {
            char[] chars = sCurp.ToCharArray();
            return chars[10];
        }

        public static DateTime ObtenerFechaNacimientoDesdeCURP(string curp)
        {
            // Verificar que el CURP tiene una longitud válida (18 caracteres)
            if (curp.Length != 18)
            {
                throw new ArgumentException("CURP debe tener 18 caracteres.");
            }

            // Extraer el año, mes y día del CURP (posición 5 a 10)
            string anio = curp.Substring(4, 2);  // Los dos últimos dígitos del año
            string mes = curp.Substring(6, 2);   // El mes
            string dia = curp.Substring(8, 2);   // El día

            // Construir la fecha con el siglo (por ejemplo, si el año es 97, asumir 1997)
            string siglo = int.Parse(anio) <= 30 ? "20" : "19"; // Asumimos siglo 20 si es menor o igual a 30
            string fechaNacimientoStr = siglo + anio + "-" + mes + "-" + dia;

            // Convertir la cadena en una fecha
            DateTime fechaNacimiento;
            if (DateTime.TryParse(fechaNacimientoStr, out fechaNacimiento))
            {
                return fechaNacimiento;
            }
            else
            {
                throw new ArgumentException("El CURP no contiene una fecha válida.");
            }
        }
        public static DateTime ConvertirFechaUTC(DateTime dtFecha)
        {
            return DateTime.SpecifyKind(dtFecha, DateTimeKind.Utc);
        }


    }
}

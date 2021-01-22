using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasApp
{
    public static class Extensoes
    {
        private static readonly string DATA_EXIBICAO = "dd/MM/yyyy";
        #region double
        public static double ToDouble(this decimal valor)
        {
            return Convert.ToDouble(valor);
        }
        #endregion

        #region bool
        public static string SimOuNao(this bool valor)
        {
            return valor ? "Sim" : "Não";
        }
        #endregion

        #region DateTime
        public static string ToDataFormatadaExibicao(this DateTime valor)
        {
            return valor.ToString(DATA_EXIBICAO);
        }

        public static string ToDiaMes(this DateTime valor)
        {
            return valor.ToString("dd/MM");
        }
        #endregion

        #region List
        public static bool IsNullOrEmpty<T>(this List<T> lista)
        {
            return lista == null || lista.Count <= 0;
        }
        #endregion

        #region string
        public static DateTime ToDateTimeDefault(this string valor)
        {
            CultureInfo provider = new CultureInfo("pt-BR");
            return DateTime.ParseExact(valor, Utils.FORMATO_DATA_FERIAS, provider);
        }
        #endregion
    }
}

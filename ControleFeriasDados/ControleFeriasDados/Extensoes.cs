using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasDados
{
    public static class Extensoes
    {
        public static string ToDataArquivo(this DateTime data)
        {
            return data.ToString(Utils.FORMATO_REGISTRO_DATA);
        }

    }
}

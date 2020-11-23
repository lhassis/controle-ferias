using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasApp
{
    public static class Extensoes
    {
        public static double ToDouble(this decimal valor)
        {
            return Convert.ToDouble(valor);
        }
    }
}

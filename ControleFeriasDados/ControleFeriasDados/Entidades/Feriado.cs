using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasDados.Entidades
{
    public class Feriado
    {
        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public bool Anual { get; set; }
    }
}

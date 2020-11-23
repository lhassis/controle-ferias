using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasNegocio.Dominio
{
    public class Funcionario
    {
        public int Identificador { get; set; }

        public String Nome { get; set; }

        public GrupoFuncionario Grupo { get; set; }

        public List<Ferias> PeriodosFerias { get; set; }
    }
}

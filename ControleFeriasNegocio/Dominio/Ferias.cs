using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasNegocio.Dominio
{
    public class Ferias
    {
        public int Id { get; set; }

        public Funcionario Funcionario { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public Ferias(DateTime inicio, DateTime fim, Funcionario funcionario)
        {
            Funcionario = funcionario;
            DataInicio = inicio;
            DataFim = fim;
        }

        public Ferias(ControleFeriasDados.Entidades.Ferias ferias)
        {
            Id = ferias.Id;
            DataInicio = ferias.DataInicio;
            DataFim = ferias.DataFim;
        }
    }
}

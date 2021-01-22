using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasNegocio.Dominio
{
    public class Resposta<T>
    {
        public bool Sucesso { get; set; }
        public string MensagemErro { get; set; }
        public T ObjetoRetorno { get; set; }
    }
}

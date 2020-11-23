using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasNegocio.Dominio
{
    public class GrupoFuncionario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public GrupoFuncionario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}

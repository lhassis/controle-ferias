using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeriasDados.Entidades
{
    public class Funcionario
    {
        public int Identificador { get; set; }

        public String Nome { get; set; }

        public int Grupo { get; set; }

        public bool Servidor { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, int grupo, bool servidor)
        {
            Nome = nome;
            Grupo = grupo;
            Servidor = servidor;
        }
    }
}

using ControleFeriasNegocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFeriasNegocio.Extensoes;

namespace ControleFeriasNegocio
{
    public class FuncionariosNegocio
    {
        //Buscar todos
        public List<Funcionario> BuscarTodosFuncionarios()
        {
            ControleFeriasDados.FuncionariosDados repositorioFuncionarios = new ControleFeriasDados.FuncionariosDados();
            return repositorioFuncionarios.GetFuncionarios().Select(f => f.ToFuncionarioDominio()).ToList();
        }

        public void CadastrarFuncionario(string nome, string setor)
        {
            bool funcionarioExiste = false;

            if (string.IsNullOrEmpty(nome))
                throw new Exception("Nome deve ser informado!");

            if (string.IsNullOrEmpty(setor))
                throw new Exception("Setor deve ser informado");
            
            List<Funcionario> funcionarios = BuscarTodosFuncionarios();
            if (funcionarios == null || funcionarios.Count() == 0)
            {
                funcionarioExiste = false;
            }
            else
            {
                funcionarioExiste = funcionarios.FirstOrDefault(f => f.Nome == nome && f.Grupo.Nome == setor) != null;
            }
            if (!funcionarioExiste)
            {
                ControleFeriasDados.FuncionariosDados repositorioFuncionarios = new ControleFeriasDados.FuncionariosDados();
                repositorioFuncionarios.InsertFuncionario(nome, setor);
            }
        }
        
    }
}

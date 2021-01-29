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

        public Resposta<Funcionario> CadastrarFuncionario(string nome, string setor, bool servidor)
        {
            bool funcionarioExiste = false;

            if (string.IsNullOrEmpty(nome))
                return RetornarErroCadastroFuncionario("Nome deve ser informado!");

            if (string.IsNullOrEmpty(setor))
                return RetornarErroCadastroFuncionario("Grupo deve ser informado!");
            
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
                repositorioFuncionarios.InsertFuncionario(nome, setor, servidor);
            }
            else
            {
                return RetornarErroCadastroFuncionario("Funcionário de mesmo nome já cadastrado no setor.");
            }

            return RetornarSucessoCadastroFuncionario(null);
        }

        public Resposta<Funcionario> RemoverFuncionario(int idFuncionario)
        {
            ControleFeriasDados.FuncionariosDados repositorioFuncionarios = new ControleFeriasDados.FuncionariosDados();
            try
            {
                repositorioFuncionarios.DeleteFuncionario(idFuncionario);
                return new Resposta<Funcionario>()
                {
                    Sucesso = true,
                };
            }
            catch (Exception ex)
            {
                return new Resposta<Funcionario>()
                {
                    Sucesso = false,
                    MensagemErro = ex.Message,
                };
            }
        }

        private Resposta<Funcionario> RetornarErroCadastroFuncionario(string mensagemErro)
        {
            return new Resposta<Funcionario>()
            {
                MensagemErro = mensagemErro,
                Sucesso = false,
                ObjetoRetorno = null,
            };
        }

        private Resposta<Funcionario> RetornarSucessoCadastroFuncionario(Funcionario objFuncionario)
        {
            return new Resposta<Funcionario>()
            {
                MensagemErro = null,
                Sucesso = true,
                ObjetoRetorno = objFuncionario,
            };
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFeriasNegocio.Extensoes;

namespace ControleFeriasNegocio
{
    public class FeriasNegocio
    {
        private ControleFeriasDados.FeriasDados RepositorioFerias;

        private ControleFeriasDados.FuncionariosDados RepositorioFuncionarios;

        public FeriasNegocio()
        {
            RepositorioFerias = new ControleFeriasDados.FeriasDados();
            RepositorioFuncionarios = new ControleFeriasDados.FuncionariosDados();
        }

        //Cadastrar Período de Férias
        public void CadastrarFerias(int idFuncionario, DateTime dataInicio, DateTime dataFim)
        {
            var novoRegistro = new ControleFeriasDados.Entidades.Ferias()
            {
                IdFuncionario = idFuncionario,
                DataInicio = dataInicio,
                DataFim = dataFim
            };

            RepositorioFerias.InsertFerias(novoRegistro);
        }
        //Editar Período de Férias

        //Remover período de férias

        //Buscar período de férias por funcionário
        public Dominio.Funcionario GetFeriasFuncionario(Dominio.Funcionario funcionario)
        {
            var resultadoConsulta = RepositorioFerias.GetFeriasPorFuncionario(funcionario.Identificador);
            funcionario.PeriodosFerias = resultadoConsulta.Select(f => f.ToFeriasDomain()).ToList();
            return funcionario;
        }
    }
}

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

        private ControleFeriasDados.GrupoFuncionarioDados RepositorioGrupoFuncionarios;

        public FeriasNegocio()
        {
            RepositorioFerias = new ControleFeriasDados.FeriasDados();
            RepositorioFuncionarios = new ControleFeriasDados.FuncionariosDados();
            RepositorioGrupoFuncionarios = new ControleFeriasDados.GrupoFuncionarioDados();
        }

        //Cadastrar Período de Férias
        public void CadastrarFerias(int idFuncionario, DateTime dataInicio, DateTime dataFim)
        {
            //Verificar férias no mesmo período para o setor
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

        public Dominio.Funcionario GetFeriasFuncionario(Dominio.Funcionario funcionario)
        {
            var resultadoConsulta = RepositorioFerias.GetFeriasPorFuncionario(funcionario.Identificador);
            funcionario.PeriodosFerias = resultadoConsulta.Select(f => f.ToFeriasDominio()).ToList();
            return funcionario;
        }

        public List<Dominio.Funcionario> GetFeriasSetor(string setorSelecionado)
        {
            var setor = RepositorioGrupoFuncionarios.GetGrupo(setorSelecionado);
            var funcionariosSetor = RepositorioFuncionarios.GetFuncionariosPorGrupo(setor.Id).Select(f => f.ToFuncionarioDominio()).ToList();
            var idsFuncionarios = funcionariosSetor.Select(f => f.Identificador).ToList();

            RepositorioFerias.GetFeriasPorFuncionarios(idsFuncionarios).ForEach((f) =>
            {
                var ferias = f.ToFeriasDominio();
                var funcionario = funcionariosSetor.FirstOrDefault(fs => fs.Identificador == f.IdFuncionario);
                if (funcionario.PeriodosFerias == null) funcionario.PeriodosFerias = new List<Dominio.Ferias>();

                ferias.Funcionario = funcionario;
                funcionario.PeriodosFerias.Add(ferias);

                funcionariosSetor.AddOrReplace(funcionario, fs => fs.Identificador == funcionario.Identificador);
            });

            return funcionariosSetor.ToList();
        }

        public DateTime CalcularFimFeriasFuncionario(Dominio.Funcionario funcionario, DateTime inicio, double dias)
        {
            if (funcionario.Servidor)
            {
                int contaDias = 1;
                DateTime dataFim = inicio;
                FeriadosNegocio feriadosNegocio = new FeriadosNegocio();
                var feriados = feriadosNegocio.BuscarFeriados();
                var feriadosFixos = feriados.Where(f => f.Anual)?.ToList();
                var feriadosMoveis = feriados.Where(f => !f.Anual)?.ToList();
                while (contaDias < dias)
                {
                    dataFim = dataFim.AddDays(1);
                    if (feriadosNegocio.VerificarDiaUtil(dataFim, feriadosFixos, feriadosMoveis))
                    {
                        contaDias++;
                    }
                }
                return dataFim;
            }
            else
            {
                //dias corridos
                return inicio.AddDays(dias);
            }
        }

        public int CalcularTotalDiasUteis(DateTime inicio, DateTime fim)
        {
            DateTime dataAtual = inicio;
            FeriadosNegocio feriadosNegocio = new FeriadosNegocio();
            var feriados = feriadosNegocio.BuscarFeriados();
            var feriadosFixos = feriados.Where(f => f.Anual)?.ToList();
            var feriadosMoveis = feriados.Where(f => !f.Anual)?.ToList();
            int totalDias = 0;
            while (dataAtual <= fim)
            {
                if (feriadosNegocio.VerificarDiaUtil(dataAtual, feriadosFixos, feriadosMoveis))
                {
                    totalDias++;
                }
                dataAtual = dataAtual.AddDays(1);
            }
            return totalDias;
        }

        public List<Dominio.Funcionario> VerificarFuncionariosSetorEmFeriasNoPeriodo(DateTime inicio, DateTime fim, string setor)
        {
            var ferias = RepositorioFerias.GetFeriasPorData(inicio, fim);
            if (!ferias.IsNullOrEmpty())
            {
                var setorObj = RepositorioGrupoFuncionarios.GetGrupo(setor);
                var funcionariosSetor = RepositorioFuncionarios.GetFuncionariosPorGrupo(setorObj.Id).Select(f => f.ToFuncionarioDominio()).ToList();
                var idsFuncionarios = funcionariosSetor.Select(f => f.Identificador).ToList();
                var feriasPeriodoSetor = ferias.Where(f => idsFuncionarios.Contains(f.IdFuncionario))?.Select(fer => fer.IdFuncionario);
                return funcionariosSetor?.Where(f => feriasPeriodoSetor.Contains(f.Identificador))?.ToList();
            }
            return null;
        }

        public void RemoverFerias(int idFuncionario, DateTime dataInicio, DateTime dataFim) 
        {
            RepositorioFerias.DeleteFerias(idFuncionario, dataInicio, dataFim);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFeriasApp
{
    public partial class Form1
    {
        #region CadastroFerias
        ControleFeriasNegocio.FeriasNegocio ControleFeriasNegocio = new ControleFeriasNegocio.FeriasNegocio();
        private void CarregarSeletorFuncionarios(List<ControleFeriasNegocio.Dominio.Funcionario> funcionarios)
        {
            comboFuncionariosFerias.Items.Clear();
            foreach (var funcionario in funcionarios)
            {
                comboFuncionariosFerias.Items.Add(funcionario.Nome);
            }
        }

        private void btnCadastrarFerias_Click(object sender, EventArgs e)
        {
            string nomeFuncionario = comboFuncionariosFerias.SelectedItem.ToString();
            var funcionario = BuscarFuncionarioCache(nomeFuncionario);
            DateTime inicio = dateTimeInicio.Value;
            DateTime fim = dateTimeFim.Value;

            var feriasManager = new ControleFeriasNegocio.FeriasNegocio();
            var funcionariosJaEmFerias = feriasManager.VerificarFuncionariosSetorEmFeriasNoPeriodo(inicio, fim, funcionario.Grupo.Nome);
            if (!funcionariosJaEmFerias.IsNullOrEmpty())
            {
                string nomes = string.Join(", ", funcionariosJaEmFerias.Select(f => f.Nome));
                string mensagem = string.Format("O(s) funcionário(s) [{0}] já está(ão) em férias no período. Deseja confirmar o registro das férias?", nomes);
                var dialogResult = MessageBox.Show(mensagem, "Confirmar registro", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    feriasManager.CadastrarFerias(funcionario.Identificador, inicio, fim);
                }
            }
            else
            {
                feriasManager.CadastrarFerias(funcionario.Identificador, inicio, fim);
            }
            CarregarFeriasFuncionario();
        }

        private void CarregarFeriasFuncionario()
        {
            var nomeFuncionario = comboFuncionariosFerias.SelectedItem.ToString();

            var feriasManager = new ControleFeriasNegocio.FeriasNegocio();
            var funcionario = BuscarFuncionarioCache(nomeFuncionario);
            var funcionarioComFerias = feriasManager.GetFeriasFuncionario(funcionario);

            GerarTabelaFeriasFuncionario(funcionarioComFerias.PeriodosFerias);
        }

        private void GerarTabelaFeriasFuncionario(List<ControleFeriasNegocio.Dominio.Ferias> ferias)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Dias");
            dataTable.Columns.Add("Dias Úteis");
            dataTable.Columns.Add("Início");
            dataTable.Columns.Add("Fim");

            foreach (var periodo in ferias)
            {
                dataTable.Rows.Add(ConverterParaLinhaTabela(periodo));
            }

            dataGridFeriasFuncionario.DataSource = dataTable;

            dataGridFeriasFuncionario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridFeriasFuncionario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridFeriasFuncionario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private object[] ConverterParaLinhaTabela(ControleFeriasNegocio.Dominio.Ferias ferias)
        {
            object[] resultado = new object[4];

            var dias = (ferias.DataFim - ferias.DataInicio).TotalDays + 1;
            var uteis = new ControleFeriasNegocio.FeriasNegocio().CalcularTotalDiasUteis(ferias.DataInicio, ferias.DataFim); ;
            resultado[0] = dias;
            resultado[1] = uteis;
            resultado[2] = ferias.DataInicio.ToString(Utils.FORMATO_DATA_FERIAS);
            resultado[3] = ferias.DataFim.ToString(Utils.FORMATO_DATA_FERIAS);

            return resultado;
        }

        private void numDias_ValueChanged(object sender, EventArgs e)
        {
            CalcularNovoFimFerias();
        }

        private void comboFuncionariosFerias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarFeriasFuncionario();
            CalcularNovoFimFerias();
        }


        private void dateTimeInicio_ValueChanged(object sender, EventArgs e)
        {
            CalcularNovoFimFerias();
        }

        private void CalcularNovoFimFerias()
        {
            string nomeFuncionario = comboFuncionariosFerias.SelectedItem.ToString();
            var funcionario = BuscarFuncionarioCache(nomeFuncionario);
            dateTimeFim.Value = ControleFeriasNegocio.CalcularFimFeriasFuncionario(funcionario, dateTimeInicio.Value, numDias.Value.ToDouble());
        }

        private void dataGridFeriasFuncionario_SelectionChanged(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridFeriasFuncionario.SelectedRows;
            if (linhaSelecionada != null)
            {
                btnRemoverFerias.Enabled = true;
            }
        }

        private void btnRemoverFerias_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Tem certeza que deseja remover o período selecionado?", "Remover férias", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                var item = comboFuncionariosFerias.SelectedItem;
                var linhaSelecionada = dataGridFeriasFuncionario.SelectedRows;
                var inicio = linhaSelecionada[0].Cells[2].Value.ToString().ToDateTimeDefault();
                var fim = linhaSelecionada[0].Cells[3].Value.ToString().ToDateTimeDefault();
                var funcionario = BuscarFuncionarioCache(item as string);
                new ControleFeriasNegocio.FeriasNegocio().RemoverFerias(funcionario.Identificador, inicio, fim);
                CarregarFeriasFuncionario();
            }
        }
        #endregion
    }
}

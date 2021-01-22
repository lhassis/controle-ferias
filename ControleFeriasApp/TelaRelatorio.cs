using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFeriasApp
{
    public partial class TelaRelatorio : Form
    {
        private List<ControleFeriasNegocio.Dominio.Funcionario> _FuncionariosFerias;
        private List<ControleFeriasNegocio.Dominio.Ferias> _Ferias;

        public TelaRelatorio()
        {
            InitializeComponent();
        }

        public TelaRelatorio(List<ControleFeriasNegocio.Dominio.Funcionario> funcionariosFerias)
        {
            _FuncionariosFerias = funcionariosFerias;
            InitializeComponent();
            ConfigurarDatasRelatorio();
            InicializarSeletoresData();
        }

        public void ConfigurarDatasRelatorio(List<ControleFeriasNegocio.Dominio.Funcionario> funcionariosEmFerias = null)
        {
            if (funcionariosEmFerias == null)
            {
                funcionariosEmFerias = _FuncionariosFerias;
            }
            _Ferias = funcionariosEmFerias?.Where(f => !f.PeriodosFerias.IsNullOrEmpty()).SelectMany(f => f.PeriodosFerias)?.ToList();
            DateTime[] datas = _Ferias?.SelectMany(p => DatasDoPeriodo(p))?.OrderBy(p => p).ToArray();
            if (datas != null)
                monthCalendar1.BoldedDates = datas;
        }

        
        private List<DateTime> DatasDoPeriodo(ControleFeriasNegocio.Dominio.Ferias periodoFerias)
        {
            List<DateTime> resultado = new List<DateTime>();
            if (periodoFerias.DataFim >= periodoFerias.DataInicio)
            {
                for (DateTime data = periodoFerias.DataInicio; data <= periodoFerias.DataFim; data = data.AddDays(1))
                {
                    resultado.Add(data);
                }
            }
            return resultado;
        }

        private List<DateTime> DatasDoPeriodo(List<ControleFeriasNegocio.Dominio.Ferias> periodosFerias)
        {
            List<DateTime> resultado = new List<DateTime>();
            if (periodosFerias != null)
                periodosFerias.ForEach(p => resultado.AddRange(DatasDoPeriodo(p)));
            return resultado;
        }

        private void InicializarSeletoresData()
        {
            dateTimeInicioRelatorio.Value = DateTime.Now.AddDays(-30);
            dateTimeFimRelatorio.Value = DateTime.Now.AddMonths(7);
        }

        private void AtualizarTabelaFerias()
        {
            var dadosFiltrados = _Ferias.Where(f => f.DataInicio >= dateTimeInicioRelatorio.Value && f.DataInicio <= dateTimeFimRelatorio.Value);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Funcionario");
            dataTable.Columns.Add("Início");
            dataTable.Columns.Add("Fim");

            foreach (var periodo in dadosFiltrados)
            {
                dataTable.Rows.Add(ConverterParaLinhaTabela(periodo));
            }

            dataGridViewRelatorioFerias.DataSource = dataTable;
            dataGridViewRelatorioFerias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRelatorioFerias.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRelatorioFerias.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private object[] ConverterParaLinhaTabela(ControleFeriasNegocio.Dominio.Ferias ferias)
        {
            object[] resultado = new object[3];

            resultado[0] = ferias.Funcionario.Nome;
            resultado[1] = ferias.DataInicio.ToString(Utils.FORMATO_DATA_FERIAS);
            resultado[2] = ferias.DataFim.ToString(Utils.FORMATO_DATA_FERIAS);

            return resultado;
        }

        private void dateTimeFimRelatorio_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTabelaFerias();
        }

        private void dateTimeInicioRelatorio_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTabelaFerias();
        }
    }
}

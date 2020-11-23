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
    public partial class Form1 : Form
    {
        private List<ControleFeriasNegocio.Dominio.Funcionario> CacheFuncionarios;

        private string FORMATO_DATA_FERIAS = "dd/MM/yyyy";
        public Form1()
        {
            InitializeComponent();
            CarregarSetores();
            CarregarFuncionarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void GerarTabelaFuncionarios(List<ControleFeriasNegocio.Dominio.Funcionario> funcionarios)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Setor");

            foreach (var funcionario in funcionarios)
            {
                dataTable.Rows.Add(ConverterParaLinhaTabela(funcionario));
            }

            dataGridView1.DataSource = dataTable;
        }

        private object[] ConverterParaLinhaTabela(ControleFeriasNegocio.Dominio.Funcionario funcionario)
        {
            object[] resultado = new object[2];

            resultado[0] = funcionario.Nome;
            resultado[1] = funcionario.Grupo.Nome;

            return resultado;
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    //button1.PerformClick();
                    break;
                case 1:
                    
                    break;
                default:
                    break;
            }
        }

        private void CarregarSetores()
        {
            ControleFeriasNegocio.GrupoFuncionarioNegocio grupoManager = new ControleFeriasNegocio.GrupoFuncionarioNegocio();
            List<ControleFeriasNegocio.Dominio.GrupoFuncionario> setores = grupoManager.BuscarGrupos();

            GerarTabelaSetores(setores);
            CarregarSeletorSetores(setores);
        }

        private void CarregarFuncionarios()
        {
            ControleFeriasNegocio.FuncionariosNegocio funcManager = new ControleFeriasNegocio.FuncionariosNegocio();
            List<ControleFeriasNegocio.Dominio.Funcionario> funcionarios = funcManager.BuscarTodosFuncionarios();
            CacheFuncionarios = funcionarios;
            GerarTabelaFuncionarios(funcionarios);
            CarregarSeletorFuncionarios(funcionarios);
        }


        #region CadastroFuncionarios
        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            var funcionariosManager = new ControleFeriasNegocio.FuncionariosNegocio();
            string nome = txtNomeFuncionario.Text;
            string setor = comboSetores.SelectedItem.ToString();
            funcionariosManager.CadastrarFuncionario(nome, setor);

        }
        
        private void CarregarSeletorSetores(List<ControleFeriasNegocio.Dominio.GrupoFuncionario> setores)
        {
            comboSetores.Items.Clear();
            foreach (var setor in setores)
            {
                comboSetores.Items.Add(setor.Nome);
            }
        }

        #endregion

        #region CadastroSetores
        private void btnCadastraSetor_Click(object sender, EventArgs e)
        {
            ControleFeriasNegocio.GrupoFuncionarioNegocio grupoManager = new ControleFeriasNegocio.GrupoFuncionarioNegocio();
            grupoManager.CriarGrupo(txtBoxNomeSetor.Text);
            CarregarSetores();
        }

        private void GerarTabelaSetores(List<ControleFeriasNegocio.Dominio.GrupoFuncionario> setores)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Nome");

            foreach (var setor in setores)
            {
                dataTable.Rows.Add(ConverterParaLinhaTabela(setor));
            }

            dataGridSetores.DataSource = dataTable;
        }
        
        private object[] ConverterParaLinhaTabela(ControleFeriasNegocio.Dominio.GrupoFuncionario setor)
        {
            object[] resultado = new object[2];

            resultado[0] = setor.Id;
            resultado[1] = setor.Nome;

            return resultado;
        }

        #endregion

        #region CadastroFerias
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
            feriasManager.CadastrarFerias(funcionario.Identificador, inicio, fim);

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
            dataTable.Columns.Add("Início");
            dataTable.Columns.Add("Fim");

            foreach (var periodo in ferias)
            {
                dataTable.Rows.Add(ConverterParaLinhaTabela(periodo));
            }

            dataGridFeriasFuncionario.DataSource = dataTable;
        }

        private object[] ConverterParaLinhaTabela(ControleFeriasNegocio.Dominio.Ferias ferias)
        {
            object[] resultado = new object[3];

            var dias = (ferias.DataFim - ferias.DataInicio).TotalDays;
            resultado[0] = dias;
            resultado[1] = ferias.DataInicio.ToString(FORMATO_DATA_FERIAS);
            resultado[2] = ferias.DataFim.ToString(FORMATO_DATA_FERIAS);

            return resultado;
        }

        private void numDias_ValueChanged(object sender, EventArgs e)
        {
            dateTimeFim.Value = dateTimeInicio.Value.AddDays(numDias.Value.ToDouble());
        }
        #endregion

        private ControleFeriasNegocio.Dominio.Funcionario BuscarFuncionarioCache(string nome)
        {
            return CacheFuncionarios.FirstOrDefault(f => f.Nome == nome);
        }

        private void comboFuncionariosFerias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarFeriasFuncionario();
        }

    }
}

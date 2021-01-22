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

        public Form1()
        {
            InitializeComponent();
            CarregarSetores();
            CarregarFuncionarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
                case 3:
                    CarregarFeriados();
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
            dataGridSetores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridSetores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        
        private object[] ConverterParaLinhaTabela(ControleFeriasNegocio.Dominio.GrupoFuncionario setor)
        {
            object[] resultado = new object[2];

            resultado[0] = setor.Id;
            resultado[1] = setor.Nome;

            return resultado;
        }

        #endregion

        
        private ControleFeriasNegocio.Dominio.Funcionario BuscarFuncionarioCache(string nome)
        {
            return CacheFuncionarios.FirstOrDefault(f => f.Nome == nome);
        }

        #region Relatórios
        private void btnFeriasSetor_Click(object sender, EventArgs e)
        {
            Relatorios.GerarRelatorioFeriasPorSetor(comboSetorRelatorio.SelectedItem.ToString());
        }

        #endregion

    }
}

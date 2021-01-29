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
        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            var funcionariosManager = new ControleFeriasNegocio.FuncionariosNegocio();
            string nome = txtNomeFuncionario.Text;
            string setor = comboSetores.SelectedItem?.ToString();
            bool servidor = checkServidor.Checked;
            var resp = funcionariosManager.CadastrarFuncionario(nome, setor, servidor);
            if (!resp.Sucesso)
            {
                MessageBox.Show(resp.MensagemErro);
            }
            CarregarFuncionarios();
        }

        private void CarregarSeletorSetores(List<ControleFeriasNegocio.Dominio.GrupoFuncionario> setores)
        {
            comboSetores.Items.Clear();
            comboSetorRelatorio.Items.Clear();
            foreach (var setor in setores)
            {
                comboSetores.Items.Add(setor.Nome);
                comboSetorRelatorio.Items.Add(setor.Nome);
            }
        }

        private void GerarTabelaFuncionarios(List<ControleFeriasNegocio.Dominio.Funcionario> funcionarios)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Setor");
            dataTable.Columns.Add("Servidor");

            foreach (var funcionario in funcionarios)
            {
                dataTable.Rows.Add(ConverterParaLinhaTabela(funcionario));
            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private object[] ConverterParaLinhaTabela(ControleFeriasNegocio.Dominio.Funcionario funcionario)
        {
            object[] resultado = new object[4];

            resultado[0] = funcionario.Identificador;
            resultado[1] = funcionario.Nome;
            resultado[2] = funcionario.Grupo.Nome;
            resultado[3] = funcionario.Servidor.SimOuNao();

            return resultado;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnRemoverFuncionario.Enabled = dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0;
        }

        private void btnRemoverFuncionario_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Tem certeza que deseja remover o funcionário selecionado?", "Remover funcionário", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                var linhaSelecionada = dataGridView1.SelectedRows;
                var id = Convert.ToInt32(linhaSelecionada[0].Cells[0].Value);
                new ControleFeriasNegocio.FuncionariosNegocio().RemoverFuncionario(id);
                CarregarFuncionarios();
            }
        }
    }
}

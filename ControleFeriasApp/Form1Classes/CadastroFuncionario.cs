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
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Setor");
            dataTable.Columns.Add("Servidor");

            foreach (var funcionario in funcionarios)
            {
                dataTable.Rows.Add(ConverterParaLinhaTabela(funcionario));
            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private object[] ConverterParaLinhaTabela(ControleFeriasNegocio.Dominio.Funcionario funcionario)
        {
            object[] resultado = new object[3];

            resultado[0] = funcionario.Nome;
            resultado[1] = funcionario.Grupo.Nome;
            resultado[2] = funcionario.Servidor.SimOuNao();

            return resultado;
        }
    }
}

namespace ControleFeriasApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastraSetor = new System.Windows.Forms.Button();
            this.txtBoxNomeSetor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSetores = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridSetores = new System.Windows.Forms.DataGridView();
            this.tabFuncionarios = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboSetores = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabFerias = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridFeriasFuncionario = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarFerias = new System.Windows.Forms.Button();
            this.dateTimeFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboFuncionariosFerias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSetores.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSetores)).BeginInit();
            this.tabFuncionarios.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabFerias.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFeriasFuncionario)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadastraSetor);
            this.groupBox1.Controls.Add(this.txtBoxNomeSetor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Setor";
            // 
            // btnCadastraSetor
            // 
            this.btnCadastraSetor.Location = new System.Drawing.Point(29, 55);
            this.btnCadastraSetor.Name = "btnCadastraSetor";
            this.btnCadastraSetor.Size = new System.Drawing.Size(142, 23);
            this.btnCadastraSetor.TabIndex = 2;
            this.btnCadastraSetor.Text = "Cadastrar";
            this.btnCadastraSetor.UseVisualStyleBackColor = true;
            this.btnCadastraSetor.Click += new System.EventHandler(this.btnCadastraSetor_Click);
            // 
            // txtBoxNomeSetor
            // 
            this.txtBoxNomeSetor.Location = new System.Drawing.Point(61, 29);
            this.txtBoxNomeSetor.Name = "txtBoxNomeSetor";
            this.txtBoxNomeSetor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomeSetor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSetores);
            this.tabControl1.Controls.Add(this.tabFuncionarios);
            this.tabControl1.Controls.Add(this.tabFerias);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 354);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabSetores
            // 
            this.tabSetores.Controls.Add(this.groupBox2);
            this.tabSetores.Controls.Add(this.groupBox1);
            this.tabSetores.Location = new System.Drawing.Point(4, 22);
            this.tabSetores.Name = "tabSetores";
            this.tabSetores.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetores.Size = new System.Drawing.Size(658, 328);
            this.tabSetores.TabIndex = 0;
            this.tabSetores.Text = "Setores";
            this.tabSetores.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridSetores);
            this.groupBox2.Location = new System.Drawing.Point(262, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 262);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setores";
            // 
            // dataGridSetores
            // 
            this.dataGridSetores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSetores.Location = new System.Drawing.Point(9, 19);
            this.dataGridSetores.Name = "dataGridSetores";
            this.dataGridSetores.Size = new System.Drawing.Size(240, 150);
            this.dataGridSetores.TabIndex = 4;
            // 
            // tabFuncionarios
            // 
            this.tabFuncionarios.Controls.Add(this.groupBox4);
            this.tabFuncionarios.Controls.Add(this.groupBox3);
            this.tabFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionarios.Name = "tabFuncionarios";
            this.tabFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionarios.Size = new System.Drawing.Size(658, 328);
            this.tabFuncionarios.TabIndex = 1;
            this.tabFuncionarios.Text = "Funcionários";
            this.tabFuncionarios.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(281, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 222);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funcionários";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboSetores);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnCadastroFuncionario);
            this.groupBox3.Controls.Add(this.txtNomeFuncionario);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(19, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 138);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastro de Funcionário";
            // 
            // comboSetores
            // 
            this.comboSetores.FormattingEnabled = true;
            this.comboSetores.Location = new System.Drawing.Point(61, 66);
            this.comboSetores.Name = "comboSetores";
            this.comboSetores.Size = new System.Drawing.Size(100, 21);
            this.comboSetores.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Setor:";
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(19, 105);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(142, 23);
            this.btnCadastroFuncionario.TabIndex = 2;
            this.btnCadastroFuncionario.Text = "Cadastrar";
            this.btnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(61, 29);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFuncionario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // tabFerias
            // 
            this.tabFerias.Controls.Add(this.groupBox6);
            this.tabFerias.Controls.Add(this.groupBox5);
            this.tabFerias.Location = new System.Drawing.Point(4, 22);
            this.tabFerias.Name = "tabFerias";
            this.tabFerias.Size = new System.Drawing.Size(658, 328);
            this.tabFerias.TabIndex = 2;
            this.tabFerias.Text = "Registro de Férias";
            this.tabFerias.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridFeriasFuncionario);
            this.groupBox6.Location = new System.Drawing.Point(317, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(302, 232);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Férias do Funcionário";
            // 
            // dataGridFeriasFuncionario
            // 
            this.dataGridFeriasFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFeriasFuncionario.Location = new System.Drawing.Point(6, 19);
            this.dataGridFeriasFuncionario.Name = "dataGridFeriasFuncionario";
            this.dataGridFeriasFuncionario.Size = new System.Drawing.Size(290, 207);
            this.dataGridFeriasFuncionario.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numDias);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btnCadastrarFerias);
            this.groupBox5.Controls.Add(this.dateTimeFim);
            this.groupBox5.Controls.Add(this.dateTimeInicio);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.comboFuncionariosFerias);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(22, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 232);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cadastrar Férias";
            // 
            // btnCadastrarFerias
            // 
            this.btnCadastrarFerias.Location = new System.Drawing.Point(51, 183);
            this.btnCadastrarFerias.Name = "btnCadastrarFerias";
            this.btnCadastrarFerias.Size = new System.Drawing.Size(98, 23);
            this.btnCadastrarFerias.TabIndex = 11;
            this.btnCadastrarFerias.Text = "Registrar";
            this.btnCadastrarFerias.UseVisualStyleBackColor = true;
            this.btnCadastrarFerias.Click += new System.EventHandler(this.btnCadastrarFerias_Click);
            // 
            // dateTimeFim
            // 
            this.dateTimeFim.CustomFormat = "dd/MM/yyyy";
            this.dateTimeFim.Enabled = false;
            this.dateTimeFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFim.Location = new System.Drawing.Point(93, 147);
            this.dateTimeFim.Name = "dateTimeFim";
            this.dateTimeFim.Size = new System.Drawing.Size(100, 20);
            this.dateTimeFim.TabIndex = 10;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.CustomFormat = "dd/MM/yyyy";
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInicio.Location = new System.Drawing.Point(93, 77);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(100, 20);
            this.dateTimeInicio.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Início";
            // 
            // comboFuncionariosFerias
            // 
            this.comboFuncionariosFerias.FormattingEnabled = true;
            this.comboFuncionariosFerias.Location = new System.Drawing.Point(93, 27);
            this.comboFuncionariosFerias.Name = "comboFuncionariosFerias";
            this.comboFuncionariosFerias.Size = new System.Drawing.Size(156, 21);
            this.comboFuncionariosFerias.TabIndex = 6;
            this.comboFuncionariosFerias.SelectedIndexChanged += new System.EventHandler(this.comboFuncionariosFerias_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Funcionário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dias:";
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(93, 111);
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(56, 20);
            this.numDias.TabIndex = 13;
            this.numDias.ValueChanged += new System.EventHandler(this.numDias_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSetores.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSetores)).EndInit();
            this.tabFuncionarios.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabFerias.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFeriasFuncionario)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastraSetor;
        private System.Windows.Forms.TextBox txtBoxNomeSetor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSetores;
        private System.Windows.Forms.TabPage tabFuncionarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridSetores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboSetores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastroFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabFerias;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboFuncionariosFerias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrarFerias;
        private System.Windows.Forms.DateTimePicker dateTimeFim;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridFeriasFuncionario;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.Label label7;
    }
}


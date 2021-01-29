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
            this.btnRemoverFuncionario = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkServidor = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboSetores = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabFerias = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnRemoverFerias = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.numUpDownNovoFerias = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAlterarFerias = new System.Windows.Forms.Button();
            this.dateNovoFimFerias = new System.Windows.Forms.DateTimePicker();
            this.dateNovoInicioFerias = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridFeriasFuncionario = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrarFerias = new System.Windows.Forms.Button();
            this.dateTimeFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboFuncionariosFerias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabFeriados = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.gridFeriadosMoveis = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.gridFeriados = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.anualCheck = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textFeriado = new System.Windows.Forms.TextBox();
            this.btnRegistrarFeriado = new System.Windows.Forms.Button();
            this.datePickerFeriado = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabRelatorios = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboSetorRelatorio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFeriasSetor = new System.Windows.Forms.Button();
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
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNovoFerias)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFeriasFuncionario)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.tabFeriados.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFeriadosMoveis)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFeriados)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.tabRelatorios.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 520);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadastraSetor);
            this.groupBox1.Controls.Add(this.txtBoxNomeSetor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Grupo";
            // 
            // btnCadastraSetor
            // 
            this.btnCadastraSetor.Location = new System.Drawing.Point(93, 71);
            this.btnCadastraSetor.Name = "btnCadastraSetor";
            this.btnCadastraSetor.Size = new System.Drawing.Size(142, 30);
            this.btnCadastraSetor.TabIndex = 2;
            this.btnCadastraSetor.Text = "Cadastrar";
            this.btnCadastraSetor.UseVisualStyleBackColor = true;
            this.btnCadastraSetor.Click += new System.EventHandler(this.btnCadastraSetor_Click);
            // 
            // txtBoxNomeSetor
            // 
            this.txtBoxNomeSetor.Location = new System.Drawing.Point(77, 29);
            this.txtBoxNomeSetor.Name = "txtBoxNomeSetor";
            this.txtBoxNomeSetor.Size = new System.Drawing.Size(226, 24);
            this.txtBoxNomeSetor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSetores);
            this.tabControl1.Controls.Add(this.tabFuncionarios);
            this.tabControl1.Controls.Add(this.tabFerias);
            this.tabControl1.Controls.Add(this.tabFeriados);
            this.tabControl1.Controls.Add(this.tabRelatorios);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 600);
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
            this.tabSetores.Size = new System.Drawing.Size(1032, 574);
            this.tabSetores.TabIndex = 0;
            this.tabSetores.Text = "Grupos";
            this.tabSetores.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridSetores);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(339, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 447);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupos";
            // 
            // dataGridSetores
            // 
            this.dataGridSetores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSetores.Location = new System.Drawing.Point(9, 19);
            this.dataGridSetores.Name = "dataGridSetores";
            this.dataGridSetores.Size = new System.Drawing.Size(672, 422);
            this.dataGridSetores.TabIndex = 4;
            // 
            // tabFuncionarios
            // 
            this.tabFuncionarios.Controls.Add(this.btnRemoverFuncionario);
            this.tabFuncionarios.Controls.Add(this.groupBox4);
            this.tabFuncionarios.Controls.Add(this.groupBox3);
            this.tabFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionarios.Name = "tabFuncionarios";
            this.tabFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionarios.Size = new System.Drawing.Size(1032, 574);
            this.tabFuncionarios.TabIndex = 1;
            this.tabFuncionarios.Text = "Funcionários";
            this.tabFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnRemoverFuncionario
            // 
            this.btnRemoverFuncionario.Enabled = false;
            this.btnRemoverFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverFuncionario.Location = new System.Drawing.Point(153, 222);
            this.btnRemoverFuncionario.Name = "btnRemoverFuncionario";
            this.btnRemoverFuncionario.Size = new System.Drawing.Size(142, 26);
            this.btnRemoverFuncionario.TabIndex = 6;
            this.btnRemoverFuncionario.Text = "Remover";
            this.btnRemoverFuncionario.UseVisualStyleBackColor = true;
            this.btnRemoverFuncionario.Click += new System.EventHandler(this.btnRemoverFuncionario_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(455, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 545);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funcionários";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkServidor);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboSetores);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnCadastroFuncionario);
            this.groupBox3.Controls.Add(this.txtNomeFuncionario);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 172);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastro de Funcionário";
            // 
            // checkServidor
            // 
            this.checkServidor.AutoSize = true;
            this.checkServidor.Location = new System.Drawing.Point(88, 112);
            this.checkServidor.Name = "checkServidor";
            this.checkServidor.Size = new System.Drawing.Size(15, 14);
            this.checkServidor.TabIndex = 18;
            this.checkServidor.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Servidor:";
            // 
            // comboSetores
            // 
            this.comboSetores.FormattingEnabled = true;
            this.comboSetores.Location = new System.Drawing.Point(88, 66);
            this.comboSetores.Name = "comboSetores";
            this.comboSetores.Size = new System.Drawing.Size(317, 26);
            this.comboSetores.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grupo:";
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(134, 134);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(142, 26);
            this.btnCadastroFuncionario.TabIndex = 2;
            this.btnCadastroFuncionario.Text = "Cadastrar";
            this.btnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(88, 29);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(317, 24);
            this.txtNomeFuncionario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // tabFerias
            // 
            this.tabFerias.Controls.Add(this.groupBox12);
            this.tabFerias.Controls.Add(this.groupBox11);
            this.tabFerias.Controls.Add(this.groupBox6);
            this.tabFerias.Controls.Add(this.groupBox5);
            this.tabFerias.Location = new System.Drawing.Point(4, 22);
            this.tabFerias.Name = "tabFerias";
            this.tabFerias.Size = new System.Drawing.Size(1032, 574);
            this.tabFerias.TabIndex = 2;
            this.tabFerias.Text = "Registro de Férias";
            this.tabFerias.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnRemoverFerias);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(22, 421);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(377, 65);
            this.groupBox12.TabIndex = 14;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Remover Período de Férias";
            // 
            // btnRemoverFerias
            // 
            this.btnRemoverFerias.Enabled = false;
            this.btnRemoverFerias.Location = new System.Drawing.Point(112, 29);
            this.btnRemoverFerias.Name = "btnRemoverFerias";
            this.btnRemoverFerias.Size = new System.Drawing.Size(142, 26);
            this.btnRemoverFerias.TabIndex = 11;
            this.btnRemoverFerias.Text = "Remover";
            this.btnRemoverFerias.UseVisualStyleBackColor = true;
            this.btnRemoverFerias.Click += new System.EventHandler(this.btnRemoverFerias_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.numUpDownNovoFerias);
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Controls.Add(this.btnAlterarFerias);
            this.groupBox11.Controls.Add(this.dateNovoFimFerias);
            this.groupBox11.Controls.Add(this.dateNovoInicioFerias);
            this.groupBox11.Controls.Add(this.label14);
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(22, 251);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(377, 164);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Editar Férias";
            // 
            // numUpDownNovoFerias
            // 
            this.numUpDownNovoFerias.Enabled = false;
            this.numUpDownNovoFerias.Location = new System.Drawing.Point(93, 59);
            this.numUpDownNovoFerias.Name = "numUpDownNovoFerias";
            this.numUpDownNovoFerias.Size = new System.Drawing.Size(56, 24);
            this.numUpDownNovoFerias.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Dias:";
            // 
            // btnAlterarFerias
            // 
            this.btnAlterarFerias.Enabled = false;
            this.btnAlterarFerias.Location = new System.Drawing.Point(112, 131);
            this.btnAlterarFerias.Name = "btnAlterarFerias";
            this.btnAlterarFerias.Size = new System.Drawing.Size(142, 26);
            this.btnAlterarFerias.TabIndex = 11;
            this.btnAlterarFerias.Text = "Alterar";
            this.btnAlterarFerias.UseVisualStyleBackColor = true;
            // 
            // dateNovoFimFerias
            // 
            this.dateNovoFimFerias.CustomFormat = "dd/MM/yyyy";
            this.dateNovoFimFerias.Enabled = false;
            this.dateNovoFimFerias.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNovoFimFerias.Location = new System.Drawing.Point(93, 95);
            this.dateNovoFimFerias.Name = "dateNovoFimFerias";
            this.dateNovoFimFerias.Size = new System.Drawing.Size(100, 24);
            this.dateNovoFimFerias.TabIndex = 10;
            // 
            // dateNovoInicioFerias
            // 
            this.dateNovoInicioFerias.CustomFormat = "dd/MM/yyyy";
            this.dateNovoInicioFerias.Enabled = false;
            this.dateNovoInicioFerias.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNovoInicioFerias.Location = new System.Drawing.Point(93, 25);
            this.dateNovoInicioFerias.Name = "dateNovoInicioFerias";
            this.dateNovoInicioFerias.Size = new System.Drawing.Size(100, 24);
            this.dateNovoInicioFerias.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 8;
            this.label14.Text = "Novo Fim";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "Novo Início";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridFeriasFuncionario);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(405, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(624, 545);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Férias do Funcionário";
            // 
            // dataGridFeriasFuncionario
            // 
            this.dataGridFeriasFuncionario.AllowUserToAddRows = false;
            this.dataGridFeriasFuncionario.AllowUserToDeleteRows = false;
            this.dataGridFeriasFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFeriasFuncionario.Location = new System.Drawing.Point(6, 19);
            this.dataGridFeriasFuncionario.MultiSelect = false;
            this.dataGridFeriasFuncionario.Name = "dataGridFeriasFuncionario";
            this.dataGridFeriasFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFeriasFuncionario.Size = new System.Drawing.Size(612, 520);
            this.dataGridFeriasFuncionario.TabIndex = 0;
            this.dataGridFeriasFuncionario.SelectionChanged += new System.EventHandler(this.dataGridFeriasFuncionario_SelectionChanged);
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
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(22, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(377, 219);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Novo Registro de Férias";
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(93, 102);
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(56, 24);
            this.numDias.TabIndex = 13;
            this.numDias.ValueChanged += new System.EventHandler(this.numDias_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dias:";
            // 
            // btnCadastrarFerias
            // 
            this.btnCadastrarFerias.Location = new System.Drawing.Point(112, 177);
            this.btnCadastrarFerias.Name = "btnCadastrarFerias";
            this.btnCadastrarFerias.Size = new System.Drawing.Size(142, 26);
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
            this.dateTimeFim.Location = new System.Drawing.Point(93, 136);
            this.dateTimeFim.Name = "dateTimeFim";
            this.dateTimeFim.Size = new System.Drawing.Size(100, 24);
            this.dateTimeFim.TabIndex = 10;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.CustomFormat = "dd/MM/yyyy";
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInicio.Location = new System.Drawing.Point(93, 68);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(100, 24);
            this.dateTimeInicio.TabIndex = 9;
            this.dateTimeInicio.ValueChanged += new System.EventHandler(this.dateTimeInicio_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Início";
            // 
            // comboFuncionariosFerias
            // 
            this.comboFuncionariosFerias.FormattingEnabled = true;
            this.comboFuncionariosFerias.Location = new System.Drawing.Point(93, 27);
            this.comboFuncionariosFerias.Name = "comboFuncionariosFerias";
            this.comboFuncionariosFerias.Size = new System.Drawing.Size(278, 26);
            this.comboFuncionariosFerias.TabIndex = 6;
            this.comboFuncionariosFerias.SelectedIndexChanged += new System.EventHandler(this.comboFuncionariosFerias_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Funcionário";
            // 
            // tabFeriados
            // 
            this.tabFeriados.Controls.Add(this.groupBox10);
            this.tabFeriados.Controls.Add(this.groupBox9);
            this.tabFeriados.Controls.Add(this.groupBox8);
            this.tabFeriados.Location = new System.Drawing.Point(4, 22);
            this.tabFeriados.Name = "tabFeriados";
            this.tabFeriados.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeriados.Size = new System.Drawing.Size(1032, 574);
            this.tabFeriados.TabIndex = 4;
            this.tabFeriados.Text = "Feriados";
            this.tabFeriados.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.gridFeriadosMoveis);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(398, 267);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(618, 301);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Feriados Móveis";
            // 
            // gridFeriadosMoveis
            // 
            this.gridFeriadosMoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFeriadosMoveis.Location = new System.Drawing.Point(6, 19);
            this.gridFeriadosMoveis.Name = "gridFeriadosMoveis";
            this.gridFeriadosMoveis.Size = new System.Drawing.Size(606, 276);
            this.gridFeriadosMoveis.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.gridFeriados);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(398, 20);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(618, 241);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Feriados Fixos";
            // 
            // gridFeriados
            // 
            this.gridFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFeriados.Location = new System.Drawing.Point(6, 19);
            this.gridFeriados.Name = "gridFeriados";
            this.gridFeriados.Size = new System.Drawing.Size(606, 210);
            this.gridFeriados.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.anualCheck);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.textFeriado);
            this.groupBox8.Controls.Add(this.btnRegistrarFeriado);
            this.groupBox8.Controls.Add(this.datePickerFeriado);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(18, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(374, 166);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Cadastrar Feriado";
            // 
            // anualCheck
            // 
            this.anualCheck.AutoSize = true;
            this.anualCheck.Location = new System.Drawing.Point(64, 100);
            this.anualCheck.Name = "anualCheck";
            this.anualCheck.Size = new System.Drawing.Size(15, 14);
            this.anualCheck.TabIndex = 16;
            this.anualCheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fixo:";
            // 
            // textFeriado
            // 
            this.textFeriado.Location = new System.Drawing.Point(64, 27);
            this.textFeriado.Name = "textFeriado";
            this.textFeriado.Size = new System.Drawing.Size(304, 24);
            this.textFeriado.TabIndex = 14;
            // 
            // btnRegistrarFeriado
            // 
            this.btnRegistrarFeriado.Location = new System.Drawing.Point(116, 122);
            this.btnRegistrarFeriado.Name = "btnRegistrarFeriado";
            this.btnRegistrarFeriado.Size = new System.Drawing.Size(142, 26);
            this.btnRegistrarFeriado.TabIndex = 11;
            this.btnRegistrarFeriado.Text = "Registrar";
            this.btnRegistrarFeriado.UseVisualStyleBackColor = true;
            this.btnRegistrarFeriado.Click += new System.EventHandler(this.btnRegistrarFeriado_Click);
            // 
            // datePickerFeriado
            // 
            this.datePickerFeriado.CustomFormat = "dd/MM/yyyy";
            this.datePickerFeriado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerFeriado.Location = new System.Drawing.Point(64, 57);
            this.datePickerFeriado.Name = "datePickerFeriado";
            this.datePickerFeriado.Size = new System.Drawing.Size(121, 24);
            this.datePickerFeriado.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Data:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Feriado";
            // 
            // tabRelatorios
            // 
            this.tabRelatorios.Controls.Add(this.groupBox7);
            this.tabRelatorios.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorios.Name = "tabRelatorios";
            this.tabRelatorios.Size = new System.Drawing.Size(1032, 574);
            this.tabRelatorios.TabIndex = 3;
            this.tabRelatorios.Text = "Relatórios";
            this.tabRelatorios.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboSetorRelatorio);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.btnFeriasSetor);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(25, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(326, 125);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Férias por setor";
            // 
            // comboSetorRelatorio
            // 
            this.comboSetorRelatorio.FormattingEnabled = true;
            this.comboSetorRelatorio.Location = new System.Drawing.Point(73, 31);
            this.comboSetorRelatorio.Name = "comboSetorRelatorio";
            this.comboSetorRelatorio.Size = new System.Drawing.Size(247, 26);
            this.comboSetorRelatorio.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Setor:";
            // 
            // btnFeriasSetor
            // 
            this.btnFeriasSetor.Location = new System.Drawing.Point(93, 76);
            this.btnFeriasSetor.Name = "btnFeriasSetor";
            this.btnFeriasSetor.Size = new System.Drawing.Size(142, 26);
            this.btnFeriasSetor.TabIndex = 5;
            this.btnFeriasSetor.Text = "Relatório";
            this.btnFeriasSetor.UseVisualStyleBackColor = true;
            this.btnFeriasSetor.Click += new System.EventHandler(this.btnFeriasSetor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNovoFerias)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFeriasFuncionario)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.tabFeriados.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFeriadosMoveis)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFeriados)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabRelatorios.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private System.Windows.Forms.TabPage tabRelatorios;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboSetorRelatorio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFeriasSetor;
        private System.Windows.Forms.TabPage tabFeriados;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView gridFeriados;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textFeriado;
        private System.Windows.Forms.Button btnRegistrarFeriado;
        private System.Windows.Forms.DateTimePicker datePickerFeriado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox anualCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridView gridFeriadosMoveis;
        private System.Windows.Forms.CheckBox checkServidor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnRemoverFerias;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.NumericUpDown numUpDownNovoFerias;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAlterarFerias;
        private System.Windows.Forms.DateTimePicker dateNovoFimFerias;
        private System.Windows.Forms.DateTimePicker dateNovoInicioFerias;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRemoverFuncionario;
    }
}


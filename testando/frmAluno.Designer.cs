namespace cadastro
{
    partial class frmAluno
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAluno));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.DataGridAlunos = new System.Windows.Forms.DataGridView();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonModificar);
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.textBoxMatricula);
            this.groupBox1.Controls.Add(this.buttonAdicionar);
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.textBoxCpf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maskedTextBoxNascimento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxSexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.White;
            this.buttonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonModificar.ForeColor = System.Drawing.Color.Black;
            this.buttonModificar.Location = new System.Drawing.Point(807, 120);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(131, 54);
            this.buttonModificar.TabIndex = 13;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Visible = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Location = new System.Drawing.Point(669, 120);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(131, 54);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.textBoxMatricula.Location = new System.Drawing.Point(41, 56);
            this.textBoxMatricula.MaxLength = 9;
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(187, 32);
            this.textBoxMatricula.TabIndex = 1;
            this.textBoxMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMatricula_KeyPress_1);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.White;
            this.buttonAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonAdicionar.ForeColor = System.Drawing.Color.Black;
            this.buttonAdicionar.Location = new System.Drawing.Point(807, 120);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(131, 54);
            this.buttonAdicionar.TabIndex = 11;
            this.buttonAdicionar.Text = "ADICIONAR";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.White;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonLimpar.ForeColor = System.Drawing.Color.Black;
            this.buttonLimpar.Location = new System.Drawing.Point(669, 120);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(131, 54);
            this.buttonLimpar.TabIndex = 10;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.textBoxCpf.Location = new System.Drawing.Point(422, 133);
            this.textBoxCpf.MaxLength = 11;
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(213, 32);
            this.textBoxCpf.TabIndex = 9;
            this.textBoxCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCpf_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label6.Location = new System.Drawing.Point(418, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF";
            // 
            // maskedTextBoxNascimento
            // 
            this.maskedTextBoxNascimento.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.maskedTextBoxNascimento.Location = new System.Drawing.Point(254, 133);
            this.maskedTextBoxNascimento.Mask = "00/00/0000";
            this.maskedTextBoxNascimento.Name = "maskedTextBoxNascimento";
            this.maskedTextBoxNascimento.Size = new System.Drawing.Size(134, 32);
            this.maskedTextBoxNascimento.TabIndex = 7;
            this.maskedTextBoxNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label5.Location = new System.Drawing.Point(250, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "NASCIMENTO";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSexo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBoxSexo.Location = new System.Drawing.Point(41, 132);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(187, 32);
            this.comboBoxSexo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label4.Location = new System.Drawing.Point(37, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "SEXO";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.textBoxNome.Location = new System.Drawing.Point(254, 56);
            this.textBoxNome.MaxLength = 100;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(684, 32);
            this.textBoxNome.TabIndex = 3;
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label3.Location = new System.Drawing.Point(250, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label2.Location = new System.Drawing.Point(37, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "MATRÍCULA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo aluno";
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.textBoxPesquisar.Location = new System.Drawing.Point(53, 240);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(746, 32);
            this.textBoxPesquisar.TabIndex = 12;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.Black;
            this.buttonPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonPesquisar.ForeColor = System.Drawing.Color.White;
            this.buttonPesquisar.Location = new System.Drawing.Point(805, 240);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(145, 32);
            this.buttonPesquisar.TabIndex = 13;
            this.buttonPesquisar.Text = "PESQUISAR";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // DataGridAlunos
            // 
            this.DataGridAlunos.AllowUserToAddRows = false;
            this.DataGridAlunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.DataGridAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridAlunos.AutoGenerateColumns = false;
            this.DataGridAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridAlunos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn});
            this.DataGridAlunos.DataSource = this.bindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridAlunos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridAlunos.Location = new System.Drawing.Point(53, 291);
            this.DataGridAlunos.MultiSelect = false;
            this.DataGridAlunos.Name = "DataGridAlunos";
            this.DataGridAlunos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridAlunos.RowHeadersWidth = 51;
            this.DataGridAlunos.RowTemplate.Height = 24;
            this.DataGridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridAlunos.Size = new System.Drawing.Size(897, 214);
            this.DataGridAlunos.TabIndex = 14;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.FillWeight = 50.43859F;
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 133.6898F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.FillWeight = 105.2905F;
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.FillWeight = 105.2905F;
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.FillWeight = 105.2905F;
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            this.bindingSource1.DataSource = typeof(EM.Domain.Aluno);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(819, 514);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 37);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "EXCLUIR";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(682, 514);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(131, 37);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "EDITAR";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1000, 558);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.DataGridAlunos);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNascimento;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DataGridView DataGridAlunos;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonModificar;
    }
}


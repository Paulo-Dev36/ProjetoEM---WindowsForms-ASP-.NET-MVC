using EM.Domain;
using EM.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace cadastro
{
    public partial class frmAluno : Form
    {
        RepositorioAluno repositorioAluno = new RepositorioAluno();
        Aluno aluno = new Aluno();
        DataTable dtTable = new DataTable();
        ValidaALuno validaAluno = new ValidaALuno();
        public frmAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repositorioAluno.ConexaoBanco();
            comboBoxSexo.SelectedIndex = 1;
            AddColunasTabela();
            GridAlunos(repositorioAluno.GetAll());
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
                e.Handled = true;
        }

        private void textBoxMatricula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (char)Keys.Back != e.KeyChar)
                e.Handled = true;
        }

        private void textBoxCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (char)Keys.Back != e.KeyChar)
                e.Handled = true;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (!validaAluno.ValidaMatriculaVazia(textBoxMatricula.Text))
                return;            

            aluno.Matricula = Int32.Parse(textBoxMatricula.Text);
            if (!validaAluno.ValidaMatricula(aluno.Matricula))
                return;

            aluno.Nome = textBoxNome.Text;
            if (!validaAluno.ValidoNome(aluno.Nome))
            {
                textBoxNome.Focus();
                return;
            }

            aluno.Sexo = comboBoxSexo.Text.Equals("Masculino") ? EnumeradorSexo.Masculino : EnumeradorSexo.Feminino;

            if (!maskedTextBoxNascimento.MaskFull)
            {
                MessageBox.Show("Data de nascimento obrigatória!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxNascimento.Focus();
                return;
            }
            DateTime.TryParse(maskedTextBoxNascimento.Text, out DateTime dateTime);
            aluno.Nascimento = dateTime;
            if (!validaAluno.ValidoNascimento(dateTime))
            {
                maskedTextBoxNascimento.Focus();
                return;
            }
            aluno.CPF = textBoxCpf.Text;

            if (!validaAluno.ValidoCPF(aluno.CPF))
            {
                textBoxCpf.Focus();
                return;
            }

            if (!validaAluno.CpfRepetido(aluno.CPF, aluno.Matricula))
            {
                textBoxCpf.Focus();
                return;
            }
            repositorioAluno.Add(aluno);
            limparCampos();
            GridAlunos(repositorioAluno.GetAll());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (DataGridAlunos.Rows.Count > 0)
            {
                textBoxMatricula.Text = DataGridAlunos.CurrentRow.Cells[0].Value.ToString();
                textBoxNome.Text = DataGridAlunos.CurrentRow.Cells[1].Value.ToString();
                comboBoxSexo.SelectedIndex = (int)DataGridAlunos.CurrentRow.Cells[2].Value;
                maskedTextBoxNascimento.Text = DataGridAlunos.CurrentRow.Cells[3].Value.ToString();
                textBoxCpf.Text = DataGridAlunos.CurrentRow.Cells[4].Value.ToString();

                textBoxMatricula.ReadOnly = true;
                buttonLimpar.Visible = false;
                buttonCancelar.Visible = true;
                buttonAdicionar.Visible = false;
                buttonModificar.Visible = true;
                mudarLabelInicial();
            }
            if (string.IsNullOrEmpty(textBoxMatricula.Text)) 
            { 
            MessageBox.Show("Nenhum aluno selecionado.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return;
        }

        private void mudarLabelInicial()
        {

            if (buttonCancelar.Visible == true)
            {
                label1.Text = "Editar dados do Aluno";
            }
            else
            {
                label1.Text = "Adicionar Novo Aluno";
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (DataGridAlunos.Rows.Count > 0)
            {
                aluno = new Aluno()
                {
                    Matricula = (int)DataGridAlunos.CurrentRow.Cells[0].Value,
                };
            }
            else
            {
                MessageBox.Show("Nenhum aluno selecionado.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Deseja continuar com a exclusão do aluno?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                repositorioAluno.Remove(aluno);
                aluno.Nome = DataGridAlunos.CurrentRow.Cells[1].Value.ToString();
                GridAlunos(repositorioAluno.GetAll());
                MessageBox.Show($"Aluno {aluno.Nome} foi excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonLimpar.Visible = true;
            buttonCancelar.Visible = false;
            buttonAdicionar.Visible = true;
            buttonModificar.Visible = false;
            limparCampos();
            mudarLabelInicial();
            textBoxMatricula.ReadOnly = false;
            GridAlunos(repositorioAluno.GetAll());
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            aluno = new Aluno();

            aluno.Matricula = int.Parse(textBoxMatricula.Text);

            aluno.Nome = textBoxNome.Text;
            if (!validaAluno.ValidoNome(aluno.Nome))
            {
                textBoxNome.Focus(); 
                return;
            }
            aluno.Sexo = comboBoxSexo.Text.Equals("Masculino") ? EnumeradorSexo.Masculino : EnumeradorSexo.Feminino;

            if (!maskedTextBoxNascimento.MaskFull)
            {
                MessageBox.Show("Data de nascimento obrigatória!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxNascimento.Focus();
                return;
            }
            DateTime.TryParse(maskedTextBoxNascimento.Text, out DateTime dateTime);
            aluno.Nascimento = dateTime;
            if (!validaAluno.ValidoNascimento(aluno.Nascimento))
            {
                maskedTextBoxNascimento.Focus();
                return;
            }
            aluno.CPF = textBoxCpf.Text;
            if (!validaAluno.ValidoCPF(aluno.CPF))
                return;

            if (!string.IsNullOrWhiteSpace(aluno.CPF))
            {
                if (!validaAluno.CpfRepetido(aluno.CPF, aluno.Matricula))
                    return;
            }
            
            repositorioAluno.Update(aluno);
            GridAlunos(repositorioAluno.GetAll());
            MessageBox.Show($"Os dados do aluno {aluno.Nome}, foram modificados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            buttonLimpar.Visible = true;
            buttonCancelar.Visible = false;
            buttonAdicionar.Visible = true;
            buttonModificar.Visible = false;
            limparCampos();
            mudarLabelInicial();
            textBoxMatricula.ReadOnly = false;
        }

        private void AddColunasTabela()
        {
            dtTable.Columns.Add("Matricula", typeof(int));
            dtTable.Columns.Add("Nome", typeof(string));
            dtTable.Columns.Add("Sexo", typeof(EnumeradorSexo));
            dtTable.Columns.Add("Nascimento", typeof(DateTime));
            dtTable.Columns.Add("CPF", typeof(string));
        }

        private void DadosDataTable(IEnumerable<Aluno> alunos)
        {
            dtTable.Clear();
            foreach (Aluno aluno in alunos)
            {
                dtTable.Rows.Add(aluno.Matricula, aluno.Nome, aluno.Sexo, aluno.Nascimento, aluno.CPF);
            }
        }
        private void DadosDataTable(Aluno aluno)
        {
            dtTable.Clear();
            if (aluno != null)
                dtTable.Rows.Add(aluno.Matricula, aluno.Nome, aluno.Sexo, aluno.Nascimento, aluno.CPF);
        }

        private void GridAlunos(IEnumerable<Aluno> alunos)
        {
            DadosDataTable(alunos);
            bindingSource1.DataSource = dtTable;
            DataGridAlunos.DataSource = bindingSource1;

        }
        private void GridAlunos(Aluno aluno)
        {
            DadosDataTable(aluno);
            bindingSource1.DataSource = dtTable;
            DataGridAlunos.DataSource = bindingSource1;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPesquisar.Text))
            {
                GridAlunos(repositorioAluno.GetAll());
            }
            foreach(char caracter in textBoxPesquisar.Text)
            {
                if (char.IsDigit(caracter))
                {
                    aluno.Matricula = int.Parse(textBoxPesquisar.Text);
                    GridAlunos(repositorioAluno.GetByMatricula(aluno.Matricula));
                }
                else
                {
                    aluno.Nome = textBoxPesquisar.Text;
                    GridAlunos(repositorioAluno.GetByContendoNoNome(aluno.Nome));
                }
            }
        }
        private void limparCampos()
        {
            textBoxMatricula.Clear();
            textBoxNome.Clear();
            maskedTextBoxNascimento.Clear();
            textBoxCpf.Clear();
            textBoxPesquisar.Clear();
            textBoxMatricula.Focus();
        }
    }
}


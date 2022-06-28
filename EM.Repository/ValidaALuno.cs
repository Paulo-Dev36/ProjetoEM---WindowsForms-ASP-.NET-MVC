using EM.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EM.Repository
{
    public class ValidaALuno
    {
        RepositorioAluno repositorioAluno = new RepositorioAluno();
        Aluno aluno = new Aluno();


        public bool ValidaMatricula(int matricula)
        {
            if (repositorioAluno.GetByMatricula(matricula) != null)
            {
                MessageBox.Show($"A matrícula {matricula} já está sendo utilizada, tente outro número!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            /*if (aluno.Equals(matricula))
            {
                MessageBox.Show($"A matrícula {aluno.Matricula} já está sendo utilizada, tente outro número!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMatricula.Clear();
                textBoxMatricula.Focus();
                return false;
            }*/
            return true;
        }
        public bool ValidaMatriculaVazia(string matricula)
        {
            if (string.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("Campo de matrícula obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool ValidoNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Campo do nome obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool ValidoNascimento(DateTime nascimento)
        {
            if (nascimento > DateTime.Now)
            {
                MessageBox.Show("A data de nascimento não pode ser maior que a data atual!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nascimento.Equals(DateTime.MinValue))
            {
                MessageBox.Show("A data de nascimento não é válida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool CpfRepetido(string cpf, int matricula)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return true;
            if (repositorioAluno.Get(a => a.CPF == cpf && a.Matricula != matricula).FirstOrDefault() != null)
            {
                MessageBox.Show("CPF já cadastrado.", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool ValidoCPF(string cpf)
        {
            if (!string.IsNullOrWhiteSpace(cpf))
            {
                if (cpf.Length != 11)
                {
                    MessageBox.Show("CPF Inválido. Digite 11 números válidos ou deixe em branco.", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var intCpf = new int[11];
                int soma = 0, penultimoDigito = 0, ultimoDigito = 0;

                for (int i = 0, j = 10; i < 11; i++, j--)
                {
                    var sucessoNaConversao = int.TryParse(cpf[i].ToString(), out var valor);
                    intCpf[i] = valor;

                    if (j >= 2 && sucessoNaConversao)
                    {
                        soma += intCpf[i] * j;
                    }
                }

                var cpfComTodosDigitosIguais = true;
                for (var i = 1; i < 11; i++)
                {
                    if (intCpf[0] != intCpf[i])
                    {
                        cpfComTodosDigitosIguais = false;
                        break;
                    }
                }

                if (cpfComTodosDigitosIguais)
                {
                    MessageBox.Show("CPF Inválido. Os 11 dígitos não podem ser iguais. Digite um CPF válido ou deixe em branco.", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                penultimoDigito = (soma * 10) % 11;
                if (penultimoDigito == 10)
                {
                    penultimoDigito = 0;
                }

                if (penultimoDigito != intCpf[9])
                {
                    MessageBox.Show("Informe um CPF válido!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                soma = 0;
                for (int i = 0, j = 11; j >= 2; i++, j--)
                {
                    soma += intCpf[i] * j;
                }

                ultimoDigito = (soma * 10) % 11;
                if (ultimoDigito == 10)
                {
                    ultimoDigito = 0;
                }

                if (ultimoDigito != intCpf[10])
                {
                    MessageBox.Show("Informe um CPF válido!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}

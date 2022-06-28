using System;
using System.ComponentModel.DataAnnotations;

namespace EM.Domain
{
    public class Aluno : IEntidade
    {
        [Required(ErrorMessage = "A matrícula é obrigatória!")]
        public int Matricula { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage = "O sexo do aluno é obrigatório!")]
        public EnumeradorSexo Sexo { get; set; }
        [Required(ErrorMessage = "A data de nascimento é obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Aluno aluno && aluno.Matricula == Matricula;
        }

        public override int GetHashCode()
        {
            return Matricula;
        }

        public override string ToString()
        {
            return "Matricula: " + Matricula +
                "\nNome: " + Nome +
                "\nSexo: " + Sexo +
                "\nNascimento: " + Nascimento +
                "\n CPF: " + CPF + "\n";
        }
    }   
}

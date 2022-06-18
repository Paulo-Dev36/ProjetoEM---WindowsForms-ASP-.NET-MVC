using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain
{
    public class Aluno : IEntidade
    {       

        public int Matricula { get; set; }
        public string Nome { get; set; }
        public EnumeradorSexo Sexo { get; set; }
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

using EM.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EM.Domain.Testes
{
   
    public class AlunoTeste
    {
        private RepositorioAluno repositorioAluno = new RepositorioAluno();
        private List<Aluno> allAlunos = new List<Aluno>();
        private int matricula;
        private string nome;
        private string cpf;
        private DateTime nascimento;
        private EnumeradorSexo sexo;

        [TestMethod]
        public void TestMethod1()
        {
        }

        public void MatriculaAluno(int alunomatricula)
        {
            matricula = alunomatricula;
        }
        
        public void SexoAluno(EnumeradorSexo alunosexo)
        {
            sexo = alunosexo;
        }

        public void DataDeNascimentoAluno(DateTime alunonascimento)
        {
            nascimento = alunonascimento;
        }

    }
}

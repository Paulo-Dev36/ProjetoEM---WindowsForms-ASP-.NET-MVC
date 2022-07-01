using EM.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EM.Domain.Testes
{
    [TestClass]
    public class AlunoTeste
    {
        Aluno aluno = new Aluno();
        ValidaALuno validaAluno = new ValidaALuno();
        public void Aluno()
        {
            aluno.Matricula = 9999;
            aluno.Nome = "Paulo";
            aluno.CPF = "70148832164";
            aluno.Nascimento = Convert.ToDateTime("20/04/2002");
            aluno.Sexo = (EnumeradorSexo)0;
        }

        [TestMethod]
        public void TesteMatricula()
        {
            Assert.IsTrue(aluno.Matricula <= 0 || aluno.Matricula > 999999999);
        }

        [TestMethod]
        public void TesteMatriculaDupla()
        {
            Assert.IsTrue(validaAluno.ValidaMatricula(aluno.Matricula));
        }

        [TestMethod]
        public void TesteEquals()
        {
            Aluno a = new Aluno();
            a.Matricula = 20;
            Assert.AreNotEqual(aluno.Matricula, a.Matricula);
        }

        [TestMethod]
        public void TesteString()
        {
            aluno.ToString();
        }
    }
}

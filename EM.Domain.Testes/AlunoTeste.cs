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
        
        public void Aluno(Aluno aluno)
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
            //Aluno aluno = new Aluno();
            int Matricula = 1;
            Assert.IsTrue(Matricula > 0);
        }

        [TestMethod]
        public void TesteMatriculaDupla()
        {
            Assert.IsTrue(validaAluno.EhMatriculaRepetida(aluno.Matricula));
        }

        [TestMethod]
        public void TesteEquals()
        {
            Aluno a = new Aluno();
            Aluno b = new Aluno();
            b.Matricula = 1;
            a.Matricula = 1;
            Assert.IsTrue(a.Equals(b));
        }

        [TestMethod]
        public void TesteString()
        {
            aluno.ToString( );
        }
    }
}

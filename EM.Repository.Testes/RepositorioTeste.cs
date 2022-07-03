using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EM.Repository;
using EM.Domain;
using System.Collections.Generic;
using System.Linq;

namespace EM.Repository.Testes
{
    [TestClass]
    public class RepositorioTeste
    {
        RepositorioAluno repositorioAluno = new RepositorioAluno();
        
        [TestMethod]
        public void GetAll()
        {
            Assert.IsNotNull(repositorioAluno.GetAll());
        }

        [TestMethod]
        public void Add()
        {
            Aluno aluno = new Aluno
            {
                Matricula = 105,
                Nome = "Paulo",
                Sexo = (EnumeradorSexo)0,
                Nascimento = Convert.ToDateTime("20/04/2002"),
                CPF = "70148832164"
            };

            repositorioAluno.Add(aluno);
            Assert.IsNotNull(repositorioAluno.GetByMatricula(aluno.Matricula));
        }

        [TestMethod]
        public void Update()
        {
            Aluno aluno = new Aluno
            {
                Matricula = 1000,
                Nome = "Paulo Vinicius",
                Sexo = (EnumeradorSexo)0,
                Nascimento = Convert.ToDateTime("20/04/2002"),
                CPF = ""
            };

            repositorioAluno.Update(aluno);
            Assert.IsNotNull(aluno);
        }

        [TestMethod]
        public void Remove()
        {
            Aluno aluno = new Aluno()
            {
                Matricula = 1000,
            };

            repositorioAluno.Remove(aluno);
            Assert.IsNotNull(aluno);
        }

        [TestMethod]
        public void GetByMatricula()
        {
            int matricula = 1;

            Assert.IsNotNull(repositorioAluno.GetByMatricula(matricula));
        }

        [TestMethod]
        public void GetByContendoNoNome()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Paulo";

            Assert.IsNotNull(repositorioAluno.GetByContendoNoNome(aluno.Nome));
        }
        [TestMethod]
        public void Get()
        {
            int matricula = 1;
            Assert.IsNotNull (repositorioAluno.Get(a => a.Matricula == matricula).First());
        }
    }
}

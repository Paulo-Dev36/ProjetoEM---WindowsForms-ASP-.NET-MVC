using EM.Domain;
using EM.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProjetoEMWeb.Controllers
{
    
    public class AlunoController : Controller
    {
        Aluno aluno = new();
        private readonly DataTable dtTable = new();
        readonly RepositorioAluno repositorioAluno = new();
        
        public IActionResult Index(IEnumerable<Aluno> alunos)
        {
            alunos = repositorioAluno.GetAll().ToList();

            return View(alunos);
        }

        [HttpPost]
        public IActionResult Index(string MatriculaOuNomeAluno)
        {
            List<Aluno> listaAlunos = new();
            listaAlunos = repositorioAluno.GetAll().ToList();

            if (!String.IsNullOrEmpty(MatriculaOuNomeAluno))
            {
                foreach (char caracter in MatriculaOuNomeAluno)
                {
                    if (char.IsDigit(caracter))
                    {
                        return RedirectToAction("IndexM");
                    }
                    else
                    {
                        listaAlunos = repositorioAluno.GetByContendoNoNome(MatriculaOuNomeAluno).ToList();
                        return View(listaAlunos);
                    }                    
                }
            }
            return View(listaAlunos);
        }
        
        public IActionResult IndexM(string MatriculaOuNomeAluno)
        {
            int matricula = Convert.ToInt32(MatriculaOuNomeAluno);
            matricula = 1;
            aluno = repositorioAluno.GetByMatricula(matricula);

            return View(aluno);
        }

        public ActionResult Remove(Aluno aluno)
        {
            repositorioAluno.Remove(aluno) ;
            return RedirectToAction("Index");   
        }

        public IActionResult Add() => View(aluno);

        [HttpPost]
        public IActionResult Add(Aluno aluno)
        {
            if (!ModelState.IsValid)
                return View();  

            if (!EhMatriculaValida(aluno.Matricula))
                return View();

            if (EhNomeVazio(aluno.Nome))
                return View();

            if (!EhNascimentoValido(aluno.Nascimento))
                return View();
            
            if (!ValidoCPF(aluno.CPF))
                return View();

            if (repositorioAluno.Get(a => a.CPF == aluno.CPF && a.Matricula != aluno.Matricula).FirstOrDefault() != null)
            {
                ModelState.AddModelError("CPF", "CPF já cadastrado!");
                return View();
            }

            repositorioAluno.Add(aluno);
            return RedirectToAction("Index");
        }

        public IActionResult Update(Aluno aluno, int id)
        {
            aluno = repositorioAluno.GetByMatricula(id);
            return View(aluno);
        }
        [HttpPost]
        public IActionResult Update(Aluno aluno)
        {
            if (!ModelState.IsValid)
                return View();
            
            if (EhNomeVazio(aluno.Nome))
                return View();

            if (!EhNascimentoValido(aluno.Nascimento))
                return View();

            if (!ValidoCPF(aluno.CPF))
                return View();

            if (repositorioAluno.Get(a => a.CPF == aluno.CPF && a.Matricula != aluno.Matricula).FirstOrDefault() != null)
            {
                ModelState.AddModelError("CPF", "CPF já cadastrado!");
                return View();
            }

            repositorioAluno.Update(aluno);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            repositorioAluno.Remove(repositorioAluno.GetByMatricula(id)) ;
            return RedirectToAction("Index");
        }

        private bool EhMatriculaValida(int matricula)
        {
            if(repositorioAluno.GetByMatricula(matricula) != null)
            {
                ModelState.AddModelError($"Matricula", "A matrícula já está sendo utlizada!");
                return false;
            }

            if(matricula.Equals(0))
            {
                ModelState.AddModelError("Matricula", "A matrícula deve ser um número maior que 0");
                return false;
            }
                return true;
        }

        private bool EhNomeVazio(string nome)
        {
            if(nome.Equals(null))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatório!");
                return true;
            }
            return false;
        }

        public bool EhNascimentoValido(DateTime nascimento)
        {
            if(nascimento > DateTime.Now)
            {
                ModelState.AddModelError("Nascimento", "Data de nascimento não pode ser maior que a data atual!");
                return false;
            }
            if (nascimento.Equals(DateTime.MinValue))
            {
                ModelState.AddModelError("Nascimento", "A data de nascimento não é válida!");
                return false;
            }
            return true;
        }

        private bool ValidoCPF(string cpf)
        {
            if (!string.IsNullOrWhiteSpace(cpf))
            {
                if (cpf.Length != 11)
                {
                    ModelState.AddModelError("CPF", "CPF Inválido. Digite 11 números válidos ou deixe em branco!");
                    return false;
                }

                var intCpf = new int[11];
                int soma = 0, penultimoDigito = 0, ultimoDigito = 0;

                for (int i = 0, j = 10; i < 11; i++, j--)
                {
                    var sucessoNaConversao = int.TryParse(cpf[i].ToString(), out var valor);
                    intCpf[i] = valor;

                    if (j >= 2 && sucessoNaConversao)
                        soma += intCpf[i] * j;

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
                    ModelState.AddModelError("CPF", "CPF Inválido. Os 11 dígitos não podem ser iguais. Digite um CPF válido ou deixe em branco!");
                    return false;
                }

                penultimoDigito = (soma * 10) % 11;
                if (penultimoDigito == 10)
                    penultimoDigito = 0;
                if (penultimoDigito != intCpf[9])
                {
                    ModelState.AddModelError("CPF", "Informe um CPF válido!");
                    return false;
                }

                soma = 0;
                for (int i = 0, j = 11; j >= 2; i++, j--)
                {
                    soma += intCpf[i] * j;
                }

                ultimoDigito = (soma * 10) % 11;
                if (ultimoDigito == 10)
                    ultimoDigito = 0;

                if (ultimoDigito != intCpf[10])
                {
                   ModelState.AddModelError("CPF", "Informe um CPF válido!");
                    return false;
                }
            }
            return true;
        }
    }
}
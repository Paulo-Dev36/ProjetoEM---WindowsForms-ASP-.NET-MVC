using EM.Domain;
using System.Collections.Generic;

namespace ProjetoEMWeb.Models
{
    public class GrupoAlunosModel
    {
        public IEnumerable<Aluno> Alunos { get; set; }
        public Aluno Aluno { get; set; }
        
    }
}

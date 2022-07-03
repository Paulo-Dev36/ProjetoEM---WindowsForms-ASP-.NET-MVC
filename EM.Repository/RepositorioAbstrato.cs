using EM.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EM.Repository
{
    public abstract class RepositorioAbstrato<T> where T : IEntidade
    {
        public abstract void Add(T aluno);
        public abstract void Update(T aluno);
        public abstract void Remove(T aluno);
        public abstract IEnumerable<T> GetAll();
        public abstract IEnumerable<T> Get(Expression < Func < T, bool >> predicate);
    }
}

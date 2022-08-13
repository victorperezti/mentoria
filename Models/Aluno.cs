using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Aluno]")]
    public class Aluno
    {
        public Aluno() => Cursos = new List<Curso>();

        [ExplicitKey]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCriacao { get; set; }

        [Write(false)]
        public List<Curso> Cursos { get; set; }
    }
}
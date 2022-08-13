using System;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[AlunoCurso]")]
    public class AlunoCurso
    {
        [Key]
        public Guid CoursoId { get; set; }
        public Guid AlunoId { get; set; }
        public int Progresso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime UltimaDataAtualizacao { get; set; }
    }
}
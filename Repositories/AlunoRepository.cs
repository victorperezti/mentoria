using System.Collections.Generic;
using System.Linq;
using Blog.Models;
using Dapper;   //dotnet add package Dapper;
                //Dapper é um micro ORM;
using Microsoft.Data.SqlClient; //Esse é o pacote que se conecta a base de dados.
                                //dotnet add package Microsoft.Data.SqlClient

namespace Blog.Repositories
{
    public class AlunoRepository : Repository<Aluno>
    {
        private readonly SqlConnection _connection;

        public AlunoRepository(SqlConnection connection)
        : base(connection)
            => _connection = connection;

        public List<Aluno> GetWithCursos()
        {
            var query = @"
                SELECT [Aluno].[Id],
                 [Aluno].[Nome],
                 [Aluno].[CPF],
                 [Aluno].[Email],
                 [AlunoCurso].[CoursoId],
                 [Curso].[Id],
                 [Curso].[Titulo],
                 [Curso].[Descricao],
                 [Curso].[DuracaoEmMinutos]
                FROM [usina_usrmentoria].[Aluno] as [Aluno]
                INNER JOIN [usina_usrmentoria].[AlunoCurso] as [AlunoCurso]
                ON [AlunoCurso].[AlunoId] = [Aluno].[Id]
                INNER JOIN [usina_usrmentoria].[Curso] AS [Curso]
                ON [Curso].[Id] = [AlunoCurso].[CoursoId]";

            var alunos = new List<Aluno>();

            var items = _connection.Query<Aluno, AlunoCurso, Curso, Aluno>(
                query,
                (aluno, alunocurso, curso) =>
                {
                    var alu = alunos.FirstOrDefault(x => x.Id == aluno.Id);
                    if (alu == null)
                    {
                        alu = aluno;
                        if (alunocurso != null)
                            aluno.Cursos.Add(curso);

                        alunos.Add(alu);
                    }
                    else
                        alu.Cursos.Add(curso);

                    return aluno;
                }, splitOn: "Id, CoursoId, Id");

            return alunos;
        }
    }
}
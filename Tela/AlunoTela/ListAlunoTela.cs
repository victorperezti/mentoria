using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Tela.AlunoTela
{
    public static class ListAlunoTela
    {
        public static void Load()
        {
            // Console.Clear();l
            Console.WriteLine("Lista de alunos");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuAlunoTela.Load();
        }

        private static void List()
        {
            var repository = new Repository<Aluno>(Database.Connection);
            var alunos = repository.Get();

            foreach (var aluno in alunos)
                Console.WriteLine($"Nome:{aluno.Nome} | CPF:{aluno.CPF}");

            // var alunoRepository = new AlunoRepository(Database.Connection);
            // var alunoCursos = alunoRepository.GetWithCursos();

            // foreach (var alunoCurso in alunoCursos)
            // {
            //     Console.Write($"Aluno: {alunoCurso.Nome} \n ");
            //     foreach (var curso in alunoCurso.Cursos)
            //         Console.WriteLine($"Curso:{curso.Titulo}");
            // }            
        }
    }
}
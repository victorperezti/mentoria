using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Tela.CursoTela
{
    public static class ListCursoTela
    {
        public static void Load()
        {
            // Console.Clear();l
            Console.WriteLine("Lista de cursos");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuCursoTela.Load();
        }

        private static void List()
        {
            var repository = new Repository<Curso>(Database.Connection);
            var cursos = repository.Get();

            foreach (var curso in cursos)
                Console.WriteLine($"Curso: {curso.Titulo}");

            // var cursoRepository = new cursoRepository(Database.Connection);
            // var cursoCursos = cursoRepository.GetWithCursos();

            // foreach (var cursoCurso in cursoCursos)
            // {
            //     Console.Write($"curso: {cursoCurso.Nome} \n ");
            //     foreach (var curso in cursoCurso.Cursos)
            //         Console.WriteLine($"Curso:{curso.Titulo}");
            // }            
        }
    }
}
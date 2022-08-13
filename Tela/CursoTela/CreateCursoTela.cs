using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Tela.CursoTela
{
    public static class CreateCursoTela
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Curso");
            Console.WriteLine("-------------");
            Console.Write("Título: ");
            var titulo = Console.ReadLine();

            Console.Write("Descrição: ");
            var descricao = Console.ReadLine();

            Console.Write("Duração em minutos: ");
            var duracao = int.Parse(Console.ReadLine());


            Create(new Curso
            {
                Id = Guid.NewGuid(),
                Titulo = titulo,
                Descricao = descricao,
                DuracaoEmMinutos = duracao,
            });
            Console.ReadKey();
            MenuCursoTela.Load();
        }

        public static void Create(Curso Curso)
        {
            //Console.WriteLine(Curso.Id);
            Console.WriteLine(Curso.Titulo);
            Console.WriteLine(Curso.Descricao);
            Console.WriteLine(Curso.DuracaoEmMinutos);
            Console.WriteLine(Curso.DataCriacao);

            try
            {
                var repository = new Repository<Curso>(Database.Connection);
                repository.Create(Curso);
                Console.WriteLine("Curso cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o Curso");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Tela.CursoTela
{
    public static class UpdateCursoTela
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um Curso");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            Guid id = Guid.Parse(Console.ReadLine());

            Console.Write("Título: ");
            var titulo = Console.ReadLine();

            Console.Write("Descrição: ");
            var descricao = Console.ReadLine();

            Console.Write("Duração ( m ): ");
            var duracaoEmMinutos = int.Parse(Console.ReadLine());

            Update(new Curso
            {
                Id = id,
                Titulo = titulo,
                Descricao = descricao,
                DuracaoEmMinutos = duracaoEmMinutos,
                DataUltimaAtualizacao = DateTime.Now
            });
            Console.ReadKey();
            MenuCursoTela.Load();
        }

        public static void Update(Curso Curso)
        {
            try
            {
                var repository = new Repository<Curso>(Database.Connection);
                repository.Update(Curso);
                Console.WriteLine("Curso atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a Curso");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
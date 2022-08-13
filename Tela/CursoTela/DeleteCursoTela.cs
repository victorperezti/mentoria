using System;
using Blog.Models;
using Blog.Repositories;


namespace Blog.Tela.CursoTela
{
    public static class DeleteCursoTela
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um curso");
            Console.WriteLine("-------------");
            Console.Write("Qual o id do curso que deseja excluir? ");
            var id = Console.ReadLine();

            Delete(id);
            Console.ReadKey();
            MenuCursoTela.Load();
        }

        public static void Delete(string id)
        {
            try
            {
                var repository = new Repository<Curso>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("curso excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o curso");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
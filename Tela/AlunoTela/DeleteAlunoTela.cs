using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Tela.AlunoTela
{
    public static class DeleteAlunoTela
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um Aluno");
            Console.WriteLine("-------------");
            Console.Write("Qual o id do aluno que deseja excluir? ");
            var id = Console.ReadLine();

            Delete(id);
            Console.ReadKey();
            MenuAlunoTela.Load();
        }

        public static void Delete(string id)
        {
            try
            {
                var repository = new Repository<Aluno>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Aluno excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o aluno");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
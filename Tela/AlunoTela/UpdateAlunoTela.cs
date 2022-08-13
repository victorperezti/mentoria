using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Tela.AlunoTela
{
    public static class UpdateAlunoTela
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um aluno");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            Guid id = Guid.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("CPF: ");
            var cpf = Console.ReadLine();

            Update(new Aluno
            {
                Id = id,
                Nome = nome,
                CPF = cpf
            });
            Console.ReadKey();
            MenuAlunoTela.Load();
        }

        public static void Update(Aluno aluno)
        {
            try
            {
                var repository = new Repository<Aluno>(Database.Connection);
                repository.Update(aluno);
                Console.WriteLine("Aluno atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a aluno");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
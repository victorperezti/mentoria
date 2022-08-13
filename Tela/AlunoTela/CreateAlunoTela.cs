using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Tela.AlunoTela
{
    public static class CreateAlunoTela
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Aluno");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("CPF: ");
            var cpf = Console.ReadLine();

            Create(new Aluno
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Email = email,
                CPF = cpf,
                DataCriacao = DateTime.Now
            });
            Console.ReadKey();
            MenuAlunoTela.Load();
        }

        public static void Create(Aluno aluno)
        {
            Console.WriteLine(aluno.Id);
            Console.WriteLine(aluno.Nome);
            Console.WriteLine(aluno.Email);
            Console.WriteLine(aluno.CPF);
            Console.WriteLine(aluno.DataCriacao);

            try
            {
                var repository = new Repository<Aluno>(Database.Connection);
                repository.Create(aluno);
                Console.WriteLine("Aluno cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o aluno");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
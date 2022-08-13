using System;

namespace Blog.Tela.AlunoTela
{
    public static class MenuAlunoTela
    {
        public static void Load()
        {
            // Console.Clear();
            Console.WriteLine("Gestão de alunos");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar alunos");
            Console.WriteLine("2 - Cadastrar alunos");
            Console.WriteLine("3 - Atualizar alunos");
            Console.WriteLine("4 - Excluir alunos");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListAlunoTela.Load();
                    break;
                case 2:
                    CreateAlunoTela.Load();
                    break;
                case 3:
                    UpdateAlunoTela.Load();
                    break;
                case 4:
                    DeleteAlunoTela.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
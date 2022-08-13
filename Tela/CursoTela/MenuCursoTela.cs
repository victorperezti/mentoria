using System;

namespace Blog.Tela.CursoTela
{
    public static class MenuCursoTela
    {
        public static void Load()
        {
            // Console.Clear();
            Console.WriteLine("Gestão de cursos");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar cursos");
            Console.WriteLine("2 - Cadastrar cursos");
            Console.WriteLine("3 - Atualizar cursos");
            Console.WriteLine("4 - Excluir cursos");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCursoTela.Load();
                    break;
                case 2:
                    CreateCursoTela.Load();
                    break;
                case 3:
                    UpdateCursoTela.Load();
                    break;
                case 4:
                    DeleteCursoTela.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
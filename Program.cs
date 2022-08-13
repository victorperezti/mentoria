using System;
using Blog.Tela.AlunoTela;
using Blog.Tela.CursoTela;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Data Source=usinacompany.com;
        User ID=usina_usrmentoria;Password=Abc12345;Connect Timeout=30;Encrypt=False;
        TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
            //ListAlunoTela.Load();
            //Console.Clear();
            Console.WriteLine("Cursos Online");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de aluno");
            Console.WriteLine("2 - Gestão de matricula");
            Console.WriteLine("3 - Gestão de autor");
            Console.WriteLine("4 - Gestão de categoria");
            Console.WriteLine("5 - Vincular curso");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    MenuAlunoTela.Load();
                    break;
                case 5:
                    MenuCursoTela.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}

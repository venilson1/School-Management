using System;
using System.Collections.Generic;
using System.Text;

namespace Screen
{
    class Menu
    {
        private const int exitProgram = 0;
        private const int students = 1;
        private const int teachers = 2;

        static string mensage =
                $"=================================================\n" +
                 "\n        Digite uma das opções abaixo\n" +
                 "\n            1 - Estudantes" +
                 "\n            2 - Professores" +
                 "\n            0 - Sair do Programa\n"+
                 "\n=================================================\n";

        public static void Template()
        {
            Console.WriteLine($"=============================================" +
                              $"\n      S C H O O L   M A N A G E M E N T" +
                              $"\n=============================================\n");
        }
        public static void Start()
        {

            while (true)
            {
                Console.WriteLine(mensage);

                 int value = int.Parse(Console.ReadLine());
                Console.Clear();

                if (value == exitProgram)
                {
                    Template();
                    Console.WriteLine($"\n\n\nObrigado, volte sempre");
                    break;
                }
                else if (value == students)
                {
                    Console.WriteLine("\n================ Estudantes ===============\n");
                    StudentesGrille.Start();
                }
                else if (value == teachers)
                {
                    Console.WriteLine("\n=============== Professores ===============\n");
                    TeachersGrille.Start();
                }
                else
                {
                    Template();
                    Console.WriteLine("================== Opção Invalida ====================");
                    break;
                }
            }
        }
    }
}

using Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Screen
{
    class TeachersGrille
    {
        public const int EXIT_PROGRAM = 0;
        public const int READ = 1;
        public const int REGISTER = 2;

        static string message = "\n    Digite uma das opções abaixo \n" +
                                "\n      1 - Listar clientes" +
                                "\n      2 - Cadastrar Clientes" +
                                "\n      0 - Voltar";
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine(message);

                int value = int.Parse(Console.ReadLine());
                Console.Clear();

                if (value == EXIT_PROGRAM)
                {
                    break;
                }

                else if (value == READ)
                {
                    Console.WriteLine("=========================");
                    Console.WriteLine("   LISTA DE PROFESSORES  ");
                    Console.WriteLine("=========================\n");

                    foreach (Teachers teacher in new Teachers().Read())
                    {
                        Console.WriteLine($"Nome: {teacher.Name}");
                        Console.WriteLine($"Telefone: {teacher.Telephone}");
                        Console.WriteLine($"CPF do Professor: {teacher.CPF}");
                        Console.WriteLine($"Matéria: {teacher.Educate}");
                        Console.WriteLine("======================\n");
                    }

                    Console.ReadLine();
                    Console.Clear();
                }

                else if (value == REGISTER)
                {
                    var teacher = new Teachers();

                    Console.WriteLine("======================");
                    Console.WriteLine("   CADASTRAR PROFESSOR  ");
                    Console.WriteLine("======================\n");


                    Console.WriteLine("Nome do Professor:");
                    var name = teacher.Name = Console.ReadLine();

                    Console.WriteLine($"Telefone de {name}:");
                    teacher.Telephone = Console.ReadLine();

                    Console.WriteLine($"CPF de {name}:");
                    teacher.CPF = Console.ReadLine();

                    Console.WriteLine($"matéria de {name}:");
                    teacher.Educate = Console.ReadLine();

                    teacher.WriteFile();
                    Console.Clear();
                }
            }
        }
    }
}

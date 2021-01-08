using Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Screen
{
    class StudentesGrille
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
                    Console.WriteLine("=======================");
                    Console.WriteLine("    LISTA DE ALUNOS    ");
                    Console.WriteLine("=======================\n");

                    foreach (Base student in new Students().Read())
                    {
                        Console.WriteLine($"Nome: {student.Name}");
                        Console.WriteLine($"Telefone: {student.Telephone}");
                        Console.WriteLine($"Classe: {student.ClassRoom}");
                        Console.WriteLine($"RA: {student.StudentRegistration}");
                        Console.WriteLine("======================\n");
                    }

                    Console.ReadLine();
                    Console.Clear();
                }

                else if (value == REGISTER)
                {
                    var student = new Students();

                    Console.WriteLine("======================");
                    Console.WriteLine("   CADASTRAR ALUNO  ");
                    Console.WriteLine("======================\n");


                    Console.WriteLine("Nome do Aluno:");
                    var name = student.Name = Console.ReadLine();

                    Console.WriteLine($"Telefone de {name}:");
                    student.Telephone = Console.ReadLine();

                    Console.WriteLine($"Classe/Série de {name}: ex.: 1ºA");
                    student.ClassRoom = Console.ReadLine();

                    Console.WriteLine($"Registro de {name}:");
                    student.StudentRegistration = Console.ReadLine();
                    
                    student.WriteFile();
                    Console.Clear();
                }
            }
        }
    }
}

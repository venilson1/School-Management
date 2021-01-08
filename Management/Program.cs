using Class;
using Screen;
using System;

namespace Management
{
    class Program
    {
        public static void Template()
        {
            Console.WriteLine($"=============================================" +
                              $"\n      S C H O O L   M A N A G E M E N T    " +
                              $"\n=============================================\n");
        }
        static void Main(string[] args)
        {
            Template();
            Menu.Start();
        }
    }
}

#region
/*
Console.WriteLine("========= CADASTRO DE ESTUDANTES ==========");

var aluno = new Students();
aluno.Name = "Maria José";
aluno.Telephone = "1198788798";
aluno.ClassRoom = "3ºA";
aluno.StudentRegistration = "788898456";
aluno.WriteFile();

foreach (Base a in new Students().Read())
{
    Console.WriteLine(a.Name);
    Console.WriteLine(a.Telephone);
    Console.WriteLine(a.ClassRoom);
    Console.WriteLine(a.StudentRegistration);
    Console.WriteLine("\n\n");
}



Console.WriteLine("========= CADASTRO DE PROFESSORES ==========");

var prof = new Teachers();
prof.Name = "José Rbamar";
prof.Telephone = "1198788798";
prof.CPF = "39865486548";
prof.Educate = "Portugues";
prof.WriteFile();

foreach (Teachers p in new Teachers().Read())
{
    Console.WriteLine(p.Name);
    Console.WriteLine(p.Telephone);
    Console.WriteLine(p.CPF);
    Console.WriteLine(p.Educate);
    Console.WriteLine("\n\n");
}
*/
#endregion




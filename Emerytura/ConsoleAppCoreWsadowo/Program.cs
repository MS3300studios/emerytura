//Aplikacja w .NET Core
//aplikacja dziala w trybie wsadowym, wykorzystuje parametry 
//przekazane w linii komend
//przykład użycia: app.exe imie Nazwisko Wiek


using System;

namespace ConsoleAppCoreWsadowo
{
    class Program
    {
        const int WiekEmerytalny = 67; //stała globalna  
        static void Main(string[] args)
        {
            if (args.Length < 3) 
            {
                Console.WriteLine("Za malo danych. Wymagane dane: 3");
                return;
            }
            string imie = args[0];
            string nazwisko = args[1];
            int wiek = int.Parse(args[2]);

            Console.WriteLine($"Witaj {imie} {nazwisko}!");



            Console.WriteLine($"Masz {wiek} lat.");
            if (wiek >= WiekEmerytalny) 
                Console.WriteLine("Jestes emerytem");
            else 
                Console.WriteLine($"Do emerytury zostalo ci: {WiekEmerytalny - wiek}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            //tu piszemy kod
            
            Console.WriteLine("Program EMERYTURA");
            //imie
            Console.Write("Podaj swoje imie: ");
            string imie = Console.ReadLine();
            imie = imie.Trim();
            
            //nazwisko
            Console.Write("Podaj swoje nazwisko: ");
            string nazwisko = Console.ReadLine().Trim();

            string pierwszaLitera = nazwisko.Substring(0,1); 
            string reszta = nazwisko.Substring(1);
            nazwisko = pierwszaLitera.ToUpper() + reszta.ToLower();  
            

            //wiek
            Console.Write("Podaj swój wiek: ");
            string s = Console.ReadLine();
            int wiek = int.Parse(s);                                //int.Parse string => int

            //Console.WriteLine("Witaj " + imie +" "+nazwisko+ "!");
            //Console.WriteLine("Witaj, {0} {1}!", nazwisko, imie);   //formatted string
            Console.WriteLine($"Witaj,{imie} {nazwisko}!");        //interpolated string
           

            if (wiek != 2) { Console.Write($"masz {wiek} lat"); }
            else Console.Write($"masz {wiek} lata");

            if(wiek >= 67) Console.WriteLine(" i jestes emerytem");
            else    Console.WriteLine($"do emerytury brakuje ci {67 - wiek} lat");
        }
    }
}

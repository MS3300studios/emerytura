using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleAppVisualBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //tu piszemy kod
            Interaction.MsgBox("Program Emerytura"); //wyskakuje msgbox z zawartością "..."




            Console.WriteLine("Program EMERYTURA");

            //imie
            //Console.Write("Podaj swoje imie: ");
            //string imie = Console.ReadLine().Trim().ToUpper();
            string imie = Interaction.InputBox("podaj imię","tytul okienka").Trim().ToUpper(); //wynik zapamiętany w zmiennej'imie'

            //nazwisko
            //Console.Write("Podaj swoje nazwisko: ");
            //string nazwisko = Console.ReadLine().Trim();
            string nazwisko = Interaction.InputBox("podaj nazwisko", "tytul okienka 2").Trim();
            string pierwszaLitera = nazwisko.Substring(0, 1);
            string reszta = nazwisko.Substring(1);
            nazwisko = pierwszaLitera.ToUpper() + reszta.ToLower();


            //wiek
            //Console.Write("Podaj swój wiek: ");
            //string s = Console.ReadLine();
            string s = Interaction.InputBox("Podaj wiek", "tytul okienka 3");
            int wiek = int.Parse(s);                                //int.Parse string => int

            //Console.WriteLine("Witaj " + imie +" "+nazwisko+ "!");
            //Console.WriteLine("Witaj, {0} {1}!", nazwisko, imie);   //formatted string
            //Console.WriteLine($"Witaj,{imie} {nazwisko}!");        //interpolated string
            Interaction.MsgBox($"Witaj,{imie} {nazwisko}!");

            if (wiek != 2) { Interaction.MsgBox($"masz {wiek} lat"); }
            else Interaction.MsgBox($"masz {wiek} lata");

            if (wiek >= 67) Interaction.MsgBox(" i jestes emerytem");
            else Interaction.MsgBox($"do emerytury brakuje ci {67 - wiek} lat");
        }
    }
}

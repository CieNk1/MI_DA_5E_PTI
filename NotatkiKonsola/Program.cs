// Klasa: Notatka
// Opis: Reprezentuje pojedynczą notatkę z tytułem, treścią i automatycznym identyfikatorem.
// Pola: licznik (static), identyfikator, tytuł, treść
// Metody: Wyswietl(), Diagnostyka()
// Autor: Dariusz MIchalik 5e

using System;

namespace NotatkiKonsola
{
    class Notatka
    {
        private static int licznik = 0;      
        private int identyfikator;          

        protected string tytul;              
        protected string tresc;              

        public Notatka(string tytul, string tresc)
        {
            licznik++;
            identyfikator = licznik;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void Wyswietl()
        {
            Console.WriteLine("\n=== NOTATKA ===");
            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine("Treść: " + tresc);
            Console.WriteLine();
        }

        public void Diagnostyka()
        {
            Console.WriteLine($"{identyfikator};{licznik};{tytul};{tresc}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notatka n1 = new Notatka("Zakupy", "Kupić mleko, chleb i jajka.");
            Notatka n2 = new Notatka("Plan dnia", "Trening, nauka, projekt z C#.");

            n1.Wyswietl();
            n1.Diagnostyka();

            n2.Wyswietl();
            n2.Diagnostyka();


        }
    }
}
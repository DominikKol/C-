using System;

namespace Sortowanie_CLI
{
    class Program
    {
        sealed class Element
        {
            int val;
            public Element(int e) { val = e; }
            public int v { get { return val; } }
        }
        static void sort(Element[] tablica)// int [] t
        {
            Element buf;
            for (uint i = 1; i < tablica.Length; i++)
            {
                uint j = i;
                buf = tablica[j];
                while ((j > 0) && (tablica[j - 1].v > buf.v))
                {
                    tablica[j] = tablica[j - 1];
                    j--;
                }
                tablica[j] = buf;
            }
        }
        static void Blad(string msg)
        {
            ConsoleColor aktualnyKolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(msg);
            Console.ForegroundColor = aktualnyKolor;
        }
        static int WczytajLiczbe(string msg)
        {
            int buf;
            while (true)
            {
                Console.Write(msg);
                try
                {
                    buf = int.Parse(Console.ReadLine());
                    return buf;
                }
                catch (FormatException)
                {
                    ConsoleColor SavFG = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red; // Format
                    Console.WriteLine("Wprowadzono liczbę w złym formacie");
                    Console.ForegroundColor = SavFG;
                }
                catch (OverflowException)
                {
                    ConsoleColor SavFG = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red; // Zakres
                    Console.WriteLine("Wprowadzona liczba jest zbyt duża lub zbyt mała. Dopuszczalny zakres: od 1 do 4294967295");
                    Console.ForegroundColor = SavFG;
                }
                catch (ArgumentNullException) // ^Z
                {
                    ConsoleColor SavFG = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Napotkano koniec strumienia");
                    Console.ForegroundColor = SavFG;
                }
                catch (SystemException e)
                {
                    Blad(e.Message);
                }
                Console.WriteLine("Spróbuj jeszcze raz");
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Title = ("Program 1");
            Element[] tablica;
            try
            {
                tablica = new Element[WczytajLiczbe("Podaj liczbę elementów do posortowania:")];
            }
            catch (System.OutOfMemoryException)
            {
                Blad("Za mało pamięci!");
                return;
            }
            catch (Exception e)
            {
                Blad(e.Message);
                return;
            }
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = new Element(WczytajLiczbe("Podaj element" + i + ":"));
            }
            sort(tablica);
            Console.WriteLine("Posortowane Elementy");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("element" + i + ":" + tablica[i].v);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby oddzielone spacjami.");
            string liczby = Console.ReadLine();
            List<string> lista_danych_wejsciowych = liczby.Split(' ').ToList<string>();
            sprawdzenie_danych(lista_danych_wejsciowych);

            Console.ReadLine();

        }

        static void sprawdzenie_danych(List<string> dane_wejsciowe)
        {
            foreach (var item in dane_wejsciowe)
            {
                int var = 0;
                if (!Int32.TryParse(item,out var))
                {
                    Console.WriteLine("Dane wejściowe nieprawidłowe! {0} nie jest liczbą!");
                    Console.ReadKey();
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
        }

        static void konwersja_string_na_int(List<string> lista_danych_wejsciowych)
        {
            int liczba_pierwsza = Int16.Parse(lista_danych_wejsciowych.First());
            int liczba_druga = Int16.Parse(lista_danych_wejsciowych.Last());
            
            List<int> dzielniki_liczby_pierwszej = new List<int>();
            List<int> dzielniki_liczby_drugiej = new List<int>();


        }

    }
}

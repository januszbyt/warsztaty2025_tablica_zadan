using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicationnr7
{
    public class Student
    {
        // Właściwości klasy
        public string Imie { get; set; }       // Przechowuje imię studenta
        public string Nazwisko { get; set; }   // Przechowuje nazwisko studenta
        public int Wiek { get; set; }          // Przechowuje wiek studenta

        // Konstruktor klasy Student
        public Student(string imie, string nazwisko, int wiek)
        {
            Imie = imie;           // Przypisanie wartości argumentu imie do właściwości Imie
            Nazwisko = nazwisko;   // Przypisanie wartości argumentu nazwisko do właściwości Nazwisko
            Wiek = wiek;           // Przypisanie wartości argumentu wiek do właściwości Wiek
        }
    }
}

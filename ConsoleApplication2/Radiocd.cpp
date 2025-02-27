#include "Radiocd.h"

// Konstruktor klasy radiocd
radiocd::radiocd(int a, int b, int c, string napis)
    : radio(a, b, napis), cd(c) {
    cout << "Konstruktor radiocd: cd = " << cd << endl;
}

// Destruktor klasy radiocd
radiocd::~radiocd() {
    cout << "Usuwam obiekt radiocd" << endl;
}

// Konstruktor kopiuj�cy dla radiocd
radiocd::radiocd(const radiocd& wzor)
    : radio(wzor), cd(wzor.cd) {
    cout << "Konstruktor kopiuj�cy radiocd" << endl;
}

// Operator przypisania dla radiocd
radiocd& radiocd::operator=(const radiocd& wzor) {
    if (this != &wzor) {
        radio::operator=(wzor); // Wywo�anie operatora przypisania z klasy bazowej
        cd = wzor.cd;
        cout << "Operator przypisania radiocd" << endl;
    }
    return *this;
}

// Nadpisana funkcja inna() wy�wietlaj�ca informacje o obiekcie
void radiocd::inna() {
    cout << "Obiekt radio-cd" << endl;
    radio::inna();  // Wywo�anie funkcji inna() z klasy podstawowej
    cout << "CD: " << cd << endl;
}
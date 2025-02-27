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

// Konstruktor kopiujący dla radiocd
radiocd::radiocd(const radiocd& wzor)
    : radio(wzor), cd(wzor.cd) {
    cout << "Konstruktor kopiujący radiocd" << endl;
}

// Operator przypisania dla radiocd
radiocd& radiocd::operator=(const radiocd& wzor) {
    if (this != &wzor) {
        radio::operator=(wzor); // Wywołanie operatora przypisania z klasy bazowej
        cd = wzor.cd;
        cout << "Operator przypisania radiocd" << endl;
    }
    return *this;
}

// Nadpisana funkcja inna() wyświetlająca informacje o obiekcie
void radiocd::inna() {
    cout << "Obiekt radio-cd" << endl;
    radio::inna();  // Wywołanie funkcji inna() z klasy podstawowej
    cout << "CD: " << cd << endl;
}